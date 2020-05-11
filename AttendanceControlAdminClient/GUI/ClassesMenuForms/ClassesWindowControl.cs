using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using AttendanceControlAdminClient.Models;
using System.Windows.Forms;
using AttendanceControlAdminClient.Properties;
using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.GUI.CustomControls;

namespace AttendanceControlAdminClient.GUI.SchedulesMenuForms
{
    /// <summary>
    ///     Menú de clases y horarios
    /// </summary>
    public partial class ClassesWindowControl : UserControl
    {
        private List<Cycle> cycles; //Lista de todos los ciclos
        private List<SchoolClass> schoolClasses; //Lista de las clases del curso seleccionado
        private Cycle selectedCycle; //Ciclo seleccionado
        private Course selectedCourse; //Curso seleccionado
        private Dictionary<int, int> RowBySchedule;// Map que asocia una fila de la tabla a un horario

        public ClassesWindowControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Evento Load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SchedulesWindowControl_Load(object sender, EventArgs e)
        {

            this.SetSchedulesTable();
            await this.GetAllCycles();
            this.PopulateDefaultComboBoxes();

        }

        /// <summary>
        ///       Establece el diseño de la tabla de horarios 
        /// </summary>
        private void SetSchedulesTable()
        {

            //Establece el tamaño de cada columna
            for (int i = 0; i < this.dgvSchedules.Columns.Count; i++)
            {
                this.dgvSchedules.Columns[i].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
            }

            //Establece el color de los horarios de la primera columna
            for (int i = 0; i < this.dgvSchedules.Rows.Count; i++)
            {
                this.dgvSchedules.Rows[i].Cells[0]
                    .Style.ForeColor = Settings.Default.OPTIMA_COLOR;
            }

            this.dgvSchedules.Visible = true;

        }


        /// <summary>
        ///     Obtiene la lista de todos los ciclos del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllCycles()
        {

            try
            {
                this.cycles = await CycleHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Rellena la tabla con las clases del curso seleccionado
        ///     A cada asignatura se le asocia un color de  hasta 10 colores distintos
        /// </summary>
        private void PopulateSchedulesTable()
        {

            //Primero se borra todas las celdas
            this.DeleteSchoolClassCells();

            //Se retira el evento de seleccion de casillas de la tabla
            this.dgvSchedules.CellClick -= this.CellButtons_Click;

            //Lista con los distintos colores disponibles
            var colors = new List<Color>()
            {
                Color.Coral,
                Color.GreenYellow,
                Color.DarkCyan,
                Color.Lime,
                Color.Aquamarine,
                Color.Cyan,
                Color.BlueViolet,
                Color.DarkSeaGreen,
                Color.Pink
            };

            //Map que asocia un color a una asignatura
            var subjectsNameColor = new Dictionary<string, Color>();

            //Indice del color de la lista de colores
            int colorIndex = 0;

            //Para cada clase del curso
            schoolClasses.ForEach(sc =>
            {
                //Fila asociada al horario de la clase
                int row = this.RowBySchedule[sc.Schedule.Id];

                //Rellana la casilla que correspone al horario de la clase con los datos de la clase
                this.dgvSchedules.Rows[row].Cells[(int)sc.Day].Value = sc.Subject.Name;

                //Si la asignatura de la clase no esta aun asociada a un color en el map
                if (!subjectsNameColor.ContainsKey(sc.Subject.Name))
                {
                    //Se crea la asociacion
                    subjectsNameColor.Add(sc.Subject.Name, colors[colorIndex]);
                    //Se pasa al color siguiente mientras haya colores
                    if (colorIndex < colors.Count)
                    {
                        colorIndex++;
                    }
                    //Sino se vuelve a utilizar el primer color  ( En caso de que un curso tenga
                    // más de 10 asignaturas)
                    else
                    {
                        colorIndex = 0;
                    }

                }

                //Se establece como color de fondo de la celda , el color asociado a la asignatura 
                this.dgvSchedules.Rows[row].Cells[(int)sc.Day].Style.BackColor =
                    subjectsNameColor[sc.Subject.Name];
            });

            //Crea el evento de selección de casilla
            this.dgvSchedules.CellClick +=
                new DataGridViewCellEventHandler(this.CellButtons_Click);

        }

        /// <summary>
        ///     Rellena la columna de horarios segun el turno 
        ///     horario del ciclo formativo seleccionado
        /// </summary>
        private void SetSchedulesColumn()
        {

            if (!(selectedCycle.Shift.Schedules is null)
                        && selectedCycle.Shift.Schedules.Count > 0)
            {
                this.dgvSchedules.DefaultCellStyle.SelectionBackColor = Color.White;
                this.dgvSchedules.Rows.Clear();
                this.RowBySchedule = new Dictionary<int, int>();

                List<Schedule> schedules = selectedCycle.Shift.Schedules;
                for (int i = 0; i < schedules.Count; i++)
                {
                    this.dgvSchedules.Rows.Add(schedules[i].Start + " - "
                        + schedules[i].End, "", "", "", "", "");

                    this.RowBySchedule.Add(schedules[i].Id, i);

                }
                this.dgvSchedules.ClearSelection();
            }

        }


        /// <summary>
        ///     Borra las celdas de la tabla
        /// </summary>
        private void DeleteSchoolClassCells()
        {

            for (int i = 0; i < this.dgvSchedules.Rows.Count; i++)
            {
                for (int j = 1; j < this.dgvSchedules.Columns.Count; j++)
                {
                    this.dgvSchedules.Rows[i].Cells[j].Value = "";
                    this.dgvSchedules.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }

        }


        /// <summary>
        ///     Rellena los comboBox de ciclos y cursos 
        ///     y carga por defecto las clases del primer curso 
        ///     del primer ciclo seleccionado
        /// </summary>
        private async void PopulateDefaultComboBoxes()
        {

            if (this.cycles != null && this.cycles.Count > 0)
            {
                this.cbCycles.DataSource = cycles;
                this.cbCycles.DisplayMember = "Name";
                this.cbCycles.ValueMember = "Id";

                this.cbCourses.DataSource = cycles[0].Courses;
                this.cbCourses.DisplayMember = "Year";
                this.cbCourses.ValueMember = "Id";

                this.selectedCycle = this.cycles[0];
                this.selectedCourse = this.selectedCycle.Courses[0];

                //Activa los eventos de seleccion de los combobox
                this.cbCycles.SelectedIndexChanged += ComboBoxCycles_SelectedIndexChanged;
                this.cbCourses.SelectedIndexChanged += CbCourses_SelectedIndexChanged;

                await this.GetClasses();
                this.SetSchedulesColumn();
                this.PopulateSchedulesTable();
            }

        }

        /// <summary>
        ///     Rellena el combobox de cursos
        ///     Método llamado cada vez que que se cambia la selección
        ///     del ciclo formativo
        /// </summary>
        private void PopulateCoursesComboBox()
        {

            this.cbCourses.SelectedIndexChanged -= CbCourses_SelectedIndexChanged;
            this.cbCourses.DataSource = selectedCycle.Courses;
            this.cbCourses.DisplayMember = "Year";
            this.cbCourses.ValueMember = "Id";
            this.cbCourses.SelectedIndex = 0;
            this.cbCourses.SelectedIndexChanged += CbCourses_SelectedIndexChanged;

        }

        /// <summary>
        ///     Evento al cambiar la selección de ciclo formativo,
        ///     se carga la lista de clases del primer curso del ciclo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ComboBoxCycles_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Recupera el ciclo seleccionado
            int cycleId = (int)this.cbCycles.SelectedValue;
            this.selectedCycle = cycles.Find(c => c.Id == cycleId);
            this.selectedCourse = this.selectedCycle.Courses[0];

            //Refresca el combobox de cursos
            this.PopulateCoursesComboBox();

            await this.GetClasses();

            this.SetSchedulesColumn();//Refresca la columna de horarios
            this.PopulateSchedulesTable();

        }

        /// <summary>
        ///     Evento al cambiar la seleccion de curso,
        ///     se carga la lista de clases del curso seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Recupera el curso seleccionado
            int courseId = (int)this.cbCourses.SelectedValue;
            this.selectedCourse = selectedCycle.Courses.Find(c => c.Id == courseId);

            await this.GetClasses();

            this.SetSchedulesColumn();
            this.PopulateSchedulesTable();

        }

        /// <summary>
        ///     Obtiene la lista de clases de un curso del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetClasses()
        {

            try
            {
                this.schoolClasses = await SchoolClassHttpService
                    .GetByCourse(this.selectedCourse.Id);
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
                //Si hay un error se limpia la tabla
                this.DeleteSchoolClassCells();
            }

        }


        /// <summary>
        ///     Evento al hacer click en cualquer celda, si la celda esta libre
        ///     se abre el formulario para crear una nueva clase, sino
        ///     se propone cancelar la clase de la celda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CellButtons_Click(object sender, DataGridViewCellEventArgs e)
        {

            // se recupera la celda clickeada
            int col = this.dgvSchedules.CurrentCell.ColumnIndex;
            int row = this.dgvSchedules.CurrentCell.RowIndex;

            //Siempre que no sea la columna de horarios
            if (col > 0)
            {
                //El dia de la semana corresponde al indice de la columna
                int day = col;

                //La hora en la que empieza la clase corresponse al horario de la primera columna
                string start = this.dgvSchedules.Rows[row].Cells[0].Value.ToString().Substring(0, 5);

                //Recupero la posible clase ya establecida ese dia a esa hora dentro de la lista de clases
                SchoolClass schoolClass = schoolClasses
                       .FirstOrDefault(sc => sc.Day == (DayOfWeek)day && sc.Schedule.Start == start);

                //Sino hay clase prevista ese dia en ese horario, 
                //se abre el formulario para crear una nueva clase
                if (schoolClass is null)
                {                 
                    //Horario correspondiente
                    Schedule schedule = this.selectedCycle.Shift.Schedules
                                 .FirstOrDefault(sc => sc.Start == start);

                    CreateSchoolClassForm form = new CreateSchoolClassForm(
                        this.selectedCourse, 
                        (DayOfWeek)day,
                        schedule);
                    form.OnSchoolClassCreatedDelegate += OnSchoolClassCreatedCallBack;
                    form.ShowDialog();                
                }
                //Si ya existe una clase en la celda, se propone que la clase deje de ser vigente 
                else
                {
                    //Ventanita de confirmación
                    string message = string
                        .Format("Quieres cancelar la clase de {0} prevista a las {2} cada {1}?",
                        schoolClass.Subject.Name,
                        this.dgvSchedules.Columns[col].HeaderText.ToLower(),
                        schoolClass.Schedule.Start);

                    CustomConfirmDialogForm customConfirmDialogForm = new CustomConfirmDialogForm(message);
                    customConfirmDialogForm.ShowDialog();

                    //Si se confirma 
                    if (customConfirmDialogForm.Confirmed)
                    {
                        try
                        {
                            int id = schoolClass.Id;

                            //Envia al cliente http el id de la clase para cancelarla
                            var res = await SchoolClassHttpService.Cancel(id);

                            //Ventanita de exito con aviso
                            message = "La clase ha sido cancelada, recuerda que si " +
                                "esta clase se impartía en varios cursos a la vez y deseas cancelarla " +
                                "también en los demás cursos, tendrás que hacerlo en cada uno de ellos.";

                            CustomSuccesMessageWindow ccdf = new CustomSuccesMessageWindow(message);
                            ccdf.ShowDialog();

                            //Se borra la clase de la lista 
                            schoolClasses.Remove(schoolClass);

                        }
                        catch (ServerErrorException ex)
                        {
                            new CustomErrorMessageWindow(ex.Message).ShowDialog();
                        }
                    }
                }

                this.PopulateSchedulesTable();//Se refresca la tabla en todo caso
            }

            this.dgvSchedules.ClearSelection();

        }

        /// <summary>
        ///     Callback cuando se crea una nueva clase
        /// </summary>
        /// <param name="schoolClass"></param>
        private void OnSchoolClassCreatedCallBack(SchoolClass schoolClass)
        {

            this.schoolClasses.Add(schoolClass);

        }

    }
}


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
    public partial class ClassesWindowControl : UserControl
    {
        private List<Schedule> _schedules; //Horarios generales 
        private List<Cycle> _cycles; //Lista de todos los ciclos
        private List<SchoolClass> _schoolClasses; //Lista de las clases del curso seleccionado
        private Cycle _cycle; //Ciclo seleccionado
        private Course _course; //Curso seleccionado

        public ClassesWindowControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///       Establece la tabla de horarios por defecto 
        ///       Se rellena solamente la columna de horarios 
        /// </summary>
        private void SetSchedulesTable()
        {

            if (!(_cycle.Shift.Schedules is null) && _cycle.Shift.Schedules.Count > 0)
            {

                this.dgvSchedules.Visible = true;
                this.dgvSchedules.DefaultCellStyle.SelectionBackColor = Color.White;
                this.dgvSchedules.Rows.Clear();
                _cycle.Shift.Schedules.ForEach(s =>
                {
                    this.dgvSchedules.Rows.Add(
                        s.Start + " - " + s.End, "", "", "", "", "");

                });


                //Establece el tamaño automatico de cada columna
                for (int i = 0; i < this.dgvSchedules.Columns.Count; i++)
                {
                    this.dgvSchedules.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                //Establece el color de los horarios de la primera columna
                for (int i = 0; i < this.dgvSchedules.Rows.Count; i++)
                {
                    this.dgvSchedules.Rows[i].Cells[0].Style.ForeColor = Settings.Default.OPTIMA_COLOR;
                }

                this.dgvSchedules.ClearSelection();
            }
        }

        /// <summary>
        ///     Borra las clases de la tabla
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
        ///     Rellena la tabla con las clases del curso seleccionado
        ///     A cada asignatura se le asocia un color hasta 10 colores distintos
        /// </summary>
        private void PopulateSchedulesTable()
        {
            this.DeleteSchoolClassCells();
            //Se retira el evento de seleccion de casillas de la tabla
            this.dgvSchedules.CellClick -= this.CellButtons_Click;


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

            //Para cada clase de curso
            _schoolClasses.ForEach(sc =>
            {
                //Rellana la casilla que correspone al horario de la clase con los datos de la clase
                this.dgvSchedules.Rows[sc.Schedule.Id - 1].Cells[(int)sc.Day].Value = sc.Subject.Name;

                //Si la asignatura de la clase no esta aun asociada a un color en el map
                if (!subjectsNameColor.ContainsKey(sc.Subject.Name))
                {
                    //Se crea la asociacion
                    subjectsNameColor.Add(sc.Subject.Name, colors[colorIndex]);
                    //Se pasa al color siguiente mientras haya colores
                    if (colorIndex < 9)
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
                this.dgvSchedules.Rows[sc.Schedule.Id - 1].Cells[(int)sc.Day].Style.BackColor =
                    subjectsNameColor[sc.Subject.Name];


            });


            this.dgvSchedules.CellClick += new DataGridViewCellEventHandler(this.CellButtons_Click);
        }


        /// <summary>
        ///     Recupera la lista de ciclos del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllCycles()
        {
            try
            {
                _cycles = await CycleHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
        }

        /// <summary>
        ///     Rellena los comboBox de ciclos y cursos
        /// </summary>
        private void PopulateComboBoxes()
        {

            this.cbCycles.DataSource = _cycles;
            this.cbCycles.DisplayMember = "Name";
            this.cbCycles.ValueMember = "Id";


            this.cbCycles.SelectedIndex = 0;

            this.cbCourses.DataSource = _cycles[0].Courses;
            this.cbCourses.DisplayMember = "Year";
            this.cbCourses.ValueMember = "Id";

            this.cbCycles.SelectedIndex = 1;
            //Asocio el mismo evento de cambio de seleccion a los dos comboBox
            this.cbCycles.SelectedIndexChanged += new EventHandler(ComboBoxCycles_SelectedIndexChanged);
            this.cbCourses.SelectedIndexChanged += new EventHandler(ComboBoxCycles_SelectedIndexChanged);

            //Provoca el evento
            this.cbCycles.SelectedIndex = 0;

        }

        /// <summary>
        ///     Evento al cambiar cualquiera de los dos combobox:
        ///     Se recupera la lista de clases del curso seleccionado 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ComboBoxCycles_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                //EL id del ciclo seleccionado
                int cycleId = (int)this.cbCycles.SelectedValue;
                _cycle = _cycles.Find(c => c.Id == cycleId);
                //El curso seleccionado ( Primero o segundo)
                int courseYear = this.cbCourses.SelectedIndex + 1;

                _course = _cycle.Courses.FirstOrDefault(c => c.Year == courseYear);
                _schoolClasses = await SchoolClassHttpService.GetByCourse(_course.Id);

                this.SetSchedulesTable();

                this.PopulateSchedulesTable();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
                //Si hay un error se limpia la tabla
                this.DeleteSchoolClassCells();
            }

        }

        /// <summary>
        ///     Evento al hacer click en cualquer celda
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
                string start = this.dgvSchedules.Rows[row].Cells[0].Value.ToString().Substring(0,5);

                //Recupero la `posible clase ya establecida ese dia a esa hora
                SchoolClass schoolClass = _schoolClasses
                       .FirstOrDefault(sc => sc.Day == (DayOfWeek)day && sc.Schedule.Start == start);

               
                //Sino hay clase, se crea una nueva 
                if (schoolClass is null)
                {
    
                    schoolClass = new SchoolClass()
                    {
                        Course = _course,
                        Day = (DayOfWeek)day,
                        Schedule = _cycle.Shift.Schedules
                            .FirstOrDefault(sc => sc.Start == start),
                    };

                    //Se intancia el formulario para elegir la asignatura de la clasey crear la clase
                    CreateSchoolClassForm sscsForm = new CreateSchoolClassForm(schoolClass);
                    sscsForm.ShowDialog();

                    //Al cerrarse se recupera la clase creada
                    SchoolClass createdSchoolClass = sscsForm.CreatedSchoolClass;

                    //Si existe
                    if (!(createdSchoolClass is null))
                    {
                        //Se agrega a la lista
                        _schoolClasses.Add(createdSchoolClass);

                        //Se rellena de nuevo la tabla para refrescar
                        PopulateSchedulesTable();
                    }
                }
                //Si ya existe una clase, se propone que la clase deje de ser vigente 
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

                    //Si se confirma se envia al cliente http la petición
                    if (customConfirmDialogForm.Confirmed)
                    {
                        message = "La clase ha sido cancelada, recuerda que si " +
                            "esta clase se impartía en varios cursos a la vez y deseas cancelarla " +
                            "en los demás cursos también, tendrás que hacerlo en cada uno de ellos.";

                        CustomSuccesMessageWindow ccdf = new CustomSuccesMessageWindow(message,400);
                        ccdf.ShowDialog();
                        try
                        {
                            int id = schoolClass.Id;
                            var res = await SchoolClassHttpService.SetNotCurrent(id);

                            //Se borra la clase de la lista y se vuelve a rellenar
                            _schoolClasses.Remove(schoolClass);
                            this.PopulateSchedulesTable();
                        }
                        catch (ServerErrorException ex)
                        {
                            new CustomErrorMessageWindow(ex.Message).ShowDialog();
                        }
                    }
                }


            }

            this.dgvSchedules.ClearSelection();
        }

        /// <summary>
        ///     Evento al cargar este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SchedulesWindowControl_Load(object sender, EventArgs e)
        {
            await this.GetAllCycles();
            this.PopulateComboBoxes();
        }
    }
}


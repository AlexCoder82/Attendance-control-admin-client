using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using System.Threading.Tasks;
using AttendanceControlAdminClient.Properties;

namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    public partial class CyclesWindowControl : UserControl
    {
        private List<Cycle> cycles;//Lista donde se guarda los ciclos recibidos del servidor
        private Cycle selectedCycle;//Ciclo seleccionado en la tabla de ciclos
        private Course selectedCourse;//Curso seleccionado en el comboBox

        public CyclesWindowControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Evento Load del formulario:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CyclesWindowControl_Load(object sender, EventArgs e)
        {

            this.SetDataGridViews();
            this.SetIconsToolTips();
            await this.GetAllCycles();
            this.PopulateCyclesTable();

        }

        /// <summary>
        ///     Agrega tooltips a los iconos
        /// </summary>
        private void SetIconsToolTips()
        {

            ToolTip toolTip = new ToolTip();
            toolTip.ForeColor = Settings.Default.OPTIMA_COLOR;
            toolTip.SetToolTip(this.buttonAdd, "Nuevo ciclo");
            toolTip.SetToolTip(this.buttonAddSubject, "Añadir una asignatura");
            toolTip.SetToolTip(this.buttonModify, "Modificar");
            toolTip.SetToolTip(this.buttonRemoveSubject, "Retirar asignatura");

        }

        /// <summary>
        ///     Establece una anchura 
        ///     a las columnas de cada tabla
        /// </summary>
        private void SetDataGridViews()
        {

            this.dgvCycles.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCycles.Columns[1].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            this.dgvCycles.Columns[2].Width = 120;
            this.dgvSubjects.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCycles.Columns[2].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

        }

        /// <summary>
        ///     Recibe la lista de ciclos del cliente http
        /// </summary>
        private async Task GetAllCycles()
        {

            try
            {
                cycles = await CycleHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Rellena la tabla de ciclos, en caso de que no haya ciclos, 
        ///     crea 5 registros vacíos por defectos.
        ///     Método llamado cada vez que se actualiza la lista de ciclos.
        /// </summary>
        private void PopulateCyclesTable()
        {

            this.dgvCycles.Rows.Clear();

            //Si hay ciclos 
            if (!(this.cycles is null) && this.cycles.Count > 0)
            {
                this.cycles.ForEach(c =>
                {
                    this.dgvCycles.Rows.Add(c.Id, c.Name, c.Shift.Description);
                });
                //si hay al menos una asignatura, se crea el evento de selección
                this.dgvCycles.SelectionChanged +=
                    new EventHandler(DataGridViewCycles_SelectionChanged);
            }
            //si la lista es nula o no hay ciclos
            if (this.cycles is null)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvCycles.Rows.Add();
                }
                //Se retira el evento de selección
                this.dgvCycles.SelectionChanged -=
                    new EventHandler(DataGridViewCycles_SelectionChanged);
            }
            //Si hay menos de 5 ciclos, se crean filas vacias para llegar hasta 5 filas
            if (this.cycles != null && this.cycles.Count < 5)
            {
                for (int i = this.cycles.Count; i < 5; i++)
                {
                    this.dgvCycles.Rows.Add();
                }
            }

            //Provoca evento de seleccion
            this.dgvCycles.Rows[1].Selected = true;
            this.dgvCycles.Rows[0].Selected = true;

        }

        /// <summary>
        ///     Rellena la tabla de asignaturas del curso seleccionado
        ///     en el comboBox de cursos.
        /// </summary>
        private void PopulateSubjectsTable()
        {
            this.dgvSubjects.SelectionChanged -=
                    new EventHandler(DataGridViewSubjects_SelectionChanged);
            this.dgvSubjects.Rows.Clear();
            if (!(selectedCourse is null) && !(selectedCourse.Subjects is null) && selectedCourse.Subjects.Count > 0)
            {
                selectedCourse.Subjects.ForEach(s =>
                {
                    this.dgvSubjects.Rows.Add(s.Id, s.Name);
                });
                //si hay al menos una asignatura, se instancia el evento de selección
                this.dgvSubjects.SelectionChanged +=
                    new EventHandler(DataGridViewSubjects_SelectionChanged);

            }

            //si la lista es nula ,crea 5 registros vacios
            if (this.selectedCourse is null || this.selectedCourse.Subjects is null)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvSubjects.Rows.Add();
                }
            }

            //si la lista tiene menos de 5 asignaturas 
            if (!(this.selectedCourse is null) && !(this.selectedCourse.Subjects is null) && this.selectedCourse.Subjects.Count < 5)
            {
                int last = this.selectedCourse.Subjects.Count;
                for (int i = last; i < 5; i++)
                {
                    this.dgvSubjects.Rows.Add();
                }
            }

        }




        /// <summary>
        ///     Evento al seleccionar un registro de la tabla ciclos.
        ///     Guarda el ciclo seleccionado en una propriedad de la clase
        ///     y rellena el comboBox de cursos con los cursos del ciclo.
        /// </summary>
        private void DataGridViewCycles_SelectionChanged(object sender, EventArgs e)
        {

            if (this.dgvCycles.SelectedRows.Count >0 && this.dgvCycles.SelectedRows[0].Cells[0].Value != null)
            {
                //Recupera el Id del ciclo del registro seleccionado
                int selectedId = int
                    .Parse(this.dgvCycles.SelectedRows[0].Cells[0].Value
                    .ToString());

                //Recupera el ciclo seleccionado
                selectedCycle = this.cycles
                    .FirstOrDefault(c => c.Id == selectedId);
                
            }
            else
            {
                selectedCycle = null;
                this.selectedCourse = null;
            }
            this.PopulateCoursesComboBoxes();

        }

        /// <summary>
        ///     Al pulsar añadir , se abre la ventana de creación de ciclo, 
        ///     si al cerrarse existe un ciclo creado, 
        ///     se agrega a la lista y a la tabla de ciclos
        /// </summary>
        private void ButtonAddCycle_Click(object sender, EventArgs e)
        {

            CreateCycleForm form = new CreateCycleForm();
            form.OnCycleCreatedDelegate += OnCycleCreatedCallback;
            form.ShowDialog();

        }

        /// <summary>
        ///     Callback cuando se crea un nuevo ciclo
        /// </summary>
        /// <param name="cycle"></param>
        private void OnCycleCreatedCallback(Cycle cycle)
        {

            this.cycles.Add(cycle);
            this.SortTable();
            this.SelectLastCreatedCycle(cycle.Id);

        }

        /// <summary>
        ///     Ordena la tabla de ciclos por nombres 
        /// </summary>
        private void SortTable()
        {

            this.cycles = this.cycles.OrderBy(c => c.Name).ToList();
            this.PopulateCyclesTable();

        }

        /// <summary>
        ///     Al crear un nuevo ciclo, lo selecciona automaticamente en la tabla
        /// </summary>
        /// <param name="cycleId"></param>
        private void SelectLastCreatedCycle(int cycleId)
        {

            DataGridViewRow row = dgvCycles.Rows
                .Cast<DataGridViewRow>()
                .Where(r => ((int)(r.Cells[0].Value)).Equals(cycleId))
                .First();

            this.dgvCycles.ClearSelection();
            this.dgvCycles.Rows[row.Index].Selected = true; ;
            this.dgvCycles.FirstDisplayedScrollingRowIndex = dgvCycles.SelectedRows[0].Index;
        }

        /// <summary>
        ///     Evento al pulsar el botón modificar ciclo:
        ///     Se instancia el formulario para modificar los datos 
        ///     del ciclo seleccionado.
        ///     Si al cerrarse se ha modificado el ciclo, 
        ///     se actualiza el ciclo en la lista y en la tabla.
        /// </summary>
        private void ButtonModifyCycle_Click(object sender, EventArgs e)
        {
            if (this.dgvCycles.SelectedRows[0].Cells[0].Value != null)
            {
                //Recupera el Id del ciclo seleccionado
                int selectedId = int
                    .Parse(this.dgvCycles.SelectedRows[0].Cells[0].Value
                    .ToString());

                //Recupera el ciclo
                Cycle cycle = this.cycles.FirstOrDefault(c => c.Id == selectedId);
                this.selectedCycle = cycle;


                ModifyCycleForm form = new ModifyCycleForm(cycle);
                form.OnCycleUpdatedDelegate += OnCycleUpdatedCallback;
                form.ShowDialog();

            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un ciclo formativo antes.")
                    .ShowDialog();
            }

        }

        /// <summary>
        ///     Callback cuando se modifica un ciclo, actualiza el ciclo y la tabla
        /// </summary>
        /// <param name="cycle"></param>
        private void OnCycleUpdatedCallback(Cycle updatedCycle)
        {

            this.selectedCycle = updatedCycle;
            this.dgvCycles.SelectedRows[0].Cells[1].Value = updatedCycle.Name;
            this.dgvCycles.SelectedRows[0].Cells[2].Value = updatedCycle.Shift.Description;

        }

        /// <summary>
        ///     Rellena el comboBox de cursos. 
        ///     Método llamado cada vez que se selecciona un ciclo en la tabla
        ///     de ciclos.
        /// </summary>
        private async void PopulateCoursesComboBoxes()
        {
            if (selectedCycle != null)
            {


                //Retira el evento de seleccion hasta 
                this.CbCourses.SelectedIndexChanged -= new EventHandler(CbCourses_SelectedIndexChanged);

                this.CbCourses.DataSource = selectedCycle.Courses;
                this.CbCourses.DisplayMember = "Year";
                this.CbCourses.ValueMember = "Id";

                //Primer curso por defecto y listo sus asignaturas
                this.CbCourses.SelectedIndex = 0;
                await this.GetSubjects();
                this.PopulateSubjectsTable();

                //Vuelve a poner el evento de seleccion
                this.CbCourses.SelectedIndexChanged += new EventHandler(CbCourses_SelectedIndexChanged);
            }
            else
            {
                this.CbCourses.DataSource = null;
                this.PopulateSubjectsTable();
            }
            
        }


        /// <summary>
        ///     Evento de seleccion del comboBox de cursos.
        ///     Se recibe del cliente http las asignaturas del curso seleccionado y
        ///     se rellena la tabla de asignaturas
        /// </summary>
        private async void CbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!(selectedCycle is null) && selectedCycle.Courses.Count > 0)
            {
                try
                {
                    await this.GetSubjects();
                    this.PopulateSubjectsTable();
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }
                catch (Exception ex)
                {

                }
            }

        }

        /// <summary>
        ///     Recibe las asignaturas de un curso del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetSubjects()
        {
            int id = (int)CbCourses.SelectedValue;
            selectedCourse = selectedCycle.Courses.Find(c => c.Id == id);
            try
            {
                selectedCourse.Subjects = await SubjectHttpService.GetByCourse(selectedCourse.Id);
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Evento al seleccionar un registro de la tabla de asignaturas.
        ///     Se habilita el botón para poder borrar la asignatura seleccionada
        /// </summary>
        private void DataGridViewSubjects_SelectionChanged(object sender, EventArgs e)
        {

            if (!(selectedCourse is null) && selectedCourse.Subjects.Count > 0
                            && this.dgvSubjects.SelectedRows.Count > 0)
            {

            }

        }

        /// <summary>
        ///     Evento al pulsar añadir asignatura.
        ///     Se instancia un formulario con el curso seleccionado como
        ///     parametro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddSubject1_Click(object sender, EventArgs e)
        {
            if (this.dgvCycles.SelectedRows[0].Cells[0].Value != null)
            {
                AssignSubjectForm form = new AssignSubjectForm(selectedCycle.Name, selectedCourse);
                form.OnSubjectAddedDelegate += OnSubjectAddedCallback;
                form.ShowDialog();

            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un ciclo formativo antes.")
                    .ShowDialog();
            }
        }

        /// <summary>
        ///     Callback al agregar una asignatura a un curso
        /// </summary>
        /// <param name="subject"></param>
        private void OnSubjectAddedCallback(Subject subject)
        {

            this.selectedCourse.Subjects.Add(subject);
            //Se refresca la tabla
            this.PopulateSubjectsTable();

        }

        /// <summary>
        ///     Evento al pulsar el botón Retirar asignatura del primer curso:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonRemoveSubject1_Click(object sender, EventArgs e)
        {

            if (this.dgvSubjects.Rows.Count > 0 
                && this.dgvSubjects.SelectedRows[0].Cells[0].Value != null)
            {
                try
                {

                    //Recupera el Id de la asignatura seleccionada
                    int selectedId = int
                        .Parse(this.dgvSubjects
                            .SelectedRows[0].Cells[0].Value.ToString());

                    //Recupero la asignatura de la lista de asignaturas del curso
                    Subject subject = selectedCourse.Subjects
                            .FirstOrDefault(s => s.Id == selectedId);

                    //Abre dialogo de confirmación
                    string message = string.
                        Format("Si retiras la asignatura {0} de {1}º de {2}, " +
                         "se cancelarán todas las clases, " +
                         "¿Estás seguro de querer retirarla? ",
                         subject.Name, 
                         selectedCourse.Year,
                         selectedCycle.Name);

                    CustomConfirmDialogForm dialog = new CustomConfirmDialogForm(message);
                    dialog.ShowDialog();

                    //Si se confirma se retira la asignatura
                    if (dialog.Confirmed)
                    {
                        //Envio el curso copiado al servicio http y este retorna 
                        //el curso modificado por el servidor
                        await CourseHttpService
                            .RemoveAssignedSubject(selectedCourse.Id, selectedId);

                        //Borro la asignatura del curso
                        selectedCourse.Subjects.Remove(subject);

                        //Refresca la tabla de asignaturas del primer curso
                        this.PopulateSubjectsTable();

                        //Ventanita con mensaje de éxito
                        message = string.Format("La asignatura {0} ha sido " +
                           "retirada de {1}º de {2}",
                           subject.Name, selectedCourse.Year, selectedCycle.Name);

                        new CustomSuccesMessageWindow(message).ShowDialog();
                    }

                }
                catch (ServerErrorException ex)
                {
                    //Ventanita de mensaje de error devuelto por el servidor
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }

            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar una asignatura antes.")
                    .ShowDialog();
            }

        }


    }
}


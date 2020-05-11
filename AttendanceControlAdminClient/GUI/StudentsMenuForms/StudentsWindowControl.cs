using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Exceptions;
using System.Threading.Tasks;
using AttendanceControlAdminClient.GUI.CustomControls;

namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{
    /// <summary>
    ///     Menú alumnos
    /// </summary>
    public partial class StudentsWindowControl : UserControl
    {
        private List<Student> students;//Lista de alumnos
        private Student selectedStudent;//Alumno seleccionado en la tabla
        private int currentPage;
        private string lastName;


        public StudentsWindowControl()
        {
            students = new List<Student>();
            currentPage = 1;
            lastName = "";
            InitializeComponent();
        }

        /// <summary>
        ///     Evento Load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void StudentsWindowControl_Load(object sender, EventArgs e)
        {

            this.SetButtonsTooltips();
            await this.GetAllByPageAndName();
            this.SetDataGridViewStudents();
            this.PopulateDataGridViewStudents();

        }

        /// <summary>
        ///     Establece los tooltips de los iconos
        /// </summary>
        private void SetButtonsTooltips()
        {

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.buttonAddStudent, "Nuevo alumno");
            toolTip.SetToolTip(this.buttonModifyStudent, "Modificar datos personales");
            toolTip.SetToolTip(this.buttonAssignCycle, "Asignar un ciclo formativo");
            toolTip.SetToolTip(this.buttonAssignSubjects, "Asignar asignaturas");
            toolTip.SetToolTip(this.buttonAbsences, "Registro de ausencias");

        }

        /// <summary>
        ///     Establece las medidas de las columnas
        /// </summary>
        private void SetDataGridViewStudents()
        {

            this.dgvStudents.Columns[1].Width = 70;
            this.dgvStudents.Columns[1].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[1].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            this.dgvStudents.Columns[2].Width = 210;
            this.dgvStudents.Columns[2].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[2].HeaderCell.Style.Alignment = 
                DataGridViewContentAlignment.MiddleLeft;
            this.dgvStudents.Columns[3].Width = 300;
            this.dgvStudents.Columns[3].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[3].HeaderCell.Style.Alignment = 
                DataGridViewContentAlignment.MiddleLeft;
            this.dgvStudents.Columns[4].Width = 75;
            this.dgvStudents.Columns[4].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

        }

        /// <summary>
        ///     Obtiene del cliente http, una página de 8 alumnos cuyo primer 
        ///     apellido empieze por la cadena introducida por paramentro 
        /// </summary>
        /// <param name="firstname"></param>
        /// <returns></returns>
        private async Task GetAllByPageAndName()
        {

            try
            {
                students = await StudentHttpService
                    .GetByPageAndLasttName(this.lastName, this.currentPage);
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }



        /// <summary>
        ///     Rellena la tabla de alumnos
        /// </summary>
        private void PopulateDataGridViewStudents()
        {

            this.dgvStudents.Rows.Clear();

            if (!(students is null) )
            {
                students.ForEach(s =>
                {
                    //Si el alumno no tiene ciclo asignado
                    if (s.Course is null)
                    {
                        this.dgvStudents.Rows.Add(s.Id, s.Dni, s.FullName, "Sin asignar", "-");
                    }
                    else
                    {
                        this.dgvStudents.Rows.Add(s.Id, s.Dni, s.FullName, s.Course.Cycle.Name, s.Course.Year + "º");
                    }
                });
                

            }

            //Si no hay alumnos, se crean 8 registros vacios
            if (this.students is null) 
            {
                for (int i = 0; i < 8; i++)
                {
                    this.dgvStudents.Rows.Add();
                }
            }

            if(this.students != null && students.Count < 8)
            {
                for (int i = this.students.Count; i < 8; i++)
                {
                    this.dgvStudents.Rows.Add();
                }
            }

        }

        

        /// <summary>
        ///     Evento al pulsar Dar alta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            //Se instancia el formulario de alta 
            CreateStudentForm createStudentForm = new CreateStudentForm();
            createStudentForm.OnStudentCreatedDelegate += OnStudentCreatedCallBack;
            createStudentForm.ShowDialog();

        }

        /// <summary>
        ///     Callback del alumno creado
        /// </summary>
        /// <param name="student"></param>
        private  void OnStudentCreatedCallBack(Student student)
        {

            //Dispara el evento para que se muestre solo el alumno creado
            this.tbLastName.Text = student.LastName1;
          
        }


        /// <summary>
        ///     Al escribir en el textbox el apellido del alumno:
        ///     Se cargan los alumnos cuyo apellido empiezen por el
        ///     texto introducido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void TextBoxDni_TextChanged(object sender, EventArgs e)
        {
            string lastName = tbLastName.Text;

            students = null;
            this.currentPage = 1;
            this.labelPage.Text = "Página " + this.currentPage;
            this.lastName = lastName;

            await this.GetAllByPageAndName();
            this.PopulateDataGridViewStudents();
        }

        /// <summary>
        ///     Evento al pulsar el boton Modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModify_Click(object sender, EventArgs e)
        {
            //Si se ha seleccionado un registro con un alumno
            if (this.dgvStudents.SelectedRows[0].Cells[0].Value != null)
            {
                int selectedId = (int)this.dgvStudents.SelectedRows[0].Cells[0].Value;
                this.selectedStudent = students
                    .FirstOrDefault(s => s.Id == selectedId);
                //Instancia el formulario para modificar los datos del alumno
                ModifyStudentForm form = new ModifyStudentForm(selectedStudent);
                form.OnStudentUpdatedDelegate = OnStudentUpdatedCallBack;
                form.ShowDialog();                      
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un alumno antes.").ShowDialog();
            }
        }

        /// <summary>
        ///     Callback cuando se modifica un alumno
        /// </summary>
        /// <param name="student"></param>
        private void OnStudentUpdatedCallBack(Student student)
        {

            this.selectedStudent.Dni = student.Dni;
            this.selectedStudent.FirstName = student.FirstName;
            this.selectedStudent.LastName1 = student.LastName1;
            this.selectedStudent.LastName2 = student.LastName2;
            this.dgvStudents.SelectedRows[0].Cells[1].Value = selectedStudent.Dni;
            this.dgvStudents.SelectedRows[0].Cells[2].Value = selectedStudent.FullName;
            
        }


        /// <summary>
        ///     Evento al pulsar el boton Asignar ciclo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAssignCourse_Click(object sender, EventArgs e)
        {
            //Si se ha seleccionado un registro con un alumno
            if (this.dgvStudents.SelectedRows[0].Cells[0].Value != null)
            {
                //Recupera el alumno seleccionado
                int selectedId = (int)this.dgvStudents.SelectedRows[0].Cells[0].Value;
                this.selectedStudent = students
                    .FirstOrDefault(s => s.Id == selectedId);

                //Instancia el formulario para elegir el curso que va a cursar
                AssignCourseForm form = new AssignCourseForm(selectedStudent);
                form.OnAssignCourseDelegate += OnAssignCourseCallBack;
                form.OnRemovedCourseDelegate += OnRemovedCourseCallBack;
                form.ShowDialog();
    
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un alumno antes.").ShowDialog();
            }

        }

        /// <summary>
        ///     Callback cuando se retira la asignacion de un curso
        /// </summary>
        private void OnRemovedCourseCallBack()
        {

            this.selectedStudent.Course = null;
            this.selectedStudent.Subjects = null;
            this.dgvStudents.SelectedRows[0].Cells[3].Value = "Sin asignar";
            this.dgvStudents.SelectedRows[0].Cells[4].Value = "-";

        }

        /// <summary>
        ///     Callback cuando se asigna un nuevo curso al alumno
        /// </summary>
        /// <param name="student"></param>
        private void OnAssignCourseCallBack(Student student)
        {

            selectedStudent.Course = student.Course;
            selectedStudent.Subjects = student.Subjects;
            this.dgvStudents.SelectedRows[0].Cells[3].Value = selectedStudent.Course.Cycle.Name;
            this.dgvStudents.SelectedRows[0].Cells[4].Value = selectedStudent.Course.Year;

        }

        /// <summary>
        ///     Evento al pulsar el botón Asignaturas:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAssignSubjects_Click(object sender, EventArgs e)
        {

            //Si se ha seleccionado un registro con un alumno
            if (this.dgvStudents.SelectedRows[0].Cells[0].Value != null )
            {
                //Recupera el alumno seleccionado
                int selectedId = (int)this.dgvStudents.SelectedRows[0].Cells[0].Value;
                this.selectedStudent = students.FirstOrDefault(s => s.Id == selectedId);

                if (selectedStudent.Course != null)
                {
                    //Instancia el formulario para asignar las asignaturas cursadas
                    AssignSubjectsForm form = new AssignSubjectsForm(selectedStudent);
                    form.OnAssignedSubjectsDelegate += OnAssignedSubjectsCallBack;
                    form.ShowDialog();
                }
                else
                {
                    new CustomErrorMessageWindow("El alumno debe tener un curso asignado.").ShowDialog();

                }
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un alumno antes.").ShowDialog();
            }
        }

        /// <summary>
        ///     Callback cuando se cambia las asignaturas del alumno
        /// </summary>
        /// <param name="student"></param>
        private void OnAssignedSubjectsCallBack(Student student)
        {

            this.selectedStudent.Subjects = student.Subjects;

        }

        /// <summary>
        ///     Evento al pulsar Registo de Ausencias
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAbsences_Click(object sender, EventArgs e)
        {

            //Si se ha seleccionado un registro con un alumno
            if (this.dgvStudents.SelectedRows[0].Cells[0].Value != null)
            {
                //Obtiene el alumno seleccionado
                int selectedId = (int)this.dgvStudents.SelectedRows[0].Cells[0].Value;
                this.selectedStudent = students.FirstOrDefault(s => s.Id == selectedId);

                AbsencesForm absencesForm = new AbsencesForm(selectedStudent);
                absencesForm.ShowDialog();
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un alumno antes.").ShowDialog();
            }
        }

        /// <summary>
        ///     Evento del botón Pagina Anterior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonPrevious_Click(object sender, EventArgs e)
        {

            if (this.currentPage > 1)
            {
                this.currentPage--;

                await this.GetAllByPageAndName();

                this.PopulateDataGridViewStudents();
                this.labelPage.Text = "Página " + this.currentPage;
            }

        }

        /// <summary>
        ///     Evento del botón Pagina Siguiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonNext_Click(object sender, EventArgs e)
        {
            bool canGetPage = true;

            //Si la página actual tiene entre 1 y 7 alumnos, es la última
            if (this.students.Count < 8 && this.students.Count > 0)
            {
                canGetPage = false;
            }

            if (canGetPage)
            {
                currentPage++;

                await GetAllByPageAndName();

                if (this.students.Count > 0)
                {
                    this.PopulateDataGridViewStudents();

                }
                //Si la última página no tiene alumnos, no se muestra
                else
                {
                    currentPage--;

                }
                this.labelPage.Text = "Página " + this.currentPage;
            }

        }

    }
}

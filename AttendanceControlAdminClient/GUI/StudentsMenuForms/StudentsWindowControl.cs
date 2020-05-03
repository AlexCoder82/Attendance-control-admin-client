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
        ///     Evento al cargar este formulario
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
            this.dgvStudents.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvStudents.Columns[2].Width = 210;
            this.dgvStudents.Columns[2].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvStudents.Columns[3].Width = 300;
            this.dgvStudents.Columns[3].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvStudents.Columns[4].Width = 75;
            this.dgvStudents.Columns[4].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        /// <summary>
        ///     Recupera una página de 8 alumnos cuyo primer apellido empieze por 
        ///     la cadena introducida por paramentro 
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

            if (!(students is null) && students.Count > 0)
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
            if ((students is null) || students.Count == 0)
            {
                for (int i = 0; i < 8; i++)
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
            createStudentForm.ShowDialog();

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
                selectedStudent = students
                    .FirstOrDefault(s => s.Id == selectedId);
                //Instancia el formulario para modificar los datos del alumno
                ModifyStudentForm msForm = new ModifyStudentForm(selectedStudent);
                msForm.ShowDialog();

                // Al cerrarse la ventana, se recupera el alumno actualizado
                Student updatedStudent = msForm.UpdatedStudent;

                if (!(updatedStudent is null))
                {
                    selectedStudent.Dni = updatedStudent.Dni;
                    selectedStudent.FirstName = updatedStudent.FirstName;
                    selectedStudent.LastName1 = updatedStudent.LastName1;
                    selectedStudent.LastName2 = updatedStudent.LastName2;
                    this.dgvStudents.SelectedRows[0].Cells[1].Value = selectedStudent.Dni;
                    this.dgvStudents.SelectedRows[0].Cells[2].Value = selectedStudent.FullName;
                }
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un alumno antes.").ShowDialog();
            }
        }




        /// <summary>
        ///     Evento al pulsar el boton Asignar ciclo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAssignCycle_Click(object sender, EventArgs e)
        {
            //Si se ha seleccionado un registro con un alumno
            if (this.dgvStudents.SelectedRows[0].Cells[0].Value != null)
            {
                int selectedId = (int)this.dgvStudents.SelectedRows[0].Cells[0].Value;
                selectedStudent = students
                    .FirstOrDefault(s => s.Id == selectedId);

                //Instancia el formulario para elegir el curso que va a cursar
                AssignCourseForm assignCourseForm = new AssignCourseForm(selectedStudent);
                assignCourseForm.ShowDialog();

                selectedStudent.Course = assignCourseForm.UpdatedStudent.Course;
                selectedStudent.Subjects = assignCourseForm.UpdatedStudent.Subjects;

                //Si se ha cambiado el curso asignado o simplemente no se ha tocado,
                //se actualiza la tabla
                if (selectedStudent.Course != null)
                {
                    this.dgvStudents.SelectedRows[0].Cells[3].Value = selectedStudent.Course.Cycle.Name;
                    this.dgvStudents.SelectedRows[0].Cells[4].Value = selectedStudent.Course.Year;

                }
                //Si se ha retirado la asignacion del rcuso
                else
                    {
                        this.dgvStudents.SelectedRows[0].Cells[3].Value = "Sin asignar";
                        this.dgvStudents.SelectedRows[0].Cells[4].Value = "-";
                      
                    }
                    
                
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un alumno antes.").ShowDialog();
            }

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
                int selectedId = (int)this.dgvStudents.SelectedRows[0].Cells[0].Value;
                selectedStudent = students
                    .FirstOrDefault(s => s.Id == selectedId);

                if (selectedStudent.Course != null)
                {
                    //Instancia el formulario para asignar las asignaturas cursadas
                    AssignSubjectsForm assignSubjectsForm = new AssignSubjectsForm(selectedStudent);
                    assignSubjectsForm.ShowDialog();

                    //Al cerrarse el formulario, se recupera el alumno actualizado
                    Student UpdatedStudent = assignSubjectsForm.UpdatedStudent;

                    //Si existe
                    if (!(UpdatedStudent is null))
                    {
                        //Se actualiza
                        selectedStudent.Subjects = UpdatedStudent.Subjects;
                    }
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

        private void buttonAbsences_Click(object sender, EventArgs e)
        {

            //Si se ha seleccionado un registro con un alumno
            if (this.dgvStudents.SelectedRows[0].Cells[0].Value != null)
            {
                int selectedId = (int)this.dgvStudents.SelectedRows[0].Cells[0].Value;
                selectedStudent = students
                    .FirstOrDefault(s => s.Id == selectedId);
                AbsencesForm absencesForm = new AbsencesForm(selectedStudent);
                absencesForm.ShowDialog();
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un alumno antes.").ShowDialog();
            }
        }

        private async void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (this.currentPage > 1)
            {

                this.currentPage--;

                await this.GetAllByPageAndName();

                this.PopulateDataGridViewStudents();
                this.labelPage.Text = "Página " + this.currentPage;


            }


        }

        private async void buttonNext_Click(object sender, EventArgs e)
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

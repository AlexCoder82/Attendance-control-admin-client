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
        private List<Student> _students;//Lista de alumnos
        private Student _selectedStudent;//Alumno seleccionado en la tabla
        private int currentPage;
        private string lastName;


        public StudentsWindowControl()
        {
            _students = new List<Student>();
            currentPage = 1;
            lastName = "";
            InitializeComponent();
        }

        /// <summary>
        ///     Establece las medidas de las columnas
        /// </summary>
        private void SetDataGridViewStudents()
        {
            this.dgvStudents.Columns[1].Width = 70;
            this.dgvStudents.Columns[1].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvStudents.Columns[2].Width = 200;
            this.dgvStudents.Columns[2].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvStudents.Columns[3].Width = 265;
            this.dgvStudents.Columns[3].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvStudents.Columns[4].Width = 75;
            this.dgvStudents.Columns[4].Resizable = DataGridViewTriState.False;
            this.dgvStudents.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        /// <summary>
        ///     Recupera la lista de alumnos cuyo primer apellido empieze por 
        ///     la cadena introducida por paramentro 
        /// </summary>
        /// <param name="firstname"></param>
        /// <returns></returns>
        private async Task GetAllByPageAndName()
        {
            try
            {
                _students = await StudentHttpService.GetByPageAndLasttName(this.lastName, this.currentPage);

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

            //Retira el evento de selección por defecto
            this.dgvStudents.SelectionChanged -= this.DataGridViewStudents_SelectionChanged;

            if (!(_students is null) && _students.Count > 0)
            {
                _students.ForEach(s =>
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
                //Habilita el evento de seleccion si hay al menos un alumno en la tabla
                this.dgvStudents.SelectionChanged += new System.EventHandler(this.DataGridViewStudents_SelectionChanged);

            }

            //Si no hay alumnos, se crean 5 registros vacios
            if ((_students is null) || _students.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvStudents.Rows.Add();
                }
            }

            this.dgvStudents.ClearSelection();
            this.btnModify.Enabled = false;
            this.btnAssignCycle.Enabled = false;
            this.brnAssignSubjects.Enabled = false;
            this.buttonAbsences.Enabled = false;

        }

        /// <summary>
        ///     Evento al seleccionar un alumno de la tabla:
        ///     Se habilitan los botones de opciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (!(_students is null) && _students.Count > 0
                && this.dgvStudents.SelectedRows.Count > 0)
            {
                this.btnModify.Enabled = true;
                this.btnAssignCycle.Enabled = true;
                this.buttonAbsences.Enabled = true;
                //Se recupera el alumno de la lista
                int selectedId = (int)this.dgvStudents.SelectedRows[0].Cells[0].Value;
                _selectedStudent = _students
                    .FirstOrDefault(s => s.Id == selectedId);

                //Si el alumno tiene un ciclo asignado, se habilita
                //el botón para asignar las asignaturas que cursa
                if (!(_selectedStudent.Course is null))
                {
                    this.brnAssignSubjects.Enabled = true;
                }
                else
                {
                    this.brnAssignSubjects.Enabled = false;
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

            //Al cerrarse el formulario, se recupera el alumno creado
            Student createdStudent = createStudentForm.CreatedStudent;

            //Si existe
            if (!(createdStudent is null))
            {
                //_students.Clear();

                _students.Add(createdStudent);
                //this.tbLastName.Clear();
                this.PopulateDataGridViewStudents();
                this.SetDataGridViewStudentsSelectedRow(createdStudent.Id);
            }
        }

        /// <summary>
        ///     Selecciona el registro de la tabla con los datos
        ///     del alumno con el Id pasado por parametro
        /// </summary>
        /// <param name="studentId"></param>
        private void SetDataGridViewStudentsSelectedRow(int studentId)
        {
            //Recupero el registro del alumno
            DataGridViewRow row = this.dgvStudents.Rows
            .Cast<DataGridViewRow>()
                 .FirstOrDefault(r => r.Cells[0].Value.ToString().Equals(studentId.ToString()));

            int index = row.Index;
            this.dgvStudents.Rows[index].Selected = true;
            this.dgvStudents.FirstDisplayedScrollingRowIndex = this.dgvStudents.SelectedRows[0].Index;
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

            _students = null;
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

            //Instancia el formulario para modificar los datos del alumno
            ModifyStudentForm msForm = new ModifyStudentForm(_selectedStudent);
            msForm.ShowDialog();

            // Al cerrarse la ventana, se recupera el alumno actualizado
            Student updatedStudent = msForm.UpdatedStudent;

            if (!(updatedStudent is null))
            {
                _selectedStudent.Dni = updatedStudent.Dni;
                _selectedStudent.FirstName = updatedStudent.FirstName;
                _selectedStudent.LastName1 = updatedStudent.LastName1;
                _selectedStudent.LastName2 = updatedStudent.LastName2;
                Console.WriteLine("AAAAAA" + _selectedStudent.Id);
                this.dgvStudents.SelectedRows[0].Cells[1].Value = _selectedStudent.Dni;
                this.dgvStudents.SelectedRows[0].Cells[2].Value = _selectedStudent.FullName;
            }
        }

        /// <summary>
        ///     Evento al cargar este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void StudentsWindowControl_Load(object sender, EventArgs e)
        {
            await this.GetAllByPageAndName();
            this.SetDataGridViewStudents();
            this.PopulateDataGridViewStudents();
        }

      

        /// <summary>
        ///     Evento al pulsar el boton Asignar ciclo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAssignCycle_Click(object sender, EventArgs e)
        {
            if (!(_students is null) && _students.Count > 0
                && this.dgvStudents.SelectedRows.Count > 0)
            {
                //Instancia el formulario para elegir el curso que va a cursar
                AssignCourseForm assignCourseForm = new AssignCourseForm(_selectedStudent);
                assignCourseForm.ShowDialog();

                //Al cerrarse, se recupera el alumno modificado
                Student UpdatedStudent = assignCourseForm.UpdatedStudent;

                //Si existe
                if (!(UpdatedStudent is null))
                {
                    _selectedStudent.Course = UpdatedStudent.Course;
                    _selectedStudent.Subjects = UpdatedStudent.Subjects;

                    //Si no se ha asignado ciclo o se ha quitao la asignacion 
                    if (UpdatedStudent.Course is null)
                    {
                        this.dgvStudents.SelectedRows[0].Cells[3].Value = "Sin asignar";
                        this.dgvStudents.SelectedRows[0].Cells[4].Value = "-";
                        this.brnAssignSubjects.Enabled = false;
                    }
                    //Si  se ha asignado ciclo 
                    else
                    {
                        this.brnAssignSubjects.Enabled = true;
                        //student.Course.Cycle = UpdatedStudent.Course.Cycle;
                        this.dgvStudents.SelectedRows[0].Cells[3].Value = _selectedStudent.Course.Cycle.Name;
                        this.dgvStudents.SelectedRows[0].Cells[4].Value = _selectedStudent.Course.Year;
                    }
                }
            }

        }

        /// <summary>
        ///     Evento al pulsar el botón Asignaturas:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAssignSubjects_Click(object sender, EventArgs e)
        {
            if (!(_students is null) && _students.Count > 0
                && this.dgvStudents.SelectedRows.Count > 0)
            {
                //Instancia el formulario para asignar las asignaturas cursadas
                AssignSubjectsForm assignSubjectsForm = new AssignSubjectsForm(_selectedStudent);
                assignSubjectsForm.ShowDialog();

                //Al cerrarse el formulario, se recupera el alumno actualizado
                Student UpdatedStudent = assignSubjectsForm.UpdatedStudent;

                //Si existe
                if (!(UpdatedStudent is null))
                {
                    //Se actualiza
                    _selectedStudent.Subjects = UpdatedStudent.Subjects;
                }
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
            if (this._students.Count < 8 && this._students.Count > 0)
            {
                canGetPage = false;

            }

            if (canGetPage)
            {
                currentPage++;

                await GetAllByPageAndName();

                if (this._students.Count > 0)
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

        private void buttonAbsences_Click(object sender, EventArgs e)
        {
            if (!(_students is null) && _students.Count > 0
                && this.dgvStudents.SelectedRows.Count > 0)
            {          
                AbsencesForm absencesForm = new AbsencesForm(_selectedStudent);
                absencesForm.ShowDialog();
            }
        }
    }
}

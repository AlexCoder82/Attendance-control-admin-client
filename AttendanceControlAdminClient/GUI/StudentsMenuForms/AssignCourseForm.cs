using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{
    public partial class AssignCourseForm : CustomDialogForm
    {
        private Student _student;
        private List<Course> _courses;
        private int _selectedCourseId;

        public Student UpdatedStudent { get; set; }

        public AssignCourseForm(Student student)
        {
            _student = student;        
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        ///     Evento al cargar este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AssignNewCycleForm_Load(object sender, EventArgs e)
        {
            this.SetLabels();
            this.SetDataGridViewCourses();
            await this.GetAllCourses();
            this.PopulateDataGridViewCourses();
        }

        /// <summary>
        ///     Recupera la lista de todos los cursos del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllCourses()
        {
            try
            {
                _courses = await CourseHttpService.GetAll();            
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
        }

        /// <summary>
        ///     Establece las medidas de las columnas de la tabla
        /// </summary>
        private void SetDataGridViewCourses()
        {
            this.dgvCourses.Columns[1].Width = 70;
            this.dgvCourses.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        ///     Rellena los labels con los datos del alumno 
        /// </summary>
        private void SetLabels()
        {
            this.LabelDni.Text = _student.Dni;
            this.LabelFullName.Text = _student.FullName;

            if (_student.Course is null)
            {
                this.LabelCurrentCourse.Text = "Sin asignar";  
            }
            else
            {
                this.LabelCurrentCourse.Text = string
                    .Format("{0}º de {1}", _student.Course.Year, _student.Course.Cycle.Name);         
            }
        }

        /// <summary>
        ///     Rellena la tabla de cursos
        /// </summary>
        private void PopulateDataGridViewCourses()
        {
            this.dgvCourses.Rows.Clear();
            this.dgvCourses.SelectionChanged -= 
                this.DataGridViewCourses_SelectionChanged;

            if (!(_courses is null) && _courses.Count > 0)
            {
                _courses.ForEach(c =>
                {
                    
                    this.dgvCourses.Rows.Add(c.Id, c.Year,c.Cycle.Name);
                });

                this.dgvCourses.SelectionChanged += 
                    new System.EventHandler(this.DataGridViewCourses_SelectionChanged);

            }
            if ((_courses is null) || _courses.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvCourses.Rows.Add();
                }
            }

            this.dgvCourses.ClearSelection();
            this.btnAssign.Enabled = false;
            this.LabelNewCourse.Text = "";
        }

        /// <summary>
        ///     Evento al seleccionar un curso en la tabla:
        ///     Se guarda el id del curso seleccionado en la variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewCourses_SelectionChanged(object sender, EventArgs e)
        {

            if (!(_courses is null) && _courses.Count > 0
                && this.dgvCourses.SelectedRows.Count>0)
            {
                try
                {
                    ///Se habilita el botón para asignar un curso
                    this.btnAssign.Enabled = true;

                    //Recupera el Id del curso seleccionado
                    _selectedCourseId = int
                        .Parse(this.dgvCourses.SelectedRows[0].Cells[0].Value.ToString());

                    Course course = _courses.FirstOrDefault(c => c.Id == _selectedCourseId);

                    string courseYear = course.Year.ToString();
                    string cycleName = course.Cycle.Name;

                    string courseName = string
                        .Format("{0}º de {1}",courseYear,cycleName);

                    //Se rellena el label con el nombre del curso seleccionado
                    this.LabelNewCourse.Text = courseName;
                }
                catch (Exception ex)
                {

                }
            }
        }

        /// <summary>
        ///     Evento al pulsar Asignar:
        ///     Se envia al cliente http el id del alumno y el id del curso 
        ///     que va a cursar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAssign_Click(object sender, EventArgs e)
        {
            try
            {
                this.UpdatedStudent = await StudentHttpService
                    .UpdateCourse(_student.Id, _selectedCourseId);

                Course course = _courses.First(c => c.Id == _selectedCourseId);

                this.UpdatedStudent.Course = course;
                //Ventanita con mensaje de exito
                string message = string
                    .Format("El alumno {0} cursará {1}º de {2} y todas las asignaturas del curso por defecto.", 
                    UpdatedStudent.FullName,
                    course.Year, course.Cycle.Name);
                new CustomSuccesMessageWindow(message,0).ShowDialog();
                this.Close();
            }
            catch(ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
        }

        /// <summary>
        ///     Evento al pulsar Retirar asignación:
        ///     Se envia al cliente http el id del alumno para retirar 
        ///     el curso que tiene asignado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonRemoveAssignedCourse_Click(object sender, EventArgs e)
        {
            try
            {
                await StudentHttpService.RemoveCourse(_student.Id);

                this.UpdatedStudent = _student;
                this.UpdatedStudent.Course = null;
                //Ventanita con mensaje de exito
                string message = string
                    .Format("El alumno {0} ya no tiene curso asignado", UpdatedStudent.FullName);
                new CustomSuccesMessageWindow(message,0).ShowDialog();
                this.Close();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
        }
    }
}

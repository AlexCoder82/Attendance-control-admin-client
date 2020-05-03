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
        private List<Course> courses;
        public Student UpdatedStudent{ get; set; }
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
            this.SetButtonsToolTips();
            await this.GetAllCourses();
            this.PopulateDataGridViewCourses();
        }

        /// <summary>
        ///     Rellena los labels con los datos del alumno 
        /// </summary>
        private void SetLabels()
        {

            this.groupBox1.Text = this._student.FullName;
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
        ///     Establece las medidas de las columnas de la tabla
        /// </summary>
        private void SetDataGridViewCourses()
        {

            this.dgvCourses.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCourses.Columns[2].Width = 70;
            this.dgvCourses.Columns[2].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
            this.dgvCourses.Columns[2].DefaultCellStyle.Alignment =
              DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetButtonsToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.buttonAssignCourse, "Asignar el curso.");
            toolTip.SetToolTip(this.buttonRemoveAssignedCourse, "Retirar asignación");
        }

        /// <summary>
        ///     Recupera la lista de todos los cursos del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllCourses()
        {
            try
            {
                courses = await CourseHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
        }
  

        /// <summary>
        ///     Rellena la tabla de cursos
        /// </summary>
        private void PopulateDataGridViewCourses()
        {
            this.dgvCourses.Rows.Clear();

            if (!(courses is null) && courses.Count > 0)
            {
                courses.ForEach(c =>
                {

                    this.dgvCourses.Rows.Add(c.Id, c.Cycle.Name, c.Year);
                });

            }
            if ((courses is null) )
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvCourses.Rows.Add();
                }
            }
            if (courses != null && courses.Count < 5)
            {
                for (int i = courses.Count; i < 5; i++)
                {
                    this.dgvCourses.Rows.Add();
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
            if (this.dgvCourses.SelectedRows[0].Cells[0].Value != null)
            {
                try
                {
                    int id = (int)this.dgvCourses.SelectedRows[0].Cells[0].Value;
                    this.UpdatedStudent = await StudentHttpService
                        .UpdateCourse(_student.Id, id);

                    
                    //Ventanita con mensaje de exito
                    string message = string
                        .Format("El alumno {0} cursará {1}º de {2} y " +
                        "todas las asignaturas del curso por defecto.",
                        UpdatedStudent.FullName,
                        UpdatedStudent.Course.Year, UpdatedStudent.Course.Cycle.Name);
                    new CustomSuccesMessageWindow(message).ShowDialog();
                    this.Close();
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un curso antes.")
                    .ShowDialog();
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
            if (this.dgvCourses.SelectedRows[0].Cells[0].Value != null)
            {
                //Si el alumno ya tiene un curso asignado
                if (this._student.Course != null)
                {
                    try
                    {
                        await StudentHttpService.RemoveCourse(_student.Id);

                        //Ventanita con mensaje de exito
                        string message = string
                            .Format("El alumno {0} ya no cursará {1}ª de {2}.", 
                            this._student.FullName,
                            this._student.Course.Year,
                            this._student.Course.Cycle.Name);
                        new CustomSuccesMessageWindow(message).ShowDialog();

                        this.UpdatedStudent = _student;
                        this.UpdatedStudent.Course = null;
                        this.UpdatedStudent.Subjects = null;
                        this.Close();
                    }
                    catch (ServerErrorException ex)
                    {
                        new CustomErrorMessageWindow(ex.Message).ShowDialog();
                    }
                }
                else
                {
                    string message = string.Format("El alumno {0} no tiene curso asignado.",
                        this._student.FullName);
                    new CustomErrorMessageWindow(message).ShowDialog();
                }
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un curso antes.")
                    .ShowDialog();
            }
        
    }
}
}

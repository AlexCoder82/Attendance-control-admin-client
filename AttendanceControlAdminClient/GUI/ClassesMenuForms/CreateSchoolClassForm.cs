using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.SchedulesMenuForms
{
    public partial class CreateSchoolClassForm : CustomDialogForm
    {
        private Course _course; //Curso de la clase a crear
        private SchoolClass _schoolClass;//Clase a crear
        public SchoolClass CreatedSchoolClass { get; set; }//Clase creada

        public CreateSchoolClassForm(SchoolClass schoolClass)
        {
            _course = schoolClass.Course;
            _schoolClass = schoolClass;
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        ///     Rellena el combobox con todas las asignaturas 
        ///     del curso
        /// </summary>
        private void PopulateComboBoxSubjects()
        {
            this.cbSubjects.DataSource = _course.Subjects;
            this.cbSubjects.DisplayMember = "Name";
            this.cbSubjects.ValueMember = "Id";
        }

        /// <summary>
        ///     Evento al pulsar Guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            //Recupera la asignatura seleccionada
            int subjectId = (int)this.cbSubjects.SelectedValue;
            Subject subject =  _course.Subjects.FirstOrDefault(s => s.Id == subjectId);

            //Establece la asignatura de la clase
            _schoolClass.Subject = subject;

            try
            {
                CreatedSchoolClass = await SchoolClassHttpService.Save(_schoolClass);
                this.Close();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Evento al cargar este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CreateSchoolClassForm_Load(object sender, EventArgs e)
        {
            await this.GetCourseSUbjects();
            this.PopulateComboBoxSubjects();
        }

        private async Task GetCourseSUbjects()
        {
            try
            {          
                _course.Subjects = await SubjectHttpService.GetByCourse(_course.Id);                
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
        }

        /// <summary>
        ///     Evento al pulsar Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.CreatedSchoolClass = null;
            this.Close();
        }
    }
}

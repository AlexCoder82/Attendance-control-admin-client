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
        private Schedule _schedule;//Horario de la clase a crear
        private DayOfWeek _day;//Dia de la semana de la clase a crear

        public delegate void OnSchoolClassCreatedCallBack(SchoolClass schoolClass);
        public OnSchoolClassCreatedCallBack OnSchoolClassCreatedDelegate;

        public SchoolClass CreatedSchoolClass { get; set; }//Clase creada

        public CreateSchoolClassForm(Course course, DayOfWeek day, Schedule schedule)
        {
            _course = course;
            _day = day;
            _schedule = schedule;
            InitializeComponent();
            this.CenterToScreen();

        }

        /// <summary>
        ///     Evento Load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CreateSchoolClassForm_Load(object sender, EventArgs e)
        {

            await this.GetCourseSUbjects();
            this.PopulateComboBoxSubjects();

        }

        /// <summary>
        ///     Obtiene del cliente http, la lista de asignaturas de un curso 
        /// </summary>
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
            if (this.cbSubjects.SelectedValue != null)
            {
                //Recupera la asignatura seleccionada
                int subjectId = (int)this.cbSubjects.SelectedValue;
                Subject subject = _course.Subjects.FirstOrDefault(s => s.Id == subjectId);

                //Si la asignatura no tiene profesor asignado, no se puede crear una clase
                if (subject.Teacher is null)
                {
                    string message = "No puedes crear esta clase porque la asignatura "
                        + subject.Name + " no tiene profesor asignado.";
                    CustomErrorMessageWindow dialog = new CustomErrorMessageWindow(message);
                    dialog.ShowDialog();
                }
                else
                {
                    try
                    {
                        SchoolClass schoolClass = new SchoolClass()
                        {
                            Course = _course,
                            Day = _day,
                            Schedule = _schedule,
                            Subject = subject
                        };

                        //El cliente http retorna la misma clase creada 
                        schoolClass = await SchoolClassHttpService.Save(schoolClass);
                        this.Close();

                        this.OnSchoolClassCreatedDelegate(schoolClass);
                    }
                    catch (ServerErrorException ex)
                    {
                        new CustomErrorMessageWindow(ex.Message).ShowDialog();
                    }
                }
            }
        }

        /// <summary>
        ///     Evento al pulsar Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

    }
}

using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using System;
using System.Drawing;

namespace AttendanceControlAdminClient.GUI.TeachersMenuForms
{
    /// <summary>
    ///     Formulario de modificacion de los datos de un profesor
    /// </summary>
    public partial class ModifyTeacherForm : CustomDialogForm
    {
        public delegate void OnTeacherUpdatedCallBack(Teacher teacher);
        public OnTeacherUpdatedCallBack OnTeacherUpdatedDelegate;

        private readonly int teacherId;

        public ModifyTeacherForm(Teacher teacher)
        {
            this.teacherId = teacher.Id;
            InitializeComponent();
            this.PopulateTextBoxes(teacher);
        }

        /// <summary>
        ///     Rellena los textbox con los datos del profesor
        /// </summary>
        private void PopulateTextBoxes(Teacher teacher)
        {

            this.tbDni.Text = teacher.Dni;
            this.tbFirstName.Text = teacher.FirstName;
            this.tbLastName1.Text = teacher.LastName1;
            this.tbLastName2.Text = teacher.LastName2;

        }

        /// <summary>
        ///     Evento al pulsar Guardar cambios:
        ///     Se crea un profesor con los nuevos datos
        ///     introducidos y se envia al cliente http, el cuál retorna
        ///     el profesor actualizado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonCreateTeacher_Click(object sender, EventArgs e)
        {

            this.ResetAsterisks();

            string dni = this.tbDni.Text.TrimStart(' ').TrimEnd(' ');
            string firstName = this.tbFirstName.Text.TrimStart(' ').TrimEnd(' ');
            string lastName1 = this.tbLastName1.Text.TrimStart(' ').TrimEnd(' ');
            string lastName2 = this.tbLastName2.Text.TrimStart(' ').TrimEnd(' ');


            //Si los 3 campos obligatorios tienen texto, se crea el objeto
            if (dni.Length > 0 && firstName.Length > 0 && lastName1.Length > 0)
            {
                Teacher teacher = new Teacher()
                {
                    Id = this.teacherId,
                    Dni = dni,
                    FirstName = firstName,
                    LastName1 = lastName1,
                    LastName2 = lastName2
                };

                try
                {
                    teacher = await TeacherHttpService.Update(teacher);

                    //Ventanita con mensaje de éxito
                    string message = "Has actualizado los datos del profesor";
                    new CustomSuccesMessageWindow(message).ShowDialog();
                    this.Close();

                    this.OnTeacherUpdatedDelegate(teacher);//Respuesta
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }

            }
            //Se cambia el color del asteriscos de los campos obligatorios vacios
            if (dni.Length == 0)
            {
                this.LabelDniAsterisk.ForeColor = Settings.Default.OPTIMA_COLOR;
            }
            if (firstName.Length == 0)
            {
                this.LabelFirstNameAsterisk.ForeColor = Settings.Default.OPTIMA_COLOR;
            }
            if (lastName1.Length == 0)
            {
                this.LabelLastNameAsterisk.ForeColor = Settings.Default.OPTIMA_COLOR;
            }

        }

        /// <summary>
        ///     Establece el color negro por defecto al asterisco
        ///     delante de cada campo obligatorio
        /// </summary>
        private void ResetAsterisks()
        {

            this.LabelDniAsterisk.ForeColor = Color.Black;
            this.LabelFirstNameAsterisk.ForeColor = Color.Black;
            this.LabelLastNameAsterisk.ForeColor = Color.Black;

        }

        /// <summary>
        ///     Evento al pulcar Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void ModifyTeacherForm_Load(object sender, EventArgs e)
        {

        }
    }
}

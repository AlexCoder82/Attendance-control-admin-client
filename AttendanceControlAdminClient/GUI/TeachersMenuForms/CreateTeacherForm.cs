using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using System;
using System.Drawing;

namespace AttendanceControlAdminClient.GUI.TeachersMenuForms
{
    public partial class CreateTeacherForm : CustomDialogForm
    {
        public Teacher CreatedTeacher { get; set; }//El profesor creado

        public CreateTeacherForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Evento al pulsar el Boton Dar alta:
        ///     Se instancia un objecto profesor con los datos introducidos
        ///     y se envia al cliente http, el cuál retorna el profesor 
        ///     creado con su id 
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
                    Dni = dni,
                    FirstName = firstName,
                    LastName1 = lastName1,
                    LastName2 = lastName2
                };

                try
                {
                    this.CreatedTeacher = await TeacherHttpService.Save(teacher);

                    //Ventanita con mensaje de éxito
                    string message = string.Format("Has registrado al profesor {0}.", this.CreatedTeacher.FullName);
                    new CustomSuccesMessageWindow(message).ShowDialog();

                    this.Close();

                }catch(ServerErrorException ex)
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
        ///     delante de cada campo
        /// </summary>
        private void ResetAsterisks()
        {
            this.LabelDniAsterisk.ForeColor = Color.Black;
            this.LabelFirstNameAsterisk.ForeColor = Color.Black;
            this.LabelLastNameAsterisk.ForeColor = Color.Black;
        }

        /// <summary>
        ///     Evento al pulsar el boton Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.CreatedTeacher = null;
            this.Close();
        }
    }
}

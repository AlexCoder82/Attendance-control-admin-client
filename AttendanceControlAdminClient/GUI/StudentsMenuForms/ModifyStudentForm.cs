using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using System;
using System.Drawing;

namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{
    public partial class ModifyStudentForm : CustomDialogForm
    {
        public Student _student; //estudiante a modificar
        public Student UpdatedStudent { get; set; }//Alumno creado

        public ModifyStudentForm(Student student)
        {
            _student = student;
            InitializeComponent();
        }

        /// <summary>
        ///     Rellena los textbox con los datos del alumno
        /// </summary>
        private void SetTextBoxes()
        {
            this.tbDni.Text = _student.Dni;
            this.tbFirstName.Text = _student.FirstName;
            this.tbLastName1.Text = _student.LastName1;
            this.tbLastName2.Text = _student.LastName2;
        }

        /// <summary>
        ///     Evento al pulsar Guardar:
        ///     Se envia al cliente http un objeto alumno
        ///     con los nuevos datos
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
                Student student = new Student()
                {
                    Id = _student.Id,
                    Dni = dni,
                    FirstName = firstName,
                    LastName1 = lastName1,
                    LastName2 = lastName2
                };

                try
                {
                    this.UpdatedStudent = await StudentHttpService.Update(student);
                    //Ventanita con mensaje de éxito
                    string message = string
                        .Format("Has actualizado los datos personales del alumno {0}.",
                        this.UpdatedStudent.FullName);
                    new CustomSuccesMessageWindow(message,0).ShowDialog();

                    this.Close();

                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }

            }

            //Se cambia el color del asteriscos de los campos obligatorios vacios
            if (dni.Length == 0)
            {
                this.lblDniAsterisk.ForeColor = Settings.Default.OPTIMA_COLOR;
            }
            if (firstName.Length == 0)
            {
                this.lblFirstNameAsterisk.ForeColor = Settings.Default.OPTIMA_COLOR;
            }
            if (lastName1.Length == 0)
            {
                this.lblLastNameAsterisk.ForeColor = Settings.Default.OPTIMA_COLOR;
            }
        }


        /// <summary>
        ///     Establece el color negro por defecto al asterisco
        ///     delante de cada campo
        /// </summary>
        private void ResetAsterisks()
        {
            this.lblDniAsterisk.ForeColor = Color.Black;
            this.lblFirstNameAsterisk.ForeColor = Color.Black;
            this.lblLastNameAsterisk.ForeColor = Color.Black;
        }


        /// <summary>
        ///     Evento al pulsar el boton Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.UpdatedStudent = null;
            this.Close();
        }

        /// <summary>
        ///     Evento al cargar este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyStudentForm_Load(object sender, EventArgs e)
        {
            this.SetTextBoxes();
        }

    }
}

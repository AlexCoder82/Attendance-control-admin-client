﻿using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.Properties;
using System;
using System.Drawing;

namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{
    /// <summary>
    ///     Formulario de alta de un alumno
    /// </summary>
    public partial class CreateStudentForm : CustomDialogForm
    {
        public delegate void OnStudentCreatedCallBack(Student student);
        public OnStudentCreatedCallBack OnStudentCreatedDelegate;

        public CreateStudentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Evento al pulsar Guardar:
        ///     Se instancia un objeto alumno con los datos 
        ///     introducidos y se envia al cliente http
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonSaveStudent_Click(object sender, EventArgs e)
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
                    Dni = dni,
                    FirstName = firstName,
                    LastName1 = lastName1,
                    LastName2 = lastName2
                };

                try
                {
                    student = await StudentHttpService.Save(student);
                    //Ventanita con mensaje de éxito
                    string message = string.Format("Has registrado al alumno {0}.",
                        student.FullName);
                    new CustomSuccesMessageWindow(message).ShowDialog();
                    this.Close();

                    this.OnStudentCreatedDelegate(student);

                }catch(ServerErrorException ex)
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
     
            this.Close();

        }
    }
}

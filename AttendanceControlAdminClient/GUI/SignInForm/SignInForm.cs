using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.GUI.MainForm;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;

namespace AttendanceControlAdminClient.GUI.SignInForm
{
    /// <summary>
    ///     Formulario de login
    /// </summary>
    public partial class SignInForm : CustomDialogForm
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Evento al pulsar Conectarse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonSignIn_Click(object sender, EventArgs e)
        {

            Admin admin = new Admin
            {
               AdminName = this.textBoxAdmin.Text,
               Password = this.textBoxPassword.Text
            };

            try
            {
                //Envia las credenciales al cliente http
                await SignInHttpService.SignIn(admin);
                //Se oculta este formulario y se abre la aplicacion principal
                this.Visible = false;
                new MainAppForm().ShowDialog();
            }
            catch(ServerErrorException ex)
            {
                string message = ex.Message;
                CustomErrorMessageWindow dialog = new CustomErrorMessageWindow(message);
                dialog.ShowDialog();
            }
          
        }
    }
}

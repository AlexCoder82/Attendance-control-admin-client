using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.GUI.MainForm;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;

namespace AttendanceControlAdminClient.GUI.SignInForm
{
    public partial class SignInForm : CustomDialogForm
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private async void buttonSignIn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin
            {
               AdminName = this.textBoxAdmin.Text,
               Password = this.textBoxPassword.Text
            };
            try
            {
                bool signedIn = await SignInHttpService.SignIn(admin);
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

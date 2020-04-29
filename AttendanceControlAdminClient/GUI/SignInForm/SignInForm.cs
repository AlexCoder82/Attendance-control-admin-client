using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.GUI.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.SignInForm
{
    public partial class SignInForm : CustomDialogForm
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
           this.Visible = false;
           new MainAppForm().ShowDialog();
        }
    }
}

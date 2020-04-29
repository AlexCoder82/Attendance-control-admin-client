using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    public partial class CustomConfirmDialogForm : CustomDialogForm
    {
        public bool Confirmed { get; set; }
        public CustomConfirmDialogForm(string message)
        {
            InitializeComponent();
            this.lblMessage.Text = message;
            this.CenterToScreen();
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            Confirmed = true;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Confirmed = false;
            this.Close();
        }
    }
}

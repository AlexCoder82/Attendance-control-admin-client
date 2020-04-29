using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    public class CustomTextBox:TextBox
    {
        public CustomTextBox()
        {
           this.ForeColor = Color.Black;
           this.Font = new Font("Arial", 8, FontStyle.Bold);

        }
    }
}

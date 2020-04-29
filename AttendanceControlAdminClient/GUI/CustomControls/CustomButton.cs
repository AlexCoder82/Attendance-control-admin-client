using AttendanceControlAdminClient.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            
            this.BackColor = Settings.Default.OPTIMA_COLOR;
            this.Font = new Font("Arial", 8, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
        }
    }
}

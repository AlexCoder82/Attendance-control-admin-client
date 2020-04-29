using AttendanceControlAdminClient.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.Design.DataGridViewStyle
{
    public class DataGridViewHeaderStyle : DataGridViewCellStyle
    {

        public DataGridViewHeaderStyle()
        {
            this.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.BackColor = Color.White;
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = Settings.Default.OPTIMA_COLOR;
            this.SelectionBackColor = System.Drawing.Color.White;
            this.SelectionForeColor = Settings.Default.OPTIMA_COLOR;
            this.WrapMode = DataGridViewTriState.True;
        }
            
    }
}

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
    public class DataGridViewDefaultCellStyle : DataGridViewCellStyle
    {
        public DataGridViewDefaultCellStyle()
        {
            this.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.BackColor = SystemColors.ControlDark;
            this.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.SelectionBackColor = Settings.Default.OPTIMA_COLOR;
            this.SelectionForeColor = Color.White;
            this.WrapMode = DataGridViewTriState.False;
        }
    }
}

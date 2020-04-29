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
    public class DataGridViewAlternatingRowsStyle : DataGridViewCellStyle
    {
        public DataGridViewAlternatingRowsStyle()
        {
            this.BackColor = SystemColors.ControlLight;
            this.Font = new Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.Black;
            this.SelectionBackColor = Settings.Default.OPTIMA_COLOR;
            this.SelectionForeColor = System.Drawing.Color.White;
        }
    }

}

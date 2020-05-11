using AttendanceControlAdminClient.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.Design.DataGridViewStyle
{
    /// <summary>
    ///     Establece un estilo para las cabeceras de las tablas
    /// </summary>
    public class DataGridViewHeaderStyle : DataGridViewCellStyle
    {

        public DataGridViewHeaderStyle()
        {

            this.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.BackColor = Color.White;
            this.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            this.ForeColor = Settings.Default.OPTIMA_COLOR;
            this.SelectionBackColor = Color.White;
            this.SelectionForeColor = Settings.Default.OPTIMA_COLOR;
            this.WrapMode = DataGridViewTriState.True;

        }
            
    }
}

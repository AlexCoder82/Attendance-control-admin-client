using AttendanceControlAdminClient.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.Design.DataGridViewStyle
{
    /// <summary>
    ///     Establece un estilo para las filas de las tablas
    /// </summary>
    public class DataGridViewAlternatingRowsStyle : DataGridViewCellStyle
    {
        public DataGridViewAlternatingRowsStyle()
        {
            this.BackColor = SystemColors.ControlLight;
            this.Font = new Font("Arial", 8.25F, FontStyle.Bold,
                    GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.Black;
            this.SelectionBackColor = Settings.Default.OPTIMA_COLOR;
            this.SelectionForeColor = Color.White;
        }

    }

}

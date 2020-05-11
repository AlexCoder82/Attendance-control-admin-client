using AttendanceControlAdminClient.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.Design.DataGridViewStyle
{
    /// <summary>
    ///     Establece un estilo para las celdas de las tablas
    /// </summary>
    public class DataGridViewDefaultCellStyle : DataGridViewCellStyle
    {
        public DataGridViewDefaultCellStyle()
        {

            this.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.BackColor = SystemColors.ControlDark;
            this.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point,
                ((byte)(0)));
            this.ForeColor = Color.Black;
            this.SelectionBackColor = Settings.Default.OPTIMA_COLOR;
            this.SelectionForeColor = Color.White;
            this.WrapMode = DataGridViewTriState.False;

        }
    }
}

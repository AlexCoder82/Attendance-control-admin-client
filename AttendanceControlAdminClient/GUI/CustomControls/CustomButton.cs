using AttendanceControlAdminClient.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    /// <summary>
    ///     Estilo de botón personalizado
    /// </summary>
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

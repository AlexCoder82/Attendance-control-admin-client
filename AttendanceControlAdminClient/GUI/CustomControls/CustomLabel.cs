using AttendanceControlAdminClient.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    /// <summary>
    ///     Label personalizado
    /// </summary>
    public class CustomLabel : Label
    {
        public CustomLabel()
        {
            this.ForeColor = Settings.Default.OPTIMA_COLOR;
            this.Font = new Font("Arial", 10, FontStyle.Bold);
        }
    }
}

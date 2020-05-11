using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    /// <summary>
    ///     Textbox personalizado
    /// </summary>
    public class CustomTextBox:TextBox
    {
        public CustomTextBox()
        {
           this.ForeColor = Color.Black;
           this.Font = new Font("Arial", 8, FontStyle.Bold);
        }
    }
}

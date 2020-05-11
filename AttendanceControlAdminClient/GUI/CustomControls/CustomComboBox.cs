using AttendanceControlAdminClient.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    /// <summary>
    ///     Combobox personalizado
    /// </summary>
    public class CustomComboBox : ComboBox
    {
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;

        public CustomComboBox()
        {

            this.ForeColor = Settings.Default.OPTIMA_COLOR;
            this.Font = new Font("Arial", 8, FontStyle.Bold);
            this.Height = 20;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
     
        }
       
        /// <summary>
        ///     Establece el estilo del combobox
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                var g = Graphics.FromHwnd(Handle);

                var p = new Pen(Settings.Default.OPTIMA_COLOR);
                this.BackColor = Color.White;
                this.ForeColor = Settings.Default.OPTIMA_COLOR;
                g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                g.DrawLine(p, Width - buttonWidth, 0, Width - buttonWidth, Height);
            }
        }

        /// <summary>
        ///   Color del fondo al desplegar la lista
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDropDownClosed(EventArgs e)
        {

            this.BackColor = Settings.Default.OPTIMA_COLOR;

        }

    }
}


        

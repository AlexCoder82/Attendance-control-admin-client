using AttendanceControlAdminClient.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    /// <summary>
    ///     Ventanita personalizada de la que heredan la mayoria de las ventanas
    /// </summary>
    public class CustomDialogForm : Form
    {
        private bool mouseIsDown;
        private Point lastLocation;

        public CustomDialogForm()
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.CenterToScreen();
        }

        /// <summary>
        ///     Dibuja un borde rojo
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint( PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Settings.Default.OPTIMA_COLOR,20),
                                     this.DisplayRectangle);
        }

        // EVENTOS PARA DESPLAZAR LA VENTANA

        protected override void OnMouseDown( MouseEventArgs e)
        {

            mouseIsDown = true;
            lastLocation = e.Location;

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {

            if (mouseIsDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }

        }
        protected override void OnMouseUp( MouseEventArgs e)
        {

            mouseIsDown = false;

        }

    }
}

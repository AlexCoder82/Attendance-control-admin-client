using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    /// <summary>
    ///     Estilo de icono circular personalizado
    /// </summary>
    class CustomCircularButton : Button
    {
        private Point defaultLocation;

        public CustomCircularButton()
        {
            this.Size = new Size(50, 50);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        ///     Dibuja un icono circular con la imagen de fondo
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphicsPath);
            this.Text = string.Empty;


            if (this.defaultLocation == new Point(0, 0))
                this.defaultLocation = this.Location;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            if (BackgroundImage != null)
                e.Graphics.DrawImage(BackgroundImage, 0, 0, Width, Height);

            base.OnPaint(e);

        }

        /// <summary>
        ///     Efecto que hace crecer el icono cuando se pone el raton
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseHover(EventArgs e)
        {

            this.Size = new Size(54, 54);
            this.Location = new Point(this.defaultLocation.X - 2, this.defaultLocation.Y - 2);
          
        }

        /// <summary>
        ///     El icono vuelve a su tamaño normal cuando se quita el raton
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseLeave(EventArgs e)
        {

            this.Size = new Size(50, 50);
            this.Location = this.defaultLocation;

        }

    }
}

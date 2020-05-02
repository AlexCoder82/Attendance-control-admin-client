using AttendanceControlAdminClient.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    class CustomCircularButton : Button
    {
        private Point defaultLocation;

        public CustomCircularButton()
        {
            this.Size = new Size(50, 50);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graphicsPath);
            this.Text = string.Empty;


            if (this.defaultLocation == new Point(0, 0))
                this.defaultLocation = this.Location;

            this.BackgroundImageLayout = ImageLayout.Stretch;
            if (BackgroundImage != null)
                e.Graphics.DrawImage(BackgroundImage, 0, 0, Width, Height);
            base.OnPaint(e);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            this.Size = new Size(54, 54);
            this.Location = new Point(this.defaultLocation.X - 2, this.defaultLocation.Y - 2);
            // this.BackgroundImage = (Image)(new Bitmap(this.defaultImage, new Size(34, 34)));
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.Size = new Size(50, 50);
            // this.BackgroundImage = defaultImage;
            this.Location = this.defaultLocation;
        }

    }
}

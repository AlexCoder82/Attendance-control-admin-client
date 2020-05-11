using AttendanceControlAdminClient.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    /// <summary>
    ///     Boton personalizado para minimizar la ventana
    /// </summary>
    class CustomMinimizeButton : PictureBox
    {
        public CustomMinimizeButton()
        {
            this.Image = Resources.icono_minimizar30; ;
            this.TabStop = false;
            this.Size = new Size(30, 30);
            this.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            this.Image = Resources.icono_minimizar35;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.Image = Resources.icono_minimizar30;

        }

        protected override void OnClick(EventArgs e)
        {
            Form form = (Form)FindFormParent(this.Parent);
            form.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        ///     Método recursivo que busca el primer control 
        ///     padre que sea de tipo Form
        /// </summary>
        /// <param name="parent"></param>
        /// <returns></returns>
        private Control FindFormParent(Control parent)
        {
            if (parent is Form)
            {
                return parent;
            }
            else
            {
                return FindFormParent(parent.Parent);
            }
        }
    }
}

using AttendanceControlAdminClient.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    public class CustomCloseButton: PictureBox
    {
       
        public CustomCloseButton()
        {
            this.Image = Resources.icono_cerrar30; ;
            this.TabStop = false;
            this.Size = new Size(30, 30);
            this.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        protected override void OnMouseHover(EventArgs e)
        {
            this.Image = Resources.icono_cerrar35;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.Image = Resources.icono_cerrar30;
            
        }

        protected override void OnClick(EventArgs e)
        {
            Form form = (Form)FindFormParent(this.Parent);
            form.Close();
        }

        /// <summary>
        ///     Método recursivo que busca el primer control padre que sea de tipo Form:
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

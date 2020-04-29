using AttendanceControlAdminClient.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
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
          //  this.DrawItem += new DrawItemEventHandler(AdvancedComboBox_DrawItem);

        }
        //void AdvancedComboBox_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    if (e.Index < 0)
        //        return;

        //    ComboBox combo = sender as ComboBox;
        //    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
        //        e.Graphics.FillRectangle(new SolidBrush(Settings.Default.OPTIMA_COLOR),
        //                                 e.Bounds);
        //    else
        //        e.Graphics.FillRectangle(new SolidBrush(Settings.Default.OPTIMA_COLOR),
        //                                 e.Bounds);

        //    e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font,
        //                          new SolidBrush(Settings.Default.OPTIMA_COLOR),
        //                          new Point(e.Bounds.X, e.Bounds.Y));

        //    e.DrawFocusRectangle();
        //}
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


        protected override void OnDropDownClosed(EventArgs e)
        {
            this.BackColor = Settings.Default.OPTIMA_COLOR;

        }

    }
}


        

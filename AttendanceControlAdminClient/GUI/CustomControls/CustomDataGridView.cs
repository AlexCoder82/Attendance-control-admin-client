using AttendanceControlAdminClient.GUI.Design.DataGridViewStyle;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    public class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            

            this.AllowUserToAddRows = false;
            this.BackgroundColor = System.Drawing.Color.White;
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.ColumnHeadersHeight = 40;
            this.Cursor = Cursors.Hand;
            this.EnableHeadersVisualStyles = false;
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            this.RowTemplate.Height = 30;
            this.RowTemplate.Resizable = DataGridViewTriState.False;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ColumnHeadersDefaultCellStyle = new DataGridViewHeaderStyle();
            this.DefaultCellStyle = new DataGridViewDefaultCellStyle();
            this.AlternatingRowsDefaultCellStyle = new DataGridViewAlternatingRowsStyle();
        }
    }
}

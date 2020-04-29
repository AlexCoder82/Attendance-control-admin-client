using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.Properties;

namespace AttendanceControlAdminClient.GUI.SchedulesMenuForms
{
    partial class ClassesWindowControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.columnSchedules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbCourses = new AttendanceControlAdminClient.GUI.CustomControls.CustomComboBox();
            this.LabelCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.cbCycles = new AttendanceControlAdminClient.GUI.CustomControls.CustomComboBox();
            this.LabelCycle = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AllowUserToAddRows = false;
            this.dgvSchedules.AllowUserToDeleteRows = false;
            this.dgvSchedules.AllowUserToResizeColumns = false;
            this.dgvSchedules.AllowUserToResizeRows = false;
            this.dgvSchedules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSchedules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchedules.ColumnHeadersHeight = 40;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSchedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnSchedules,
            this.columnMonday,
            this.columnTuesday,
            this.columnWednesday,
            this.columnThursday,
            this.columnFriday});
            this.dgvSchedules.EnableHeadersVisualStyles = false;
            this.dgvSchedules.Location = new System.Drawing.Point(28, 81);
            this.dgvSchedules.MultiSelect = false;
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.ReadOnly = true;
            this.dgvSchedules.RowHeadersVisible = false;
            this.dgvSchedules.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSchedules.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchedules.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSchedules.RowTemplate.Height = 50;
            this.dgvSchedules.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchedules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSchedules.Size = new System.Drawing.Size(679, 342);
            this.dgvSchedules.TabIndex = 4;
            this.dgvSchedules.Visible = false;
            // 
            // columnSchedules
            // 
            this.columnSchedules.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnSchedules.HeaderText = "";
            this.columnSchedules.Name = "columnSchedules";
            this.columnSchedules.ReadOnly = true;
            this.columnSchedules.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnSchedules.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnMonday
            // 
            this.columnMonday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnMonday.HeaderText = "LUNES";
            this.columnMonday.Name = "columnMonday";
            this.columnMonday.ReadOnly = true;
            this.columnMonday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnMonday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnTuesday
            // 
            this.columnTuesday.HeaderText = "MARTES";
            this.columnTuesday.Name = "columnTuesday";
            this.columnTuesday.ReadOnly = true;
            this.columnTuesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnTuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnWednesday
            // 
            this.columnWednesday.HeaderText = "MIÉRCOLES";
            this.columnWednesday.Name = "columnWednesday";
            this.columnWednesday.ReadOnly = true;
            this.columnWednesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnWednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnThursday
            // 
            this.columnThursday.HeaderText = "JUEVES";
            this.columnThursday.Name = "columnThursday";
            this.columnThursday.ReadOnly = true;
            this.columnThursday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnThursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnFriday
            // 
            this.columnFriday.HeaderText = "VIERNES";
            this.columnFriday.Name = "columnFriday";
            this.columnFriday.ReadOnly = true;
            this.columnFriday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnFriday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cbCourses
            // 
            this.cbCourses.BackColor = System.Drawing.Color.White;
            this.cbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourses.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(541, 26);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(67, 22);
            this.cbCourses.TabIndex = 3;
            // 
            // LabelCourse
            // 
            this.LabelCourse.AutoSize = true;
            this.LabelCourse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelCourse.Location = new System.Drawing.Point(481, 27);
            this.LabelCourse.Name = "LabelCourse";
            this.LabelCourse.Size = new System.Drawing.Size(54, 16);
            this.LabelCourse.TabIndex = 2;
            this.LabelCourse.Text = "Curso:";
            // 
            // cbCycles
            // 
            this.cbCycles.BackColor = System.Drawing.Color.White;
            this.cbCycles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCycles.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbCycles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.cbCycles.FormattingEnabled = true;
            this.cbCycles.Location = new System.Drawing.Point(89, 25);
            this.cbCycles.Name = "cbCycles";
            this.cbCycles.Size = new System.Drawing.Size(376, 22);
            this.cbCycles.TabIndex = 1;
            // 
            // LabelCycle
            // 
            this.LabelCycle.AutoSize = true;
            this.LabelCycle.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelCycle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelCycle.Location = new System.Drawing.Point(25, 26);
            this.LabelCycle.Name = "LabelCycle";
            this.LabelCycle.Size = new System.Drawing.Size(47, 16);
            this.LabelCycle.TabIndex = 0;
            this.LabelCycle.Text = "Ciclo:";
            // 
            // ClassesWindowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSchedules);
            this.Controls.Add(this.cbCourses);
            this.Controls.Add(this.LabelCourse);
            this.Controls.Add(this.cbCycles);
            this.Controls.Add(this.LabelCycle);
            this.Name = "ClassesWindowControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.SchedulesWindowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLabel LabelCycle;
        private CustomComboBox cbCycles;
        private CustomLabel LabelCourse;
        private CustomComboBox cbCourses;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSchedules;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMonday;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnThursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFriday;
    }
}

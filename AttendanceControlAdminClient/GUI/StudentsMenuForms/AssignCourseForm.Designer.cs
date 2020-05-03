using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.GUI.Design.DataGridViewStyle;
using AttendanceControlAdminClient.Properties;

namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{
    partial class AssignCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle dataGridViewAlternatingRowsStyle1 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle dataGridViewHeaderStyle1 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle dataGridViewDefaultCellStyle1 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignCourseForm));
            this.buttonRemoveAssignedCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonAssignCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.Label3 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.dgvCourses = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.columnIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelCurrentCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.customCloseButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRemoveAssignedCourse
            // 
            this.buttonRemoveAssignedCourse.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_retirar_asignacion;
            this.buttonRemoveAssignedCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveAssignedCourse.FlatAppearance.BorderSize = 0;
            this.buttonRemoveAssignedCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveAssignedCourse.Location = new System.Drawing.Point(509, 130);
            this.buttonRemoveAssignedCourse.Name = "buttonRemoveAssignedCourse";
            this.buttonRemoveAssignedCourse.Size = new System.Drawing.Size(50, 50);
            this.buttonRemoveAssignedCourse.TabIndex = 13;
            this.buttonRemoveAssignedCourse.UseVisualStyleBackColor = true;
            this.buttonRemoveAssignedCourse.Click += new System.EventHandler(this.ButtonRemoveAssignedCourse_Click);
            // 
            // buttonAssignCourse
            // 
            this.buttonAssignCourse.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_asignar;
            this.buttonAssignCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAssignCourse.FlatAppearance.BorderSize = 0;
            this.buttonAssignCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignCourse.Location = new System.Drawing.Point(509, 74);
            this.buttonAssignCourse.Name = "buttonAssignCourse";
            this.buttonAssignCourse.Size = new System.Drawing.Size(50, 50);
            this.buttonAssignCourse.TabIndex = 12;
            this.buttonAssignCourse.UseVisualStyleBackColor = true;
            this.buttonAssignCourse.Click += new System.EventHandler(this.ButtonAssign_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label3.Location = new System.Drawing.Point(29, 38);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Curso actual:";
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            dataGridViewAlternatingRowsStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewAlternatingRowsStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewAlternatingRowsStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewAlternatingRowsStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewAlternatingRowsStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCourses.AlternatingRowsDefaultCellStyle = dataGridViewAlternatingRowsStyle1;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewHeaderStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewHeaderStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle1;
            this.dgvCourses.ColumnHeadersHeight = 40;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIds,
            this.columnCycle,
            this.columnCourse});
            this.dgvCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewDefaultCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDefaultCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDefaultCellStyle1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewDefaultCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewDefaultCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewDefaultCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourses.DefaultCellStyle = dataGridViewDefaultCellStyle1;
            this.dgvCourses.EnableHeadersVisualStyles = false;
            this.dgvCourses.Location = new System.Drawing.Point(32, 65);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCourses.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCourses.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCourses.RowTemplate.Height = 30;
            this.dgvCourses.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(462, 223);
            this.dgvCourses.TabIndex = 11;
            // 
            // columnIds
            // 
            this.columnIds.HeaderText = "ID";
            this.columnIds.Name = "columnIds";
            this.columnIds.ReadOnly = true;
            this.columnIds.Visible = false;
            // 
            // columnCycle
            // 
            this.columnCycle.HeaderText = "Ciclo";
            this.columnCycle.Name = "columnCycle";
            this.columnCycle.ReadOnly = true;
            // 
            // columnCourse
            // 
            this.columnCourse.HeaderText = "Curso";
            this.columnCourse.Name = "columnCourse";
            this.columnCourse.ReadOnly = true;
            // 
            // LabelCurrentCourse
            // 
            this.LabelCurrentCourse.AutoSize = true;
            this.LabelCurrentCourse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelCurrentCourse.ForeColor = System.Drawing.Color.Black;
            this.LabelCurrentCourse.Location = new System.Drawing.Point(156, 38);
            this.LabelCurrentCourse.Name = "LabelCurrentCourse";
            this.LabelCurrentCourse.Size = new System.Drawing.Size(0, 16);
            this.LabelCurrentCourse.TabIndex = 3;
            // 
            // customCloseButton1
            // 
            this.customCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("customCloseButton1.Image")));
            this.customCloseButton1.Location = new System.Drawing.Point(609, 21);
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.Size = new System.Drawing.Size(30, 30);
            this.customCloseButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customCloseButton1.TabIndex = 5;
            this.customCloseButton1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.buttonRemoveAssignedCourse);
            this.groupBox1.Controls.Add(this.buttonAssignCourse);
            this.groupBox1.Controls.Add(this.LabelCurrentCourse);
            this.groupBox1.Controls.Add(this.dgvCourses);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 309);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // AssignCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 357);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customCloseButton1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AssignCourseForm";
            this.Text = "AssignNewCycleForm";
            this.Load += new System.EventHandler(this.AssignNewCycleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomLabel Label3;
        private CustomDataGridView dgvCourses;
        private CustomCloseButton customCloseButton1;
        private CustomCircularButton buttonRemoveAssignedCourse;
        private CustomCircularButton buttonAssignCourse;
        private CustomLabel LabelCurrentCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIds;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCourse;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
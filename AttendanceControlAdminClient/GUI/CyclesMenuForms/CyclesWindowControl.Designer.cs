
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.GUI.Design.DataGridViewStyle;
using AttendanceControlAdminClient.Properties;

namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    partial class CyclesWindowControl
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
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle dataGridViewAlternatingRowsStyle1 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle dataGridViewHeaderStyle1 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle dataGridViewDefaultCellStyle1 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle dataGridViewAlternatingRowsStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle dataGridViewHeaderStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle dataGridViewDefaultCellStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle();
            this.btnRemoveSubject1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.btnAddSubject1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.dgvSubjects1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.idCourse1Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course1SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCycles = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.idCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModifyCycle = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.btnAddCycle = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.labelCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.CbCourses = new AttendanceControlAdminClient.GUI.CustomControls.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCycles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveSubject1
            // 
            this.btnRemoveSubject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnRemoveSubject1.Enabled = false;
            this.btnRemoveSubject1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSubject1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnRemoveSubject1.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSubject1.Location = new System.Drawing.Point(690, 277);
            this.btnRemoveSubject1.Name = "btnRemoveSubject1";
            this.btnRemoveSubject1.Size = new System.Drawing.Size(70, 25);
            this.btnRemoveSubject1.TabIndex = 9;
            this.btnRemoveSubject1.Text = "Retirar";
            this.btnRemoveSubject1.UseVisualStyleBackColor = false;
            this.btnRemoveSubject1.Visible = false;
            this.btnRemoveSubject1.Click += new System.EventHandler(this.ButtonRemoveSubject1_Click);
            // 
            // btnAddSubject1
            // 
            this.btnAddSubject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnAddSubject1.Enabled = false;
            this.btnAddSubject1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddSubject1.ForeColor = System.Drawing.Color.White;
            this.btnAddSubject1.Location = new System.Drawing.Point(690, 246);
            this.btnAddSubject1.Name = "btnAddSubject1";
            this.btnAddSubject1.Size = new System.Drawing.Size(70, 25);
            this.btnAddSubject1.TabIndex = 8;
            this.btnAddSubject1.Text = "Añadir +";
            this.btnAddSubject1.UseVisualStyleBackColor = false;
            this.btnAddSubject1.Visible = false;
            this.btnAddSubject1.Click += new System.EventHandler(this.ButtonAddSubject1_Click);
            // 
            // dgvSubjects1
            // 
            this.dgvSubjects1.AllowUserToAddRows = false;
            this.dgvSubjects1.AllowUserToDeleteRows = false;
            dataGridViewAlternatingRowsStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewAlternatingRowsStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewAlternatingRowsStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewAlternatingRowsStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewAlternatingRowsStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSubjects1.AlternatingRowsDefaultCellStyle = dataGridViewAlternatingRowsStyle1;
            this.dgvSubjects1.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubjects1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubjects1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSubjects1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewHeaderStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHeaderStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects1.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle1;
            this.dgvSubjects1.ColumnHeadersHeight = 40;
            this.dgvSubjects1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubjects1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCourse1Subject,
            this.course1SubjectName});
            this.dgvSubjects1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewDefaultCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDefaultCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDefaultCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewDefaultCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewDefaultCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewDefaultCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects1.DefaultCellStyle = dataGridViewDefaultCellStyle1;
            this.dgvSubjects1.EnableHeadersVisualStyles = false;
            this.dgvSubjects1.Location = new System.Drawing.Point(232, 236);
            this.dgvSubjects1.MultiSelect = false;
            this.dgvSubjects1.Name = "dgvSubjects1";
            this.dgvSubjects1.ReadOnly = true;
            this.dgvSubjects1.RowHeadersVisible = false;
            this.dgvSubjects1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubjects1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjects1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubjects1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects1.Size = new System.Drawing.Size(430, 199);
            this.dgvSubjects1.TabIndex = 7;
            this.dgvSubjects1.Visible = false;
            // 
            // idCourse1Subject
            // 
            this.idCourse1Subject.HeaderText = "ID";
            this.idCourse1Subject.Name = "idCourse1Subject";
            this.idCourse1Subject.ReadOnly = true;
            this.idCourse1Subject.Visible = false;
            // 
            // course1SubjectName
            // 
            this.course1SubjectName.HeaderText = "ASIGNATURAS ";
            this.course1SubjectName.Name = "course1SubjectName";
            this.course1SubjectName.ReadOnly = true;
            // 
            // dgvCycles
            // 
            this.dgvCycles.AllowUserToAddRows = false;
            this.dgvCycles.AllowUserToDeleteRows = false;
            dataGridViewAlternatingRowsStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewAlternatingRowsStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewAlternatingRowsStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewAlternatingRowsStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewAlternatingRowsStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCycles.AlternatingRowsDefaultCellStyle = dataGridViewAlternatingRowsStyle2;
            this.dgvCycles.BackgroundColor = System.Drawing.Color.White;
            this.dgvCycles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCycles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCycles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewHeaderStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHeaderStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCycles.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle2;
            this.dgvCycles.ColumnHeadersHeight = 40;
            this.dgvCycles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCycles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCycle,
            this.cycleName});
            this.dgvCycles.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewDefaultCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDefaultCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDefaultCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewDefaultCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewDefaultCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewDefaultCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCycles.DefaultCellStyle = dataGridViewDefaultCellStyle2;
            this.dgvCycles.EnableHeadersVisualStyles = false;
            this.dgvCycles.Location = new System.Drawing.Point(50, 0);
            this.dgvCycles.MultiSelect = false;
            this.dgvCycles.Name = "dgvCycles";
            this.dgvCycles.ReadOnly = true;
            this.dgvCycles.RowHeadersVisible = false;
            this.dgvCycles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCycles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCycles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCycles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCycles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCycles.Size = new System.Drawing.Size(612, 200);
            this.dgvCycles.TabIndex = 5;
            // 
            // idCycle
            // 
            this.idCycle.HeaderText = "ID";
            this.idCycle.Name = "idCycle";
            this.idCycle.ReadOnly = true;
            this.idCycle.Visible = false;
            // 
            // cycleName
            // 
            this.cycleName.HeaderText = "CICLOS FORMATIVOS";
            this.cycleName.Name = "cycleName";
            this.cycleName.ReadOnly = true;
            // 
            // btnModifyCycle
            // 
            this.btnModifyCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnModifyCycle.Enabled = false;
            this.btnModifyCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyCycle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnModifyCycle.ForeColor = System.Drawing.Color.White;
            this.btnModifyCycle.Location = new System.Drawing.Point(690, 41);
            this.btnModifyCycle.Name = "btnModifyCycle";
            this.btnModifyCycle.Size = new System.Drawing.Size(70, 25);
            this.btnModifyCycle.TabIndex = 3;
            this.btnModifyCycle.Text = "Modificar";
            this.btnModifyCycle.UseVisualStyleBackColor = true;
            this.btnModifyCycle.Click += new System.EventHandler(this.ButtonModifyCycle_Click);
            // 
            // btnAddCycle
            // 
            this.btnAddCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnAddCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCycle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddCycle.ForeColor = System.Drawing.Color.White;
            this.btnAddCycle.Location = new System.Drawing.Point(690, 10);
            this.btnAddCycle.Name = "btnAddCycle";
            this.btnAddCycle.Size = new System.Drawing.Size(70, 25);
            this.btnAddCycle.TabIndex = 2;
            this.btnAddCycle.Text = "Añadir +";
            this.btnAddCycle.UseVisualStyleBackColor = false;
            this.btnAddCycle.Click += new System.EventHandler(this.ButtonAddCycle_Click);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.labelCourse.Location = new System.Drawing.Point(47, 249);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(54, 16);
            this.labelCourse.TabIndex = 0;
            this.labelCourse.Text = "Curso:";
            this.labelCourse.Visible = false;
            // 
            // CbCourses
            // 
            this.CbCourses.BackColor = System.Drawing.Color.White;
            this.CbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCourses.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.CbCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.CbCourses.FormattingEnabled = true;
            this.CbCourses.Location = new System.Drawing.Point(138, 248);
            this.CbCourses.Name = "CbCourses";
            this.CbCourses.Size = new System.Drawing.Size(51, 22);
            this.CbCourses.TabIndex = 1;
            this.CbCourses.Visible = false;
            // 
            // CyclesWindowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSubjects1);
            this.Controls.Add(this.CbCourses);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.btnRemoveSubject1);
            this.Controls.Add(this.btnAddSubject1);
            this.Controls.Add(this.dgvCycles);
            this.Controls.Add(this.btnModifyCycle);
            this.Controls.Add(this.btnAddCycle);
            this.Name = "CyclesWindowControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.CyclesWindowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCycles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton btnAddCycle;
        private CustomButton btnModifyCycle;
        private CustomDataGridView dgvCycles;
        private CustomDataGridView dgvSubjects1;
        private CustomButton btnAddSubject1;
        private CustomButton btnRemoveSubject1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleName;
        private CustomComboBox CbCourses;
        private CustomLabel labelCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCourse1Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn course1SubjectName;
    }
}

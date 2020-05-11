
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CyclesWindowControl));
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle dataGridViewAlternatingRowsStyle1 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle dataGridViewHeaderStyle1 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle dataGridViewDefaultCellStyle1 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle dataGridViewAlternatingRowsStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle dataGridViewHeaderStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle dataGridViewDefaultCellStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle();
            this.buttonRemoveSubject = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonAddSubject = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonModify = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonAdd = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.dgvSubjects = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.idCourse1Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course1SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbCourses = new AttendanceControlAdminClient.GUI.CustomControls.CustomComboBox();
            this.labelCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.dgvCycles = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.idCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cycleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCycles)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemoveSubject
            // 
            this.buttonRemoveSubject.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_retirar;
            this.buttonRemoveSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveSubject.FlatAppearance.BorderSize = 0;
            this.buttonRemoveSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveSubject.Location = new System.Drawing.Point(710, 304);
            this.buttonRemoveSubject.Name = "buttonRemoveSubject";
            this.buttonRemoveSubject.Size = new System.Drawing.Size(50, 50);
            this.buttonRemoveSubject.TabIndex = 18;
            this.buttonRemoveSubject.UseVisualStyleBackColor = true;
            this.buttonRemoveSubject.Click += new System.EventHandler(this.ButtonRemoveSubject1_Click);
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_agregar;
            this.buttonAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddSubject.FlatAppearance.BorderSize = 0;
            this.buttonAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSubject.Location = new System.Drawing.Point(710, 248);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(50, 50);
            this.buttonAddSubject.TabIndex = 14;
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.ButtonAddSubject1_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModify.BackgroundImage")));
            this.buttonModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Location = new System.Drawing.Point(710, 80);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(50, 50);
            this.buttonModify.TabIndex = 13;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.ButtonModifyCycle_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_agregar;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(710, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAddCycle_Click);
            // 
            // dgvSubjects1
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
            this.dgvSubjects.AllowUserToResizeRows = false;
            dataGridViewAlternatingRowsStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewAlternatingRowsStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewAlternatingRowsStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewAlternatingRowsStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewAlternatingRowsStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSubjects.AlternatingRowsDefaultCellStyle = dataGridViewAlternatingRowsStyle1;
            this.dgvSubjects.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSubjects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewHeaderStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHeaderStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle1;
            this.dgvSubjects.ColumnHeadersHeight = 40;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCourse1Subject,
            this.course1SubjectName});
            this.dgvSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewDefaultCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDefaultCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDefaultCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewDefaultCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewDefaultCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewDefaultCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects.DefaultCellStyle = dataGridViewDefaultCellStyle1;
            this.dgvSubjects.EnableHeadersVisualStyles = false;
            this.dgvSubjects.Location = new System.Drawing.Point(186, 236);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.Name = "dgvSubjects1";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubjects.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubjects.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(487, 199);
            this.dgvSubjects.TabIndex = 7;
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
            this.course1SubjectName.HeaderText = "Asignaturas";
            this.course1SubjectName.Name = "course1SubjectName";
            this.course1SubjectName.ReadOnly = true;
            // 
            // CbCourses
            // 
            this.CbCourses.BackColor = System.Drawing.Color.White;
            this.CbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCourses.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.CbCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.CbCourses.FormattingEnabled = true;
            this.CbCourses.Location = new System.Drawing.Point(127, 281);
            this.CbCourses.Name = "CbCourses";
            this.CbCourses.Size = new System.Drawing.Size(47, 22);
            this.CbCourses.TabIndex = 1;
            this.CbCourses.SelectedIndexChanged += new System.EventHandler(this.CbCourses_SelectedIndexChanged);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.labelCourse.Location = new System.Drawing.Point(47, 277);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(74, 22);
            this.labelCourse.TabIndex = 0;
            this.labelCourse.Text = "Curso:";
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
            this.cycleName,
            this.Shift});
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
            this.dgvCycles.Location = new System.Drawing.Point(50, 14);
            this.dgvCycles.MultiSelect = false;
            this.dgvCycles.Name = "dgvCycles";
            this.dgvCycles.ReadOnly = true;
            this.dgvCycles.RowHeadersVisible = false;
            this.dgvCycles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCycles.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCycles.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCycles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCycles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCycles.Size = new System.Drawing.Size(623, 200);
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
            this.cycleName.HeaderText = "Ciclos Formativos";
            this.cycleName.Name = "cycleName";
            this.cycleName.ReadOnly = true;
            // 
            // Shift
            // 
            this.Shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Shift.HeaderText = "Turno";
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            this.Shift.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CyclesWindowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemoveSubject);
            this.Controls.Add(this.buttonAddSubject);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.CbCourses);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.dgvCycles);
            this.Name = "CyclesWindowControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.CyclesWindowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCycles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomDataGridView dgvCycles;
        private CustomDataGridView dgvSubjects;
        private CustomComboBox CbCourses;
        private CustomLabel labelCourse;
        private CustomCircularButton buttonAdd;
        private CustomCircularButton buttonModify;
        private CustomCircularButton buttonAddSubject;
        private CustomCircularButton buttonRemoveSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCourse1Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn course1SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cycleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
    }
}

using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.GUI.Design.DataGridViewStyle;

namespace AttendanceControlAdminClient.GUI.SubjectsMenuForms
{
    partial class AssignTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignTeacherForm));
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle dataGridViewAlternatingRowsStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle dataGridViewHeaderStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle dataGridViewDefaultCellStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle();
            this.LabelTeacher = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelSubject = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelChangeTeacher = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelCurrentSubject = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelCurrentTeacher = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.btnAssign = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.customCloseButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            this.dgvTeachers = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelNewAssignedTeacher = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.ButtonRemoveAssignment = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTeacher
            // 
            this.LabelTeacher.AutoSize = true;
            this.LabelTeacher.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelTeacher.Location = new System.Drawing.Point(48, 86);
            this.LabelTeacher.Name = "LabelTeacher";
            this.LabelTeacher.Size = new System.Drawing.Size(141, 16);
            this.LabelTeacher.TabIndex = 0;
            this.LabelTeacher.Text = "Profesor asignado:";
            // 
            // LabelSubject
            // 
            this.LabelSubject.AutoSize = true;
            this.LabelSubject.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelSubject.Location = new System.Drawing.Point(48, 45);
            this.LabelSubject.Name = "LabelSubject";
            this.LabelSubject.Size = new System.Drawing.Size(87, 16);
            this.LabelSubject.TabIndex = 1;
            this.LabelSubject.Text = "Asignatura:";
            // 
            // LabelChangeTeacher
            // 
            this.LabelChangeTeacher.AutoSize = true;
            this.LabelChangeTeacher.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelChangeTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelChangeTeacher.Location = new System.Drawing.Point(48, 127);
            this.LabelChangeTeacher.Name = "LabelChangeTeacher";
            this.LabelChangeTeacher.Size = new System.Drawing.Size(179, 16);
            this.LabelChangeTeacher.TabIndex = 2;
            this.LabelChangeTeacher.Text = "Asignar nuevo profesor:";
            // 
            // LabelCurrentSubject
            // 
            this.LabelCurrentSubject.AutoSize = true;
            this.LabelCurrentSubject.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelCurrentSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelCurrentSubject.Location = new System.Drawing.Point(250, 45);
            this.LabelCurrentSubject.Name = "LabelCurrentSubject";
            this.LabelCurrentSubject.Size = new System.Drawing.Size(0, 16);
            this.LabelCurrentSubject.TabIndex = 3;
            // 
            // LabelCurrentTeacher
            // 
            this.LabelCurrentTeacher.AutoSize = true;
            this.LabelCurrentTeacher.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelCurrentTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelCurrentTeacher.Location = new System.Drawing.Point(250, 86);
            this.LabelCurrentTeacher.Name = "LabelCurrentTeacher";
            this.LabelCurrentTeacher.Size = new System.Drawing.Size(0, 16);
            this.LabelCurrentTeacher.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(545, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(545, 309);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 25);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Asignar";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.BtnAssign_Click);
            // 
            // customCloseButton1
            // 
            this.customCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("customCloseButton1.Image")));
            this.customCloseButton1.Location = new System.Drawing.Point(607, 21);
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.Size = new System.Drawing.Size(30, 30);
            this.customCloseButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customCloseButton1.TabIndex = 8;
            this.customCloseButton1.TabStop = false;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AllowUserToDeleteRows = false;
            dataGridViewAlternatingRowsStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewAlternatingRowsStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewAlternatingRowsStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewAlternatingRowsStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewAlternatingRowsStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTeachers.AlternatingRowsDefaultCellStyle = dataGridViewAlternatingRowsStyle2;
            this.dgvTeachers.BackgroundColor = System.Drawing.Color.White;
            this.dgvTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTeachers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTeachers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewHeaderStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHeaderStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeachers.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle2;
            this.dgvTeachers.ColumnHeadersHeight = 40;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnDni,
            this.columnFullName});
            this.dgvTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewDefaultCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDefaultCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDefaultCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewDefaultCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewDefaultCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewDefaultCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeachers.DefaultCellStyle = dataGridViewDefaultCellStyle2;
            this.dgvTeachers.EnableHeadersVisualStyles = false;
            this.dgvTeachers.Location = new System.Drawing.Point(125, 169);
            this.dgvTeachers.MultiSelect = false;
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.ReadOnly = true;
            this.dgvTeachers.RowHeadersVisible = false;
            this.dgvTeachers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTeachers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTeachers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTeachers.RowTemplate.Height = 30;
            this.dgvTeachers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(396, 196);
            this.dgvTeachers.TabIndex = 9;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Visible = false;
            // 
            // columnDni
            // 
            this.columnDni.HeaderText = "DNI";
            this.columnDni.Name = "columnDni";
            this.columnDni.ReadOnly = true;
            // 
            // columnFullName
            // 
            this.columnFullName.HeaderText = "NOMBRE ";
            this.columnFullName.Name = "columnFullName";
            this.columnFullName.ReadOnly = true;
            // 
            // LabelNewAssignedTeacher
            // 
            this.LabelNewAssignedTeacher.AutoSize = true;
            this.LabelNewAssignedTeacher.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelNewAssignedTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelNewAssignedTeacher.Location = new System.Drawing.Point(250, 127);
            this.LabelNewAssignedTeacher.Name = "LabelNewAssignedTeacher";
            this.LabelNewAssignedTeacher.Size = new System.Drawing.Size(0, 16);
            this.LabelNewAssignedTeacher.TabIndex = 10;
            // 
            // ButtonRemoveAssignment
            // 
            this.ButtonRemoveAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.ButtonRemoveAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveAssignment.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonRemoveAssignment.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoveAssignment.Location = new System.Drawing.Point(485, 371);
            this.ButtonRemoveAssignment.Name = "ButtonRemoveAssignment";
            this.ButtonRemoveAssignment.Size = new System.Drawing.Size(135, 25);
            this.ButtonRemoveAssignment.TabIndex = 11;
            this.ButtonRemoveAssignment.Text = "Retirar asignación";
            this.ButtonRemoveAssignment.UseVisualStyleBackColor = false;
            this.ButtonRemoveAssignment.Click += new System.EventHandler(this.ButtonRemoveAssignment_Click);
            // 
            // AssignTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(658, 441);
            this.Controls.Add(this.ButtonRemoveAssignment);
            this.Controls.Add(this.LabelNewAssignedTeacher);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.customCloseButton1);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.LabelCurrentTeacher);
            this.Controls.Add(this.LabelCurrentSubject);
            this.Controls.Add(this.LabelChangeTeacher);
            this.Controls.Add(this.LabelSubject);
            this.Controls.Add(this.LabelTeacher);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AssignTeacherForm";
            this.Load += new System.EventHandler(this.AssignTeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLabel LabelTeacher;
        private CustomLabel LabelSubject;
        private CustomLabel LabelChangeTeacher;
        private CustomLabel LabelCurrentSubject;
        private CustomLabel LabelCurrentTeacher;
        private CustomButton btnCancel;
        private CustomButton btnAssign;
        private CustomCloseButton customCloseButton1;
        private CustomDataGridView dgvTeachers;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFullName;
        private CustomLabel LabelNewAssignedTeacher;
        private CustomButton ButtonRemoveAssignment;
    }
}

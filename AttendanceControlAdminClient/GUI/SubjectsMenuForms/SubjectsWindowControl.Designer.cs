using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.GUI.Design.DataGridViewStyle;
using AttendanceControlAdminClient.Properties;

namespace AttendanceControlAdminClient.GUI.SubjectsMenuForms
{
    partial class SubjectsWindowControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectsWindowControl));
            this.tbSubject = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.dgvSubjects = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelFilter = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.buttonRemoveTeacher = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonAsignTeacher = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonModify = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonAdd = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbSubject.ForeColor = System.Drawing.Color.Black;
            this.tbSubject.Location = new System.Drawing.Point(213, 87);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(169, 20);
            this.tbSubject.TabIndex = 4;
            this.tbSubject.TextChanged += new System.EventHandler(this.TextBoxSubject_TextChanged);
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AllowUserToDeleteRows = false;
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
            this.id,
            this.subject,
            this.teacher});
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
            this.dgvSubjects.Location = new System.Drawing.Point(53, 125);
            this.dgvSubjects.MultiSelect = false;
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.ReadOnly = true;
            this.dgvSubjects.RowHeadersVisible = false;
            this.dgvSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSubjects.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSubjects.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSubjects.RowTemplate.Height = 30;
            this.dgvSubjects.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubjects.Size = new System.Drawing.Size(612, 250);
            this.dgvSubjects.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // subject
            // 
            this.subject.HeaderText = "Asignatura";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // teacher
            // 
            this.teacher.HeaderText = "Profesor asignado";
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelFilter.Location = new System.Drawing.Point(50, 88);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(147, 16);
            this.LabelFilter.TabIndex = 2;
            this.LabelFilter.Text = "Buscar por nombre:";
            // 
            // buttonRemoveTeacher
            // 
            this.buttonRemoveTeacher.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_retirar_asignacion;
            this.buttonRemoveTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveTeacher.FlatAppearance.BorderSize = 0;
            this.buttonRemoveTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveTeacher.Location = new System.Drawing.Point(701, 307);
            this.buttonRemoveTeacher.Name = "buttonRemoveTeacher";
            this.buttonRemoveTeacher.Size = new System.Drawing.Size(50, 50);
            this.buttonRemoveTeacher.TabIndex = 11;
            this.buttonRemoveTeacher.UseVisualStyleBackColor = true;
            this.buttonRemoveTeacher.Click += new System.EventHandler(this.buttonRemoveTeacher_Click);
            // 
            // buttonAsignTeacher
            // 
            this.buttonAsignTeacher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAsignTeacher.BackgroundImage")));
            this.buttonAsignTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAsignTeacher.FlatAppearance.BorderSize = 0;
            this.buttonAsignTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsignTeacher.Location = new System.Drawing.Point(701, 251);
            this.buttonAsignTeacher.Name = "buttonAsignTeacher";
            this.buttonAsignTeacher.Size = new System.Drawing.Size(50, 50);
            this.buttonAsignTeacher.TabIndex = 10;
            this.buttonAsignTeacher.UseVisualStyleBackColor = true;
            this.buttonAsignTeacher.Click += new System.EventHandler(this.BtnAssign_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_modificar;
            this.buttonModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModify.FlatAppearance.BorderSize = 0;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Location = new System.Drawing.Point(701, 195);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(50, 50);
            this.buttonModify.TabIndex = 9;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.BtnModifySubject_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_agregar;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(701, 139);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.BtnAddSubject_Click);
            // 
            // SubjectsWindowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemoveTeacher);
            this.Controls.Add(this.buttonAsignTeacher);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.dgvSubjects);
            this.Controls.Add(this.LabelFilter);
            this.Name = "SubjectsWindowControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.SubjectsWindowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomLabel LabelFilter;
        private CustomDataGridView dgvSubjects;
        private CustomTextBox tbSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacher;
        private CustomCircularButton buttonAdd;
        private CustomCircularButton buttonModify;
        private CustomCircularButton buttonAsignTeacher;
        private CustomCircularButton buttonRemoveTeacher;
    }
}

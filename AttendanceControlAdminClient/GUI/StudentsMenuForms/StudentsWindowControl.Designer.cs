using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.GUI.Design.DataGridViewStyle;

namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{
    partial class StudentsWindowControl
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
            this.buttonAbsences = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonAssignSubjects = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonAssignCycle = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonModifyStudent = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.buttonAddStudent = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.labelPage = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.buttonNext = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.buttonPrevious = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.tbLastName = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.LabelFilter = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.dgvStudents = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAbsences
            // 
            this.buttonAbsences.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_ausencias;
            this.buttonAbsences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAbsences.FlatAppearance.BorderSize = 0;
            this.buttonAbsences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbsences.Location = new System.Drawing.Point(725, 337);
            this.buttonAbsences.Name = "buttonAbsences";
            this.buttonAbsences.Size = new System.Drawing.Size(50, 50);
            this.buttonAbsences.TabIndex = 15;
            this.buttonAbsences.UseVisualStyleBackColor = true;
            this.buttonAbsences.Click += new System.EventHandler(this.ButtonAbsences_Click);
            // 
            // buttonAssignSubjects
            // 
            this.buttonAssignSubjects.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_asignar_asignaturas;
            this.buttonAssignSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAssignSubjects.FlatAppearance.BorderSize = 0;
            this.buttonAssignSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignSubjects.Location = new System.Drawing.Point(725, 281);
            this.buttonAssignSubjects.Name = "buttonAssignSubjects";
            this.buttonAssignSubjects.Size = new System.Drawing.Size(50, 50);
            this.buttonAssignSubjects.TabIndex = 14;
            this.buttonAssignSubjects.UseVisualStyleBackColor = true;
            this.buttonAssignSubjects.Click += new System.EventHandler(this.ButtonAssignSubjects_Click);
            // 
            // buttonAssignCycle
            // 
            this.buttonAssignCycle.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_asignar_formacion;
            this.buttonAssignCycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAssignCycle.FlatAppearance.BorderSize = 0;
            this.buttonAssignCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignCycle.Location = new System.Drawing.Point(725, 225);
            this.buttonAssignCycle.Name = "buttonAssignCycle";
            this.buttonAssignCycle.Size = new System.Drawing.Size(50, 50);
            this.buttonAssignCycle.TabIndex = 13;
            this.buttonAssignCycle.UseVisualStyleBackColor = true;
            this.buttonAssignCycle.Click += new System.EventHandler(this.ButtonAssignCourse_Click);
            // 
            // buttonModifyStudent
            // 
            this.buttonModifyStudent.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_modificar;
            this.buttonModifyStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModifyStudent.FlatAppearance.BorderSize = 0;
            this.buttonModifyStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyStudent.Location = new System.Drawing.Point(725, 169);
            this.buttonModifyStudent.Name = "buttonModifyStudent";
            this.buttonModifyStudent.Size = new System.Drawing.Size(50, 50);
            this.buttonModifyStudent.TabIndex = 12;
            this.buttonModifyStudent.UseVisualStyleBackColor = true;
            this.buttonModifyStudent.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_agregar;
            this.buttonAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddStudent.FlatAppearance.BorderSize = 0;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.Location = new System.Drawing.Point(725, 113);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(50, 50);
            this.buttonAddStudent.TabIndex = 11;
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.labelPage.Location = new System.Drawing.Point(346, 403);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(67, 16);
            this.labelPage.TabIndex = 9;
            this.labelPage.Text = "Página 1";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(642, 401);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(60, 23);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.buttonPrevious.ForeColor = System.Drawing.Color.White;
            this.buttonPrevious.Location = new System.Drawing.Point(53, 401);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(60, 23);
            this.buttonPrevious.TabIndex = 7;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.ButtonPrevious_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbLastName.ForeColor = System.Drawing.Color.Black;
            this.tbLastName.Location = new System.Drawing.Point(220, 61);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(175, 20);
            this.tbLastName.TabIndex = 5;
            this.tbLastName.TextChanged += new System.EventHandler(this.TextBoxDni_TextChanged);
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelFilter.Location = new System.Drawing.Point(50, 62);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(149, 16);
            this.LabelFilter.TabIndex = 4;
            this.LabelFilter.Text = "Buscar por Apellido:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            dataGridViewAlternatingRowsStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewAlternatingRowsStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewAlternatingRowsStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewAlternatingRowsStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewAlternatingRowsStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStudents.AlternatingRowsDefaultCellStyle = dataGridViewAlternatingRowsStyle1;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewHeaderStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewHeaderStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            dataGridViewHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle1;
            this.dgvStudents.ColumnHeadersHeight = 40;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnDni,
            this.columnFirstName,
            this.columnCycle,
            this.columnCourse});
            this.dgvStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewDefaultCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDefaultCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDefaultCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewDefaultCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewDefaultCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewDefaultCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewDefaultCellStyle1;
            this.dgvStudents.EnableHeadersVisualStyles = false;
            this.dgvStudents.Location = new System.Drawing.Point(50, 100);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStudents.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudents.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStudents.RowTemplate.Height = 30;
            this.dgvStudents.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(661, 287);
            this.dgvStudents.TabIndex = 0;
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
            this.columnDni.HeaderText = "Dni";
            this.columnDni.Name = "columnDni";
            this.columnDni.ReadOnly = true;
            // 
            // columnFirstName
            // 
            this.columnFirstName.HeaderText = "Nombre";
            this.columnFirstName.Name = "columnFirstName";
            this.columnFirstName.ReadOnly = true;
            // 
            // columnCycle
            // 
            this.columnCycle.HeaderText = "Ciclo Formativo";
            this.columnCycle.Name = "columnCycle";
            this.columnCycle.ReadOnly = true;
            // 
            // columnCourse
            // 
            this.columnCourse.HeaderText = "Curso";
            this.columnCourse.Name = "columnCourse";
            this.columnCourse.ReadOnly = true;
            // 
            // StudentsWindowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAbsences);
            this.Controls.Add(this.buttonAssignSubjects);
            this.Controls.Add(this.buttonAssignCycle);
            this.Controls.Add(this.buttonModifyStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.labelPage);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.LabelFilter);
            this.Controls.Add(this.dgvStudents);
            this.Name = "StudentsWindowControl";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.StudentsWindowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dgvStudents;
        private CustomLabel LabelFilter;
        private CustomTextBox tbLastName;
        private CustomButton buttonNext;
        private CustomLabel labelPage;
        public CustomButton buttonPrevious;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCourse;
        private CustomCircularButton buttonAddStudent;
        private CustomCircularButton buttonModifyStudent;
        private CustomCircularButton buttonAssignCycle;
        private CustomCircularButton buttonAssignSubjects;
        private CustomCircularButton buttonAbsences;
    }
}

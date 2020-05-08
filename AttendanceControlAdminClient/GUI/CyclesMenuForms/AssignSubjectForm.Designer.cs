using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.GUI.Design.DataGridViewStyle;

namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    partial class AssignSubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignSubjectForm));
            this.LabelFilter = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.tbSubject = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.dgvSubjects = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSubjects = new System.Windows.Forms.GroupBox();
            this.buttonAsign = new AttendanceControlAdminClient.GUI.CustomControls.CustomCircularButton();
            this.customCloseButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.groupBoxSubjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelFilter.Location = new System.Drawing.Point(18, 77);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(147, 16);
            this.LabelFilter.TabIndex = 0;
            this.LabelFilter.Text = "Buscar por nombre:";
            // 
            // tbSubject
            // 
            this.tbSubject.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbSubject.ForeColor = System.Drawing.Color.Black;
            this.tbSubject.Location = new System.Drawing.Point(182, 76);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(185, 20);
            this.tbSubject.TabIndex = 1;
            this.tbSubject.TextChanged += new System.EventHandler(this.tbSubject_TextChanged);
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
            dataGridViewHeaderStyle1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle1;
            this.dgvSubjects.ColumnHeadersHeight = 40;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnName});
            this.dgvSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewDefaultCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDefaultCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDefaultCellStyle1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewDefaultCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewDefaultCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewDefaultCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSubjects.DefaultCellStyle = dataGridViewDefaultCellStyle1;
            this.dgvSubjects.EnableHeadersVisualStyles = false;
            this.dgvSubjects.Location = new System.Drawing.Point(21, 111);
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
            this.dgvSubjects.Size = new System.Drawing.Size(370, 262);
            this.dgvSubjects.TabIndex = 2;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "Id";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Visible = false;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "Asignaturas";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            // 
            // groupBoxSubjects
            // 
            this.groupBoxSubjects.BackColor = System.Drawing.Color.White;
            this.groupBoxSubjects.Controls.Add(this.buttonAsign);
            this.groupBoxSubjects.Controls.Add(this.LabelFilter);
            this.groupBoxSubjects.Controls.Add(this.tbSubject);
            this.groupBoxSubjects.Controls.Add(this.dgvSubjects);
            this.groupBoxSubjects.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSubjects.Location = new System.Drawing.Point(23, 22);
            this.groupBoxSubjects.Name = "groupBoxSubjects";
            this.groupBoxSubjects.Size = new System.Drawing.Size(467, 399);
            this.groupBoxSubjects.TabIndex = 9;
            this.groupBoxSubjects.TabStop = false;
            this.groupBoxSubjects.Text = "Asignaturas";
            // 
            // buttonAsign
            // 
            this.buttonAsign.BackgroundImage = global::AttendanceControlAdminClient.Properties.Resources.icono_agregar;
            this.buttonAsign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAsign.FlatAppearance.BorderSize = 0;
            this.buttonAsign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsign.Location = new System.Drawing.Point(405, 129);
            this.buttonAsign.Name = "buttonAsign";
            this.buttonAsign.Size = new System.Drawing.Size(50, 50);
            this.buttonAsign.TabIndex = 3;
            this.buttonAsign.UseVisualStyleBackColor = true;
            this.buttonAsign.Click += new System.EventHandler(this.ButtonAssign_Click);
            // 
            // customCloseButton1
            // 
            this.customCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("customCloseButton1.Image")));
            this.customCloseButton1.Location = new System.Drawing.Point(505, 22);
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.Size = new System.Drawing.Size(30, 30);
            this.customCloseButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customCloseButton1.TabIndex = 10;
            this.customCloseButton1.TabStop = false;
            // 
            // AssignSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(556, 445);
            this.Controls.Add(this.customCloseButton1);
            this.Controls.Add(this.groupBoxSubjects);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AssignSubjectForm";
            this.Load += new System.EventHandler(this.AssignNewSubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.groupBoxSubjects.ResumeLayout(false);
            this.groupBoxSubjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomLabel LabelFilter;
        private CustomTextBox tbSubject;
        private CustomDataGridView dgvSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.GroupBox groupBoxSubjects;
        private CustomCloseButton customCloseButton1;
        private CustomCircularButton buttonAsign;
    }
}

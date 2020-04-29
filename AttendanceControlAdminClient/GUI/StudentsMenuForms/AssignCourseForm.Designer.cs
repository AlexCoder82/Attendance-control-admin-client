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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelNewCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.dgvCourses = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.columnIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label4 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelDni = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.Label1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelCurrentCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.Label3 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelFullName = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.Label2 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.btnAssign = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.ButtonRemoveAssignedCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.customCloseButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelNewCourse);
            this.groupBox1.Controls.Add(this.dgvCourses);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.LabelDni);
            this.groupBox1.Controls.Add(this.Label1);
            this.groupBox1.Controls.Add(this.LabelCurrentCourse);
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.LabelFullName);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = global::AttendanceControlAdminClient.Properties.Settings.Default.OPTIMA_COLOR;
            this.groupBox1.Location = new System.Drawing.Point(36, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curso";
            // 
            // LabelNewCourse
            // 
            this.LabelNewCourse.AutoSize = true;
            this.LabelNewCourse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelNewCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelNewCourse.Location = new System.Drawing.Point(138, 160);
            this.LabelNewCourse.Name = "LabelNewCourse";
            this.LabelNewCourse.Size = new System.Drawing.Size(0, 16);
            this.LabelNewCourse.TabIndex = 12;
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
            dataGridViewHeaderStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle1;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIds,
            this.columnCourse,
            this.columnCycle});
            this.dgvCourses.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewDefaultCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDefaultCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDefaultCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewDefaultCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewDefaultCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourses.DefaultCellStyle = dataGridViewDefaultCellStyle1;
            this.dgvCourses.EnableHeadersVisualStyles = false;
            this.dgvCourses.Location = new System.Drawing.Point(28, 200);
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
            this.dgvCourses.Size = new System.Drawing.Size(485, 177);
            this.dgvCourses.TabIndex = 11;
            // 
            // columnIds
            // 
            this.columnIds.HeaderText = "ID";
            this.columnIds.Name = "columnIds";
            this.columnIds.ReadOnly = true;
            this.columnIds.Visible = false;
            // 
            // columnCourse
            // 
            this.columnCourse.HeaderText = "Curso";
            this.columnCourse.Name = "columnCourse";
            this.columnCourse.ReadOnly = true;
            // 
            // columnCycle
            // 
            this.columnCycle.HeaderText = "CICLO";
            this.columnCycle.Name = "columnCycle";
            this.columnCycle.ReadOnly = true;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label4.Location = new System.Drawing.Point(25, 160);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(109, 16);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Asignar curso:";
            // 
            // LabelDni
            // 
            this.LabelDni.AutoSize = true;
            this.LabelDni.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelDni.ForeColor = System.Drawing.Color.Black;
            this.LabelDni.Location = new System.Drawing.Point(138, 40);
            this.LabelDni.Name = "LabelDni";
            this.LabelDni.Size = new System.Drawing.Size(0, 16);
            this.LabelDni.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label1.Location = new System.Drawing.Point(25, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 16);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Dni:";
            // 
            // LabelCurrentCourse
            // 
            this.LabelCurrentCourse.AutoSize = true;
            this.LabelCurrentCourse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelCurrentCourse.ForeColor = System.Drawing.Color.Black;
            this.LabelCurrentCourse.Location = new System.Drawing.Point(138, 120);
            this.LabelCurrentCourse.Name = "LabelCurrentCourse";
            this.LabelCurrentCourse.Size = new System.Drawing.Size(0, 16);
            this.LabelCurrentCourse.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label3.Location = new System.Drawing.Point(25, 120);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Curso actual:";
            // 
            // LabelFullName
            // 
            this.LabelFullName.AutoSize = true;
            this.LabelFullName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelFullName.ForeColor = System.Drawing.Color.Black;
            this.LabelFullName.Location = new System.Drawing.Point(138, 80);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(0, 16);
            this.LabelFullName.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label2.Location = new System.Drawing.Point(25, 80);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Alumno:";
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Location = new System.Drawing.Point(595, 347);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 2;
            this.btnAssign.Text = "Asignar";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.ButtonAssign_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(595, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // ButtonRemoveAssignedCourse
            // 
            this.ButtonRemoveAssignedCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.ButtonRemoveAssignedCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveAssignedCourse.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonRemoveAssignedCourse.ForeColor = System.Drawing.Color.White;
            this.ButtonRemoveAssignedCourse.Location = new System.Drawing.Point(544, 405);
            this.ButtonRemoveAssignedCourse.Name = "ButtonRemoveAssignedCourse";
            this.ButtonRemoveAssignedCourse.Size = new System.Drawing.Size(126, 23);
            this.ButtonRemoveAssignedCourse.TabIndex = 4;
            this.ButtonRemoveAssignedCourse.Text = "Retirar asignación";
            this.ButtonRemoveAssignedCourse.UseVisualStyleBackColor = false;
            this.ButtonRemoveAssignedCourse.Click += new System.EventHandler(this.ButtonRemoveAssignedCourse_Click);
            // 
            // customCloseButton1
            // 
            this.customCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("customCloseButton1.Image")));
            this.customCloseButton1.Location = new System.Drawing.Point(640, 26);
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.Size = new System.Drawing.Size(30, 30);
            this.customCloseButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customCloseButton1.TabIndex = 5;
            this.customCloseButton1.TabStop = false;
            // 
            // AssignCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 465);
            this.Controls.Add(this.customCloseButton1);
            this.Controls.Add(this.ButtonRemoveAssignedCourse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AssignCourseForm";
            this.Text = "AssignNewCycleForm";
            this.Load += new System.EventHandler(this.AssignNewCycleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CustomLabel LabelFullName;
        private CustomLabel Label2;
        private CustomLabel Label4;
        private CustomLabel LabelCurrentCourse;
        private CustomLabel Label3;
        private CustomLabel LabelDni;
        private CustomLabel Label1;
        private CustomButton btnAssign;
        private CustomButton btnCancel;
        private CustomDataGridView dgvCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIds;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCycle;
        private CustomLabel LabelNewCourse;
        private CustomButton ButtonRemoveAssignedCourse;
        private CustomCloseButton customCloseButton1;
    }
}
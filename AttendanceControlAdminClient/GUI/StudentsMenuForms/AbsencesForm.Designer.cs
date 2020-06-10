namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{
    partial class AbsencesForm
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
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle dataGridViewAlternatingRowsStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewAlternatingRowsStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle dataGridViewHeaderStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewHeaderStyle();
            AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle dataGridViewDefaultCellStyle2 = new AttendanceControlAdminClient.GUI.Design.DataGridViewStyle.DataGridViewDefaultCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbsencesForm));
            this.dgvAbsences = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.columnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MissedClasses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetails = new AttendanceControlAdminClient.GUI.CustomControls.CustomDataGridView();
            this.columDelayIds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelaySchedules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDelaySubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbsenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIsExcused = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customLabel3 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.customLabel4 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.customLabel5 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.customCloseButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            this.labelStudent = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.labelTotalClasses = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.labelTotalExcused = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.labelTotalDelays = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.customLabel1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.labelExcusedDelays = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.customLabel6 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.labelCourse = new System.Windows.Forms.Label();
            this.customLabel2 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.AllowUserToAddRows = false;
            this.dgvAbsences.AllowUserToDeleteRows = false;
            dataGridViewAlternatingRowsStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewAlternatingRowsStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewAlternatingRowsStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewAlternatingRowsStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewAlternatingRowsStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAbsences.AlternatingRowsDefaultCellStyle = dataGridViewAlternatingRowsStyle1;
            this.dgvAbsences.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbsences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAbsences.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAbsences.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewHeaderStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewHeaderStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewHeaderStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAbsences.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle1;
            this.dgvAbsences.ColumnHeadersHeight = 40;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAbsences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDate,
            this.MissedClasses,
            this.Delays});
            this.dgvAbsences.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewDefaultCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDefaultCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDefaultCellStyle1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewDefaultCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewDefaultCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewDefaultCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbsences.DefaultCellStyle = dataGridViewDefaultCellStyle1;
            this.dgvAbsences.EnableHeadersVisualStyles = false;
            this.dgvAbsences.Location = new System.Drawing.Point(23, 31);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersVisible = false;
            this.dgvAbsences.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAbsences.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAbsences.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAbsences.RowTemplate.Height = 30;
            this.dgvAbsences.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(543, 150);
            this.dgvAbsences.TabIndex = 0;
            this.dgvAbsences.SelectionChanged += new System.EventHandler(this.DgvAbsences_SelectionChanged);
            // 
            // columnDate
            // 
            this.columnDate.HeaderText = "Fecha";
            this.columnDate.Name = "columnDate";
            this.columnDate.ReadOnly = true;
            // 
            // MissedClasses
            // 
            this.MissedClasses.HeaderText = "Clases Perdidas";
            this.MissedClasses.Name = "MissedClasses";
            this.MissedClasses.ReadOnly = true;
            // 
            // Delays
            // 
            this.Delays.HeaderText = "Retrasos";
            this.Delays.Name = "Delays";
            this.Delays.ReadOnly = true;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            dataGridViewAlternatingRowsStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewAlternatingRowsStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewAlternatingRowsStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewAlternatingRowsStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewAlternatingRowsStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewAlternatingRowsStyle2;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewHeaderStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewHeaderStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewHeaderStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewHeaderStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewHeaderStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewHeaderStyle2;
            this.dgvDetails.ColumnHeadersHeight = 40;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columDelayIds,
            this.ColumnDelaySchedules,
            this.columnDelaySubject,
            this.AbsenceType,
            this.columnIsExcused});
            this.dgvDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewDefaultCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewDefaultCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewDefaultCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewDefaultCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewDefaultCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            dataGridViewDefaultCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewDefaultCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.DefaultCellStyle = dataGridViewDefaultCellStyle2;
            this.dgvDetails.EnableHeadersVisualStyles = false;
            this.dgvDetails.Location = new System.Drawing.Point(23, 204);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetails.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetails.RowTemplate.Height = 30;
            this.dgvDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(543, 237);
            this.dgvDetails.TabIndex = 3;
            this.dgvDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelays_CellContentClick);
            // 
            // columDelayIds
            // 
            this.columDelayIds.HeaderText = "Id";
            this.columDelayIds.Name = "columDelayIds";
            this.columDelayIds.ReadOnly = true;
            this.columDelayIds.Visible = false;
            // 
            // ColumnDelaySchedules
            // 
            this.ColumnDelaySchedules.HeaderText = "Horario";
            this.ColumnDelaySchedules.Name = "ColumnDelaySchedules";
            this.ColumnDelaySchedules.ReadOnly = true;
            // 
            // columnDelaySubject
            // 
            this.columnDelaySubject.HeaderText = "Asignatura";
            this.columnDelaySubject.Name = "columnDelaySubject";
            this.columnDelaySubject.ReadOnly = true;
            // 
            // AbsenceType
            // 
            this.AbsenceType.HeaderText = "Tipo";
            this.AbsenceType.Name = "AbsenceType";
            this.AbsenceType.ReadOnly = true;
            // 
            // columnIsExcused
            // 
            this.columnIsExcused.HeaderText = "Justificar";
            this.columnIsExcused.Name = "columnIsExcused";
            this.columnIsExcused.ReadOnly = true;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.customLabel3.Location = new System.Drawing.Point(20, 40);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(64, 16);
            this.customLabel3.TabIndex = 5;
            this.customLabel3.Text = "Alumno:";
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.customLabel4.Location = new System.Drawing.Point(20, 80);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(125, 16);
            this.customLabel4.TabIndex = 6;
            this.customLabel4.Text = "Clases perdidas:";
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.customLabel5.Location = new System.Drawing.Point(220, 80);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(75, 16);
            this.customLabel5.TabIndex = 7;
            this.customLabel5.Text = "Retrasos:";
            // 
            // customCloseButton1
            // 
            this.customCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("customCloseButton1.Image")));
            this.customCloseButton1.Location = new System.Drawing.Point(637, 25);
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.Size = new System.Drawing.Size(30, 30);
            this.customCloseButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customCloseButton1.TabIndex = 9;
            this.customCloseButton1.TabStop = false;
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelStudent.ForeColor = System.Drawing.Color.Black;
            this.labelStudent.Location = new System.Drawing.Point(160, 40);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(0, 16);
            this.labelStudent.TabIndex = 10;
            // 
            // labelTotalClasses
            // 
            this.labelTotalClasses.AutoSize = true;
            this.labelTotalClasses.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelTotalClasses.ForeColor = System.Drawing.Color.Black;
            this.labelTotalClasses.Location = new System.Drawing.Point(160, 80);
            this.labelTotalClasses.Name = "labelTotalClasses";
            this.labelTotalClasses.Size = new System.Drawing.Size(0, 16);
            this.labelTotalClasses.TabIndex = 11;
            // 
            // labelTotalExcused
            // 
            this.labelTotalExcused.AutoSize = true;
            this.labelTotalExcused.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelTotalExcused.ForeColor = System.Drawing.Color.Black;
            this.labelTotalExcused.Location = new System.Drawing.Point(160, 100);
            this.labelTotalExcused.Name = "labelTotalExcused";
            this.labelTotalExcused.Size = new System.Drawing.Size(0, 16);
            this.labelTotalExcused.TabIndex = 12;
            // 
            // labelTotalDelays
            // 
            this.labelTotalDelays.AutoSize = true;
            this.labelTotalDelays.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelTotalDelays.ForeColor = System.Drawing.Color.Black;
            this.labelTotalDelays.Location = new System.Drawing.Point(320, 80);
            this.labelTotalDelays.Name = "labelTotalDelays";
            this.labelTotalDelays.Size = new System.Drawing.Size(0, 16);
            this.labelTotalDelays.TabIndex = 13;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.customLabel1.Location = new System.Drawing.Point(20, 100);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(96, 16);
            this.customLabel1.TabIndex = 14;
            this.customLabel1.Text = "Justificadas:";
            // 
            // labelExcusedDelays
            // 
            this.labelExcusedDelays.AutoSize = true;
            this.labelExcusedDelays.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelExcusedDelays.ForeColor = System.Drawing.Color.Black;
            this.labelExcusedDelays.Location = new System.Drawing.Point(427, 320);
            this.labelExcusedDelays.Name = "labelExcusedDelays";
            this.labelExcusedDelays.Size = new System.Drawing.Size(0, 16);
            this.labelExcusedDelays.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.customLabel6);
            this.groupBox1.Controls.Add(this.labelCourse);
            this.groupBox1.Controls.Add(this.customLabel2);
            this.groupBox1.Controls.Add(this.customLabel3);
            this.groupBox1.Controls.Add(this.customLabel4);
            this.groupBox1.Controls.Add(this.labelTotalDelays);
            this.groupBox1.Controls.Add(this.customLabel1);
            this.groupBox1.Controls.Add(this.labelTotalExcused);
            this.groupBox1.Controls.Add(this.customLabel5);
            this.groupBox1.Controls.Add(this.labelStudent);
            this.groupBox1.Controls.Add(this.labelTotalClasses);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(33, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 157);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del alumno";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(429, 80);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 18);
            this.labelTotal.TabIndex = 18;
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.customLabel6.Location = new System.Drawing.Point(361, 80);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(45, 16);
            this.customLabel6.TabIndex = 17;
            this.customLabel6.Text = "Total:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(160, 60);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(0, 16);
            this.labelCourse.TabIndex = 16;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.customLabel2.Location = new System.Drawing.Point(20, 60);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(54, 16);
            this.customLabel2.TabIndex = 15;
            this.customLabel2.Text = "Curso:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAbsences);
            this.groupBox2.Controls.Add(this.dgvDetails);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 447);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles ausencias";
            // 
            // AbsencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 665);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelExcusedDelays);
            this.Controls.Add(this.customCloseButton1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AbsencesForm";
            this.Text = "AbsencesForm";
            this.Load += new System.EventHandler(this.AbsencesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomDataGridView dgvAbsences;
        private CustomControls.CustomDataGridView dgvDetails;
        private CustomControls.CustomLabel customLabel3;
        private CustomControls.CustomLabel customLabel4;
        private CustomControls.CustomLabel customLabel5;
        private CustomControls.CustomCloseButton customCloseButton1;
        private CustomControls.CustomLabel labelStudent;
        private CustomControls.CustomLabel labelTotalClasses;
        private CustomControls.CustomLabel labelTotalExcused;
        private CustomControls.CustomLabel labelTotalDelays;
        private CustomControls.CustomLabel customLabel1;
        private CustomControls.CustomLabel labelExcusedDelays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCourse;
        private CustomControls.CustomLabel customLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDelayIds;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDelaySchedules;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDelaySubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbsenceType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnIsExcused;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissedClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delays;
        private System.Windows.Forms.Label labelTotal;
        private CustomControls.CustomLabel customLabel6;
    }
}
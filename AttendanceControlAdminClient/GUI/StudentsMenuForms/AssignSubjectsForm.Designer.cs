using AttendanceControlAdminClient.GUI.CustomControls;

namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{ 
    partial class AssignSubjectsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignSubjectsForm));
            this.Label4 = new System.Windows.Forms.GroupBox();
            this.clbSubjects = new System.Windows.Forms.CheckedListBox();
            this.customLabel1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelDni = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.Label1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelCurrentCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.Label3 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelFullName = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.Label2 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.btnSave = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.customCloseButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            this.Label4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.Controls.Add(this.clbSubjects);
            this.Label4.Controls.Add(this.customLabel1);
            this.Label4.Controls.Add(this.LabelDni);
            this.Label4.Controls.Add(this.Label1);
            this.Label4.Controls.Add(this.LabelCurrentCourse);
            this.Label4.Controls.Add(this.Label3);
            this.Label4.Controls.Add(this.LabelFullName);
            this.Label4.Controls.Add(this.Label2);
            this.Label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = global::AttendanceControlAdminClient.Properties.Settings.Default.OPTIMA_COLOR;
            this.Label4.Location = new System.Drawing.Point(36, 44);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(542, 408);
            this.Label4.TabIndex = 0;
            this.Label4.TabStop = false;
            this.Label4.Text = "Asignaturas";
            // 
            // clbSubjects
            // 
            this.clbSubjects.BackColor = System.Drawing.Color.White;
            this.clbSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbSubjects.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSubjects.FormattingEnabled = true;
            this.clbSubjects.Location = new System.Drawing.Point(141, 200);
            this.clbSubjects.Name = "clbSubjects";
            this.clbSubjects.Size = new System.Drawing.Size(319, 180);
            this.clbSubjects.TabIndex = 8;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.customLabel1.Location = new System.Drawing.Point(25, 170);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(159, 16);
            this.customLabel1.TabIndex = 7;
            this.customLabel1.Text = "Asignaturas cursadas";
            // 
            // LabelDni
            // 
            this.LabelDni.AutoSize = true;
            this.LabelDni.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelDni.ForeColor = System.Drawing.Color.Black;
            this.LabelDni.Location = new System.Drawing.Point(138, 50);
            this.LabelDni.Name = "LabelDni";
            this.LabelDni.Size = new System.Drawing.Size(0, 16);
            this.LabelDni.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label1.Location = new System.Drawing.Point(25, 50);
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
            this.LabelCurrentCourse.Location = new System.Drawing.Point(138, 130);
            this.LabelCurrentCourse.Name = "LabelCurrentCourse";
            this.LabelCurrentCourse.Size = new System.Drawing.Size(0, 16);
            this.LabelCurrentCourse.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label3.Location = new System.Drawing.Point(25, 130);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Curso:";
            // 
            // LabelFullName
            // 
            this.LabelFullName.AutoSize = true;
            this.LabelFullName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelFullName.ForeColor = System.Drawing.Color.Black;
            this.LabelFullName.Location = new System.Drawing.Point(138, 90);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(0, 16);
            this.LabelFullName.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label2.Location = new System.Drawing.Point(25, 90);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Alumno:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(595, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(595, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // customCloseButton1
            // 
            this.customCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("customCloseButton1.Image")));
            this.customCloseButton1.Location = new System.Drawing.Point(640, 23);
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.Size = new System.Drawing.Size(30, 30);
            this.customCloseButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customCloseButton1.TabIndex = 4;
            this.customCloseButton1.TabStop = false;
            // 
            // AssignSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 496);
            this.Controls.Add(this.customCloseButton1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Label4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AssignSubjectsForm";
            this.Text = "AssignNewCycleForm";
            this.Load += new System.EventHandler(this.AssignStudentSubjectsForm_Load);
            this.Label4.ResumeLayout(false);
            this.Label4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Label4;
        private CustomLabel LabelFullName;
        private CustomLabel Label2;
        private CustomLabel LabelCurrentCourse;
        private CustomLabel Label3;
        private CustomLabel LabelDni;
        private CustomLabel Label1;
        private CustomButton btnSave;
        private CustomButton btnCancel;
        private CustomLabel customLabel1;
        private System.Windows.Forms.CheckedListBox clbSubjects;
        private CustomCloseButton customCloseButton1;
    }
}
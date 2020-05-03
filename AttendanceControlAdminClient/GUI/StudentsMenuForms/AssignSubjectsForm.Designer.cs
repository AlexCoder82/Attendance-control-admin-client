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
            this.Label4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.clbSubjects = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.LabelDni = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.Label1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelCurrentCourse = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.Label3 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelFullName = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.Label2 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.Label4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.Controls.Add(this.btnCancel);
            this.Label4.Controls.Add(this.clbSubjects);
            this.Label4.Controls.Add(this.btnSave);
            this.Label4.Controls.Add(this.LabelDni);
            this.Label4.Controls.Add(this.Label1);
            this.Label4.Controls.Add(this.LabelCurrentCourse);
            this.Label4.Controls.Add(this.Label3);
            this.Label4.Controls.Add(this.LabelFullName);
            this.Label4.Controls.Add(this.Label2);
            this.Label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(23, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(542, 429);
            this.Label4.TabIndex = 0;
            this.Label4.TabStop = false;
            this.Label4.Text = "Asignaturas";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(181, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // clbSubjects
            // 
            this.clbSubjects.BackColor = System.Drawing.Color.White;
            this.clbSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbSubjects.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbSubjects.FormattingEnabled = true;
            this.clbSubjects.Location = new System.Drawing.Point(28, 175);
            this.clbSubjects.Name = "clbSubjects";
            this.clbSubjects.Size = new System.Drawing.Size(485, 180);
            this.clbSubjects.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(299, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LabelDni
            // 
            this.LabelDni.AutoSize = true;
            this.LabelDni.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelDni.ForeColor = System.Drawing.Color.Black;
            this.LabelDni.Location = new System.Drawing.Point(115, 50);
            this.LabelDni.Name = "LabelDni";
            this.LabelDni.Size = new System.Drawing.Size(0, 16);
            this.LabelDni.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label1.Location = new System.Drawing.Point(25, 50);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Dni:";
            // 
            // LabelCurrentCourse
            // 
            this.LabelCurrentCourse.AutoSize = true;
            this.LabelCurrentCourse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelCurrentCourse.ForeColor = System.Drawing.Color.Black;
            this.LabelCurrentCourse.Location = new System.Drawing.Point(115, 130);
            this.LabelCurrentCourse.Name = "LabelCurrentCourse";
            this.LabelCurrentCourse.Size = new System.Drawing.Size(0, 16);
            this.LabelCurrentCourse.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label3.Location = new System.Drawing.Point(25, 130);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 16);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Curso:";
            // 
            // LabelFullName
            // 
            this.LabelFullName.AutoSize = true;
            this.LabelFullName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelFullName.ForeColor = System.Drawing.Color.Black;
            this.LabelFullName.Location = new System.Drawing.Point(115, 90);
            this.LabelFullName.Name = "LabelFullName";
            this.LabelFullName.Size = new System.Drawing.Size(0, 16);
            this.LabelFullName.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.Label2.Location = new System.Drawing.Point(25, 90);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Alumno:";
            // 
            // AssignSubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 477);
            this.Controls.Add(this.Label4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AssignSubjectsForm";
            this.Text = "AssignNewCycleForm";
            this.Load += new System.EventHandler(this.AssignStudentSubjectsForm_Load);
            this.Label4.ResumeLayout(false);
            this.Label4.PerformLayout();
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
        private System.Windows.Forms.CheckedListBox clbSubjects;
    }
}
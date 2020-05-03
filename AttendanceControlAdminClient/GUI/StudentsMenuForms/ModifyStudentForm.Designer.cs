using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.Properties;
using System.Drawing;

namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{
    partial class ModifyStudentForm
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
            this.btnUpdateStudent = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.LabelDni = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.lblLastNameAsterisk = new System.Windows.Forms.Label();
            this.lblFirstNameAsterisk = new System.Windows.Forms.Label();
            this.lblDniAsterisk = new System.Windows.Forms.Label();
            this.tbLastName2 = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.tbLastName1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.tbFirstName = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.tbDni = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.LabelLastName2 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelLastName1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelFirstName = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStudent.Location = new System.Drawing.Point(280, 237);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(75, 25);
            this.btnUpdateStudent.TabIndex = 0;
            this.btnUpdateStudent.Text = "Guardar";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.ButtonCreateTeacher_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(112, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // LabelDni
            // 
            this.LabelDni.AutoSize = true;
            this.LabelDni.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelDni.Location = new System.Drawing.Point(38, 50);
            this.LabelDni.Name = "LabelDni";
            this.LabelDni.Size = new System.Drawing.Size(35, 16);
            this.LabelDni.TabIndex = 5;
            this.LabelDni.Text = "Dni:";
            // 
            // lblLastNameAsterisk
            // 
            this.lblLastNameAsterisk.AutoSize = true;
            this.lblLastNameAsterisk.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblLastNameAsterisk.ForeColor = System.Drawing.Color.Black;
            this.lblLastNameAsterisk.Location = new System.Drawing.Point(403, 130);
            this.lblLastNameAsterisk.Name = "lblLastNameAsterisk";
            this.lblLastNameAsterisk.Size = new System.Drawing.Size(17, 22);
            this.lblLastNameAsterisk.TabIndex = 15;
            this.lblLastNameAsterisk.Text = "*";
            // 
            // lblFirstNameAsterisk
            // 
            this.lblFirstNameAsterisk.AutoSize = true;
            this.lblFirstNameAsterisk.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblFirstNameAsterisk.ForeColor = System.Drawing.Color.Black;
            this.lblFirstNameAsterisk.Location = new System.Drawing.Point(403, 89);
            this.lblFirstNameAsterisk.Name = "lblFirstNameAsterisk";
            this.lblFirstNameAsterisk.Size = new System.Drawing.Size(17, 22);
            this.lblFirstNameAsterisk.TabIndex = 14;
            this.lblFirstNameAsterisk.Text = "*";
            // 
            // lblDniAsterisk
            // 
            this.lblDniAsterisk.AutoSize = true;
            this.lblDniAsterisk.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblDniAsterisk.ForeColor = System.Drawing.Color.Black;
            this.lblDniAsterisk.Location = new System.Drawing.Point(292, 50);
            this.lblDniAsterisk.Name = "lblDniAsterisk";
            this.lblDniAsterisk.Size = new System.Drawing.Size(17, 22);
            this.lblDniAsterisk.TabIndex = 13;
            this.lblDniAsterisk.Text = "*";
            // 
            // tbLastName2
            // 
            this.tbLastName2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbLastName2.ForeColor = System.Drawing.Color.Black;
            this.tbLastName2.Location = new System.Drawing.Point(189, 169);
            this.tbLastName2.Name = "tbLastName2";
            this.tbLastName2.Size = new System.Drawing.Size(208, 20);
            this.tbLastName2.TabIndex = 12;
            // 
            // tbLastName1
            // 
            this.tbLastName1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbLastName1.ForeColor = System.Drawing.Color.Black;
            this.tbLastName1.Location = new System.Drawing.Point(189, 129);
            this.tbLastName1.Name = "tbLastName1";
            this.tbLastName1.Size = new System.Drawing.Size(208, 20);
            this.tbLastName1.TabIndex = 11;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.Location = new System.Drawing.Point(189, 89);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(208, 20);
            this.tbFirstName.TabIndex = 10;
            // 
            // tbDni
            // 
            this.tbDni.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbDni.ForeColor = System.Drawing.Color.Black;
            this.tbDni.Location = new System.Drawing.Point(189, 49);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(97, 20);
            this.tbDni.TabIndex = 9;
            // 
            // LabelLastName2
            // 
            this.LabelLastName2.AutoSize = true;
            this.LabelLastName2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelLastName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelLastName2.Location = new System.Drawing.Point(38, 170);
            this.LabelLastName2.Name = "LabelLastName2";
            this.LabelLastName2.Size = new System.Drawing.Size(135, 16);
            this.LabelLastName2.TabIndex = 8;
            this.LabelLastName2.Text = "Segundo apellido:";
            // 
            // LabelLastName1
            // 
            this.LabelLastName1.AutoSize = true;
            this.LabelLastName1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelLastName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelLastName1.Location = new System.Drawing.Point(38, 130);
            this.LabelLastName1.Name = "LabelLastName1";
            this.LabelLastName1.Size = new System.Drawing.Size(118, 16);
            this.LabelLastName1.TabIndex = 7;
            this.LabelLastName1.Text = "Primer apellido:";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelFirstName.Location = new System.Drawing.Point(38, 90);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(67, 16);
            this.LabelFirstName.TabIndex = 6;
            this.LabelFirstName.Text = "Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateStudent);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.tbLastName2);
            this.groupBox1.Controls.Add(this.lblLastNameAsterisk);
            this.groupBox1.Controls.Add(this.LabelLastName2);
            this.groupBox1.Controls.Add(this.LabelDni);
            this.groupBox1.Controls.Add(this.lblFirstNameAsterisk);
            this.groupBox1.Controls.Add(this.tbDni);
            this.groupBox1.Controls.Add(this.lblDniAsterisk);
            this.groupBox1.Controls.Add(this.LabelFirstName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.tbLastName1);
            this.groupBox1.Controls.Add(this.LabelLastName1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 291);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificación";
            // 
            // ModifyStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 342);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ModifyStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewCycleForm";
            this.Load += new System.EventHandler(this.ModifyStudentForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton btnUpdateStudent;
        private CustomButton btnCancel;
        private CustomLabel LabelDni;
        private CustomLabel LabelLastName2;
        private CustomLabel LabelLastName1;
        private CustomLabel LabelFirstName;
        private CustomTextBox tbLastName2;
        private CustomTextBox tbLastName1;
        private CustomTextBox tbFirstName;
        private CustomTextBox tbDni;
        private System.Windows.Forms.Label lblFirstNameAsterisk;
        private System.Windows.Forms.Label lblDniAsterisk;
        private System.Windows.Forms.Label lblLastNameAsterisk;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
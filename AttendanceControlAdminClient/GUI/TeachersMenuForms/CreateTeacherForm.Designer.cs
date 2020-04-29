using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.Properties;
using System.Drawing;

namespace AttendanceControlAdminClient.GUI.TeachersMenuForms
{
    partial class CreateTeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeacherForm));
            this.btnCreateTeacher = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.LabelDni = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.LabelLastNameAsterisk = new System.Windows.Forms.Label();
            this.LabelFirstNameAsterisk = new System.Windows.Forms.Label();
            this.LabelDniAsterisk = new System.Windows.Forms.Label();
            this.tbLastName2 = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.tbLastName1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.tbFirstName = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.tbDni = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.LabelLastName2 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelLastName1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.LabelFirstName = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.customCloseButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateTeacher
            // 
            this.btnCreateTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCreateTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeacher.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCreateTeacher.ForeColor = System.Drawing.Color.White;
            this.btnCreateTeacher.Location = new System.Drawing.Point(414, 211);
            this.btnCreateTeacher.Name = "btnCreateTeacher";
            this.btnCreateTeacher.Size = new System.Drawing.Size(75, 25);
            this.btnCreateTeacher.TabIndex = 0;
            this.btnCreateTeacher.Text = "Dar alta";
            this.btnCreateTeacher.UseVisualStyleBackColor = false;
            this.btnCreateTeacher.Click += new System.EventHandler(this.ButtonCreateTeacher_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(414, 242);
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
            this.LabelDni.Location = new System.Drawing.Point(25, 60);
            this.LabelDni.Name = "LabelDni";
            this.LabelDni.Size = new System.Drawing.Size(35, 16);
            this.LabelDni.TabIndex = 5;
            this.LabelDni.Text = "Dni:";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.LabelLastNameAsterisk);
            this.groupBox.Controls.Add(this.LabelFirstNameAsterisk);
            this.groupBox.Controls.Add(this.LabelDniAsterisk);
            this.groupBox.Controls.Add(this.tbLastName2);
            this.groupBox.Controls.Add(this.tbLastName1);
            this.groupBox.Controls.Add(this.tbFirstName);
            this.groupBox.Controls.Add(this.tbDni);
            this.groupBox.Controls.Add(this.LabelLastName2);
            this.groupBox.Controls.Add(this.LabelLastName1);
            this.groupBox.Controls.Add(this.LabelFirstName);
            this.groupBox.Controls.Add(this.LabelDni);
            this.groupBox.Controls.Add(this.btnCreateTeacher);
            this.groupBox.Controls.Add(this.btnCancel);
            this.groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox.ForeColor = global::AttendanceControlAdminClient.Properties.Settings.Default.OPTIMA_COLOR;
            this.groupBox.Location = new System.Drawing.Point(38, 70);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(506, 285);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Alta de profesor";
            // 
            // LabelLastNameAsterisk
            // 
            this.LabelLastNameAsterisk.AutoSize = true;
            this.LabelLastNameAsterisk.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.LabelLastNameAsterisk.ForeColor = System.Drawing.Color.Black;
            this.LabelLastNameAsterisk.Location = new System.Drawing.Point(390, 140);
            this.LabelLastNameAsterisk.Name = "LabelLastNameAsterisk";
            this.LabelLastNameAsterisk.Size = new System.Drawing.Size(17, 22);
            this.LabelLastNameAsterisk.TabIndex = 15;
            this.LabelLastNameAsterisk.Text = "*";
            // 
            // LabelFirstNameAsterisk
            // 
            this.LabelFirstNameAsterisk.AutoSize = true;
            this.LabelFirstNameAsterisk.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.LabelFirstNameAsterisk.ForeColor = System.Drawing.Color.Black;
            this.LabelFirstNameAsterisk.Location = new System.Drawing.Point(390, 100);
            this.LabelFirstNameAsterisk.Name = "LabelFirstNameAsterisk";
            this.LabelFirstNameAsterisk.Size = new System.Drawing.Size(17, 22);
            this.LabelFirstNameAsterisk.TabIndex = 14;
            this.LabelFirstNameAsterisk.Text = "*";
            // 
            // LabelDniAsterisk
            // 
            this.LabelDniAsterisk.AutoSize = true;
            this.LabelDniAsterisk.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.LabelDniAsterisk.ForeColor = System.Drawing.Color.Black;
            this.LabelDniAsterisk.Location = new System.Drawing.Point(279, 61);
            this.LabelDniAsterisk.Name = "LabelDniAsterisk";
            this.LabelDniAsterisk.Size = new System.Drawing.Size(17, 22);
            this.LabelDniAsterisk.TabIndex = 13;
            this.LabelDniAsterisk.Text = "*";
            // 
            // tbLastName2
            // 
            this.tbLastName2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbLastName2.ForeColor = System.Drawing.Color.Black;
            this.tbLastName2.Location = new System.Drawing.Point(176, 179);
            this.tbLastName2.Name = "tbLastName2";
            this.tbLastName2.Size = new System.Drawing.Size(208, 20);
            this.tbLastName2.TabIndex = 12;
            // 
            // tbLastName1
            // 
            this.tbLastName1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbLastName1.ForeColor = System.Drawing.Color.Black;
            this.tbLastName1.Location = new System.Drawing.Point(176, 139);
            this.tbLastName1.Name = "tbLastName1";
            this.tbLastName1.Size = new System.Drawing.Size(208, 20);
            this.tbLastName1.TabIndex = 11;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbFirstName.Location = new System.Drawing.Point(176, 99);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(208, 20);
            this.tbFirstName.TabIndex = 10;
            // 
            // tbDni
            // 
            this.tbDni.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbDni.ForeColor = System.Drawing.Color.Black;
            this.tbDni.Location = new System.Drawing.Point(176, 60);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(97, 20);
            this.tbDni.TabIndex = 9;
            // 
            // LabelLastName2
            // 
            this.LabelLastName2.AutoSize = true;
            this.LabelLastName2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelLastName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelLastName2.Location = new System.Drawing.Point(25, 180);
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
            this.LabelLastName1.Location = new System.Drawing.Point(25, 140);
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
            this.LabelFirstName.Location = new System.Drawing.Point(25, 100);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(67, 16);
            this.LabelFirstName.TabIndex = 6;
            this.LabelFirstName.Text = "Nombre:";
            // 
            // customCloseButton1
            // 
            this.customCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("customCloseButton1.Image")));
            this.customCloseButton1.Location = new System.Drawing.Point(532, 23);
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.Size = new System.Drawing.Size(30, 30);
            this.customCloseButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customCloseButton1.TabIndex = 7;
            this.customCloseButton1.TabStop = false;
            // 
            // CreateTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 403);
            this.Controls.Add(this.customCloseButton1);
            this.Controls.Add(this.groupBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CreateTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewCycleForm";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton btnCreateTeacher;
        private CustomButton btnCancel;
        private CustomLabel LabelDni;
        private System.Windows.Forms.GroupBox groupBox;
        private CustomLabel LabelLastName2;
        private CustomLabel LabelLastName1;
        private CustomLabel LabelFirstName;
        private CustomTextBox tbLastName2;
        private CustomTextBox tbLastName1;
        private CustomTextBox tbFirstName;
        private CustomTextBox tbDni;
        private System.Windows.Forms.Label LabelFirstNameAsterisk;
        private System.Windows.Forms.Label LabelDniAsterisk;
        private System.Windows.Forms.Label LabelLastNameAsterisk;
        private CustomCloseButton customCloseButton1;
    }
}
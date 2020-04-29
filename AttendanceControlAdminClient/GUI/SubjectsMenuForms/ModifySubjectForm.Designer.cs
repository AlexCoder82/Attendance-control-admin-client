using AttendanceControlAdminClient.GUI.CustomControls;
using System;

namespace AttendanceControlAdminClient.GUI.SubjectsMenuForms
{
    partial class ModifySubjectForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifySubjectForm));
            this.LabelMessage = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.btnModifySubject = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.tbSubjectName = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.CustomCloseButton = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            ((System.ComponentModel.ISupportInitialize)(this.CustomCloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelMessage.Location = new System.Drawing.Point(57, 91);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(382, 16);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "¿Qué nuevo nombre le quieres pone a la asignatura?";
            // 
            // btnModifySubject
            // 
            this.btnModifySubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnModifySubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifySubject.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnModifySubject.ForeColor = System.Drawing.Color.White;
            this.btnModifySubject.Location = new System.Drawing.Point(487, 167);
            this.btnModifySubject.Name = "btnModifySubject";
            this.btnModifySubject.Size = new System.Drawing.Size(75, 25);
            this.btnModifySubject.TabIndex = 0;
            this.btnModifySubject.Text = "Modificar";
            this.btnModifySubject.UseVisualStyleBackColor = false;
            this.btnModifySubject.Click += new System.EventHandler(this.BtnModifySubject_Click);
            // 
            // tbSubjectName
            // 
            this.tbSubjectName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbSubjectName.ForeColor = System.Drawing.Color.Black;
            this.tbSubjectName.Location = new System.Drawing.Point(60, 127);
            this.tbSubjectName.Name = "tbSubjectName";
            this.tbSubjectName.Size = new System.Drawing.Size(389, 20);
            this.tbSubjectName.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(487, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CustomCloseButton
            // 
            this.CustomCloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CustomCloseButton.Image")));
            this.CustomCloseButton.Location = new System.Drawing.Point(532, 23);
            this.CustomCloseButton.Name = "CustomCloseButton";
            this.CustomCloseButton.Size = new System.Drawing.Size(30, 30);
            this.CustomCloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CustomCloseButton.TabIndex = 4;
            this.CustomCloseButton.TabStop = false;
            // 
            // ModifySubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 256);
            this.Controls.Add(this.CustomCloseButton);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbSubjectName);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.btnModifySubject);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ModifySubjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyCyclesForm";
            ((System.ComponentModel.ISupportInitialize)(this.CustomCloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btnModifySubject;
        private CustomLabel LabelMessage;
        private CustomTextBox tbSubjectName;
        private CustomButton btnCancel;
        private CustomCloseButton CustomCloseButton;
    }
}

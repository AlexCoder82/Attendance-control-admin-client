using AttendanceControlAdminClient.GUI.CustomControls;
using System;

namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    partial class ModifyCycleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyCycleForm));
            this.LabelMessage = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.btnModifyCycle = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.tbCycleName = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.customCloseButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelMessage
            // 
            this.LabelMessage.AutoSize = true;
            this.LabelMessage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.LabelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.LabelMessage.Location = new System.Drawing.Point(57, 91);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(406, 16);
            this.LabelMessage.TabIndex = 1;
            this.LabelMessage.Text = "¿Qué nuevo nombre le quieres poner al ciclo formativo?";
            // 
            // btnModifyCycle
            // 
            this.btnModifyCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnModifyCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyCycle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnModifyCycle.ForeColor = System.Drawing.Color.White;
            this.btnModifyCycle.Location = new System.Drawing.Point(487, 167);
            this.btnModifyCycle.Name = "btnModifyCycle";
            this.btnModifyCycle.Size = new System.Drawing.Size(75, 25);
            this.btnModifyCycle.TabIndex = 0;
            this.btnModifyCycle.Text = "Modificar";
            this.btnModifyCycle.UseVisualStyleBackColor = false;
            this.btnModifyCycle.Click += new System.EventHandler(this.ButtonModifyCycle_Click);
            // 
            // tbCycleName
            // 
            this.tbCycleName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbCycleName.ForeColor = System.Drawing.Color.Black;
            this.tbCycleName.Location = new System.Drawing.Point(60, 127);
            this.tbCycleName.Name = "tbCycleName";
            this.tbCycleName.Size = new System.Drawing.Size(403, 20);
            this.tbCycleName.TabIndex = 2;
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
            this.btnCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // customCloseButton1
            // 
            this.customCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("customCloseButton1.Image")));
            this.customCloseButton1.Location = new System.Drawing.Point(532, 23);
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.Size = new System.Drawing.Size(30, 30);
            this.customCloseButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customCloseButton1.TabIndex = 4;
            this.customCloseButton1.TabStop = false;
            // 
            // ModifyCycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 256);
            this.Controls.Add(this.customCloseButton1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbCycleName);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.btnModifyCycle);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ModifyCycleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyCyclesForm";
            this.Load += new System.EventHandler(this.ModifyCycleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton btnModifyCycle;
        private CustomLabel LabelMessage;
        private CustomTextBox tbCycleName;
        private CustomButton btnCancel;
        private CustomCloseButton customCloseButton1;
    }
}

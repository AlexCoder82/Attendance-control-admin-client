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
            this.label1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.btnModifyCycle = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.tbCycleName = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbShiftes = new AttendanceControlAdminClient.GUI.CustomControls.CustomComboBox();
            this.label2 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Qué nuevo nombre tendrá el ciclo formativo?";
            // 
            // btnModifyCycle
            // 
            this.btnModifyCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnModifyCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyCycle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnModifyCycle.ForeColor = System.Drawing.Color.White;
            this.btnModifyCycle.Location = new System.Drawing.Point(264, 191);
            this.btnModifyCycle.Name = "btnModifyCycle";
            this.btnModifyCycle.Size = new System.Drawing.Size(75, 25);
            this.btnModifyCycle.TabIndex = 0;
            this.btnModifyCycle.Text = "Guardar";
            this.btnModifyCycle.UseVisualStyleBackColor = false;
            this.btnModifyCycle.Click += new System.EventHandler(this.ButtonModifyCycle_Click);
            // 
            // tbCycleName
            // 
            this.tbCycleName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbCycleName.ForeColor = System.Drawing.Color.Black;
            this.tbCycleName.Location = new System.Drawing.Point(30, 90);
            this.tbCycleName.Name = "tbCycleName";
            this.tbCycleName.Size = new System.Drawing.Size(378, 20);
            this.tbCycleName.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(128, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbShiftes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnModifyCycle);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCycleName);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 239);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificación";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // cbShiftes
            // 
            this.cbShiftes.BackColor = System.Drawing.Color.White;
            this.cbShiftes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShiftes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbShiftes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.cbShiftes.FormattingEnabled = true;
            this.cbShiftes.Location = new System.Drawing.Point(301, 129);
            this.cbShiftes.Name = "cbShiftes";
            this.cbShiftes.Size = new System.Drawing.Size(107, 22);
            this.cbShiftes.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "¿Durante que turno se desarrollará?";
            // 
            // ModifyCycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 285);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ModifyCycleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyCyclesForm";
            this.Load += new System.EventHandler(this.ModifyCycleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton btnModifyCycle;
        private CustomLabel label1;
        private CustomTextBox tbCycleName;
        private CustomButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomLabel label2;
        private CustomComboBox cbShiftes;
    }
}

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    partial class CustomConfirmDialogForm
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
            this.labelMessage = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.icon = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.btnAccept = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.labelMessage.Location = new System.Drawing.Point(94, 80);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(384, 20);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(153, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // icon
            // 
            this.icon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.icon.Image = global::AttendanceControlAdminClient.Properties.Resources.icono_confirmacion;
            this.icon.Location = new System.Drawing.Point(26, 64);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 50);
            this.icon.TabIndex = 3;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(293, 130);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Confirmar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.ButtonAccept_Click);
            // 
            // CustomConfirmDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 200);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelMessage);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CustomConfirmDialogForm";
            this.Text = "CustomConfirmDialogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomLabel labelMessage;
        private CustomButton btnCancel;
        private CustomLabel icon;
        private CustomButton btnAccept;
    }
}
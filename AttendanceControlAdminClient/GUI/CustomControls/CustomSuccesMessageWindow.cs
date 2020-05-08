using System;
using System.Drawing;
using System.Windows.Forms;


namespace AttendanceControlAdminClient.GUI.CustomControls
{
    public class CustomSuccesMessageWindow : CustomDialogForm
    {
        private CustomLabel lblOkIcon;
        private CustomButton btnAccept;
        private CustomLabel labelMessage;

        public CustomSuccesMessageWindow(string message)
        {
           
            this.InitializeComponent();
            this.CenterToScreen();
            this.SetMessageLocation(message);
            this.labelMessage.Text = message;

        }

        private void SetMessageLocation(string message)
        {
           
             if (message.Length >50 && message.Length  < 100)
            {
                this.labelMessage.Location = new Point(
                    this.labelMessage.Location.X, 70);
                this.labelMessage.Height = 40;


            }
            else if (message.Length < 150)
            {
                this.labelMessage.Location = new Point(
                    this.labelMessage.Location.X, 60);
                this.labelMessage.Height = 60;
                this.btnAccept.Location = new Point(
                    this.btnAccept.Location.X, 140);
            }
            else if (message.Length < 200)
            {
                this.labelMessage.Location = new Point(
                    this.labelMessage.Location.X, 50);
                this.labelMessage.Height = 80;
                this.btnAccept.Location = new Point(
                    this.btnAccept.Location.X, 150);
                this.Height = this.Height + 10;
            }
            else if (message.Length < 250)
            {
                this.labelMessage.Location = new Point(
                    this.labelMessage.Location.X, 40);
                this.labelMessage.Height = 100;
                this.btnAccept.Location = new Point(
                    this.btnAccept.Location.X, 160);
                this.Height = this.Height + 20;
            }
            else if (message.Length < 300)
            {
                this.labelMessage.Location = new Point(
                    this.labelMessage.Location.X, 30);
                this.labelMessage.Height = 120;
                this.btnAccept.Location = new Point(
                    this.btnAccept.Location.X, 170);
                this.Height = this.Height + 30;
            }
            else if (message.Length < 350)
            {
                this.labelMessage.Location = new Point(
                    this.labelMessage.Location.X, 20);
                this.labelMessage.Height = 140;
                this.btnAccept.Location = new Point(
                    this.btnAccept.Location.X, 180);
                this.Height = this.Height + 40;
            }
        }

        private void InitializeComponent()
        {
            this.btnAccept = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.lblOkIcon = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.labelMessage = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(240, 130);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 25);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // lblOkIcon
            // 
            this.lblOkIcon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblOkIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.lblOkIcon.Image = global::AttendanceControlAdminClient.Properties.Resources.icono_ok;
            this.lblOkIcon.Location = new System.Drawing.Point(36, 66);
            this.lblOkIcon.Name = "lblOkIcon";
            this.lblOkIcon.Size = new System.Drawing.Size(50, 50);
            this.lblOkIcon.TabIndex = 1;
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.labelMessage.Location = new System.Drawing.Point(103, 80);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(384, 20);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomSuccesMessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(516, 200);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.lblOkIcon);
            this.Controls.Add(this.btnAccept);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CustomSuccesMessageWindow";
            this.ResumeLayout(false);

        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

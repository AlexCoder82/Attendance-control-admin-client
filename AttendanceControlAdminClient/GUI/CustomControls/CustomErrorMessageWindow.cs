using AttendanceControlAdminClient.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CustomControls
{
    /// <summary>
    ///     Ventana personalizada para anunciar los errores
    /// </summary>
    class CustomErrorMessageWindow : CustomDialogForm
    {
        private CustomLabel labelMessage;
        private CustomButton btnAccept;
        private CustomLabel lblErrorIcon;

        public CustomErrorMessageWindow(string message)
        { 
            this.InitializeComponent();
            this.CenterToScreen();
            this.SetMessageLocation(message);
            this.labelMessage.Text = message;
        }

        /// <summary>
        ///     Establece la posicion del mensaje segun lo largo que es para
        ///     centrarlo en la ventana, si es necesario se agranda la ventana.
        /// </summary>
        /// <param name="message"></param>
        private void SetMessageLocation(string message)
        {

            if (message.Length > 50 && message.Length < 100)
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


        /// <summary>
        ///     Crea los componentes
        /// </summary>
        private void InitializeComponent()
        {
            this.lblErrorIcon = new CustomLabel();
            this.labelMessage = new CustomLabel();
            this.btnAccept = new CustomButton();
            this.SuspendLayout();
            // 
            // lblErrorIcon
            // 
            this.lblErrorIcon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblErrorIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.lblErrorIcon.Image = global::AttendanceControlAdminClient.Properties.Resources.error_icon;
            this.lblErrorIcon.Location = new System.Drawing.Point(36, 66);
            this.lblErrorIcon.Name = "lblErrorIcon";
            this.lblErrorIcon.Size = new System.Drawing.Size(50, 50);
            this.lblErrorIcon.TabIndex = 1;
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
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(240, 130);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 25);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // CustomErrorMessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(518, 200);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.lblErrorIcon);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CustomErrorMessageWindow";
            this.ResumeLayout(false);

        }
    
        /// <summary>
        ///     Evento al pulsar Aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAccept_Click_1(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}

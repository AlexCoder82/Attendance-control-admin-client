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
        private CustomLabel lblMessage;
        private CustomCloseButton customCloseButton1;
        private CustomLabel lblErrorIcon;


        /// <summary>
        ///     Constructor 
        /// </summary>
        /// <param name="message">
        ///     El mensaje de error a mostrar
        /// </param>
        public CustomErrorMessageWindow(string message)
        { 
            this.InitializeComponent();
            this.CenterToScreen();
            this.lblMessage.Text = message;
        }
            



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomErrorMessageWindow));
            this.lblErrorIcon = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.lblMessage = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.customCloseButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorIcon
            // 
            this.lblErrorIcon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblErrorIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.lblErrorIcon.Image = global::AttendanceControlAdminClient.Properties.Resources.error_icon;
            this.lblErrorIcon.Location = new System.Drawing.Point(50, 67);
            this.lblErrorIcon.Name = "lblErrorIcon";
            this.lblErrorIcon.Size = new System.Drawing.Size(50, 50);
            this.lblErrorIcon.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.lblMessage.Location = new System.Drawing.Point(136, 67);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(300, 50);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customCloseButton1
            // 
            this.customCloseButton1.Image = ((System.Drawing.Image)(resources.GetObject("customCloseButton1.Image")));
            this.customCloseButton1.Location = new System.Drawing.Point(448, 22);
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.Size = new System.Drawing.Size(30, 30);
            this.customCloseButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.customCloseButton1.TabIndex = 3;
            this.customCloseButton1.TabStop = false;
            // 
            // CustomErrorMessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(500, 185);
            this.Controls.Add(this.customCloseButton1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblErrorIcon);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CustomErrorMessageWindow";
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).EndInit();
            this.ResumeLayout(false);

        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}

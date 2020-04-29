using AttendanceControlAdminClient.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AttendanceControlAdminClient.GUI.CustomControls
{
    public class CustomSuccesMessageWindow : CustomDialogForm
    {
        private CustomLabel lblMessage;
        private CustomLabel lblOkIcon;
        private CustomButton btnAccept;
        private int heightExtra;

        public CustomSuccesMessageWindow(string message,int heightExtra )
        {
            this.heightExtra = heightExtra;
            this.InitializeComponent();
            this.CenterToScreen();
            this.lblMessage.Text =message;
            
        }

        private void InitializeComponent()
        {
            this.btnAccept = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.lblMessage = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.lblOkIcon = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(213, 154);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 25);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.lblMessage.Location = new System.Drawing.Point(140, 40);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(292, 92);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOkIcon
            // 
            this.lblOkIcon.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblOkIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.lblOkIcon.Image = global::AttendanceControlAdminClient.Properties.Resources.icono_ok;
            this.lblOkIcon.Location = new System.Drawing.Point(51, 63);
            this.lblOkIcon.Name = "lblOkIcon";
            this.lblOkIcon.Size = new System.Drawing.Size(50, 50);
            this.lblOkIcon.TabIndex = 2;
            // 
            // CustomSuccesMessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 215);
            this.Controls.Add(this.lblOkIcon);
            this.Controls.Add(this.lblMessage);
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

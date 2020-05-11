using System;
using System.Drawing;


namespace AttendanceControlAdminClient.GUI.CustomControls
{
    /// <summary>
    ///     Ventanita de confirmacion 
    /// </summary>
    public partial class CustomConfirmDialogForm : CustomDialogForm
    {
        public bool Confirmed { get; set; }
        public CustomConfirmDialogForm(string message)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.SetMessageLocation(message);
            this.labelMessage.Text = message;
            
        }
        /// <summary>
        ///     Establece la posicion del mensajes segun lo largo que es para
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
                this.btnCancel.Location = new Point(
                    this.btnCancel.Location.X, 140);
            }
            else if (message.Length < 200)
            {
                this.labelMessage.Location = new Point(
                    this.labelMessage.Location.X, 50);
                this.labelMessage.Height = 80;
                this.btnAccept.Location = new Point(
                    this.btnAccept.Location.X, 150);
                this.btnCancel.Location = new Point(
                 this.btnCancel.Location.X, 150);
                this.Height = this.Height + 10;

            }
            else if (message.Length < 250)
            {
                this.labelMessage.Location = new Point(
                    this.labelMessage.Location.X, 40);
                this.labelMessage.Height = 100;
                this.btnAccept.Location = new Point(
                    this.btnAccept.Location.X, 160);
                this.btnCancel.Location = new Point(
                 this.btnCancel.Location.X, 160);
                this.Height = this.Height + 20;
            }
            else if (message.Length < 300)
            {
                this.labelMessage.Location = new Point(
                    this.labelMessage.Location.X, 30);
                this.labelMessage.Height = 120;
                this.btnAccept.Location = new Point(
                    this.btnAccept.Location.X, 170);
                this.btnCancel.Location = new Point(
                 this.btnCancel.Location.X, 170);
                this.Height = this.Height + 30;
            }
            else if (message.Length < 350)
            {
                this.labelMessage.Location = new Point(
                    this.labelMessage.Location.X, 20);
                this.labelMessage.Height = 140;
                this.btnAccept.Location = new Point(
                    this.btnAccept.Location.X, 180);
                this.btnCancel.Location = new Point(
                 this.btnCancel.Location.X, 180);
                this.Height = this.Height + 40;
            }

        }

        /// <summary>
        ///     Evento al pulsar confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            Confirmed = true;
            this.Close();
        }

        /// <summary>
        ///     Evento al pulsar cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Confirmed = false;
            this.Close();
        }

    }
}

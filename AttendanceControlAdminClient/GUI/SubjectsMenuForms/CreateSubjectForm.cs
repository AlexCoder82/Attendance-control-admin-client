using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;

namespace AttendanceControlAdminClient.GUI.SubjectsMenuForms
{
    public partial class CreateSubjectForm : CustomDialogForm
    {
        //Callback con la nueva asignatura creada
        public delegate void OnCreatedSubjectCallBack(Subject subject);
        public OnCreatedSubjectCallBack OnCreatedSubjectDelegate;

        public CreateSubjectForm()
        {

            InitializeComponent();

        }

        /// <summary>
        ///     Evento al pulsar Crear asignatura:
        ///     Se envia al cliente http la asignatura creada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnCreateSubject_Click(object sender, EventArgs e)
        {
            string subjectName = this.tbSubjectName.Text;

            if (subjectName.Length > 0)
            {
                Subject subject = new Subject()
                {
                    Name = subjectName
                };

                try
                {
                    //La asignatura pasa a ser la asignatura retornada por el cliente http
                    subject = await SubjectHttpService.Save(subject);

                    string message = string
                        .Format("Has registrado la asignatura {0}.", subject.Name);

                    new CustomSuccesMessageWindow(message).ShowDialog();
                    this.Close();

                    this.OnCreatedSubjectDelegate(subject);//Respuesta

                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }

            }
        }

        /// <summary>
        ///     Evento al pulsar cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
    
            this.Close();

        }

    }
}

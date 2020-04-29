using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;

namespace AttendanceControlAdminClient.GUI.SubjectsMenuForms
{
    public partial class CreateSubjectForm : CustomDialogForm
    {
        public Subject CreatedSubject { get; set; }//La asignatura creada

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
                    this.CreatedSubject = await SubjectHttpService.Save(subject);

                    string message = string
                        .Format("Has registrado la asignatura {0}.",CreatedSubject.Name);
                    new CustomSuccesMessageWindow(message,0).ShowDialog();
                    this.Close();
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }

            }
        }

        /// <summary>
        ///     Botón al pulsar cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.CreatedSubject = null;
            this.Close();
        }

    }
}

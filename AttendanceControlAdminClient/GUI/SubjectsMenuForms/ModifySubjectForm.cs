using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.SubjectsMenuForms
{
    public partial class ModifySubjectForm : CustomDialogForm
    {
        public delegate void OnUpdatedSubjectCallBack(Subject subject);
        public OnUpdatedSubjectCallBack OnUpdatedSubjectDelegate;
        public Subject _subject;//Copia de la asignatura a modificar

        public ModifySubjectForm(Subject subject)
        {

            InitializeComponent();
            _subject = new Subject();//Evita el paso por referencia
            _subject = subject;
            this.tbSubjectName.Text = subject.Name;     
            
        }


        /// <summary>
        ///     Evento al pulsar Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        /// <summary>
        ///     Evento al pulsar Modificar:
        ///     Se envia al cliente http la copia de la asignatura con
        ///     su nuevo nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnModifySubject_Click(object sender, EventArgs e)
        {

            string subjectName = this.tbSubjectName.Text;

            if (subjectName.Length > 0)//Validacion minima
            {
                _subject.Name = subjectName;

                try
                {
                    Subject updatedSubject = await SubjectHttpService
                            .Update(_subject);

                    //Ventanita de mensaje de éxito
                    string message = "Has actualizado el nombre de la asignatura.";
                    new CustomSuccesMessageWindow(message).ShowDialog();
                    this.Close();

                    this.OnUpdatedSubjectDelegate(updatedSubject);//Respuesta
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }

            }

        }

    }
}

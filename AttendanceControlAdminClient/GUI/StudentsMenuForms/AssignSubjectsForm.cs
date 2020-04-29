using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{ 
    public partial class AssignSubjectsForm : CustomDialogForm
    {
        private Student _student;
        public Student UpdatedStudent { get; set; }
        private List<Subject> _subjects;

        public AssignSubjectsForm(Student student)
        {
            _student = student;
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        ///     Evento al cargar este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AssignStudentSubjectsForm_Load(object sender, EventArgs e)
        {
            this.SetLabels();
            await this.GetSubjects();
            this.PopulateCheckedListBoxSubjects();

        }

        /// <summary>
        ///     Recupera la lista de asignaturas dado un curso del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetSubjects()
        {
            try
            {
                _subjects = await SubjectHttpService.GetByCourse(_student.Course.Id);
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
        }

        /// <summary>
        ///     Rellena los lables con los datos del alumno y el curso 
        /// </summary>
        private void SetLabels()
        {

            this.LabelDni.Text = _student.Dni;
            this.LabelFullName.Text = _student.FullName;
            this.LabelCurrentCourse.Text = string
                .Format("{0}º de {1}", _student.Course.Year, _student.Course.Cycle.Name);

        }

        /// <summary>
        ///     Rellena el checkedListBox de asignaturas
        /// </summary>
        private void PopulateCheckedListBoxSubjects()
        {
            
 
            if (!(_student.Subjects is null))
            {
                //Recupera el nombde de las asignaturas en una array 
                string[] subjectNames = _subjects.Select(s => s.Name).ToArray();
                //Asigna el array al checkedListBoxs
                this.clbSubjects.Items.AddRange(subjectNames);

                //Comprueba si el alumno ya tiene asignada algunas de las asignaturas
                //En tal caso las marca en el checkedListBoxs
                _student.Subjects.ForEach(s =>
                {
                    bool found = false;
                    for (int i = 0; i < this.clbSubjects.Items.Count && !found; i++)
                    {
                        if (s.Name == this.clbSubjects.Items[i].ToString())
                        {
                            this.clbSubjects.SetItemChecked(i, true);
                            found = true;
                        }
                    }
                });
            }

        }

        /// <summary>
        ///     Evento al pulsar Guardar:
        ///     Envia al cliente http el id del alumno, y los ids de cada
        ///     asignaturas que va a cursar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonSave_Click(object sender, EventArgs e)
        {
            if (this.clbSubjects.Items.Count > 0)
            {
                //Lista de ids de asignaturas
                List<int> subjectIds = new List<int>();

                //Recorre las asignaturas marcadas y agrega su id a la lista
                foreach (object itemChecked in this.clbSubjects.CheckedItems)
                {
                    //Recupero el Id de la asignatura comparando el nombre
                    int id = _subjects
                        .Where(s => s.Name == itemChecked.ToString())
                        .Select(s => s.Id)
                        .FirstOrDefault();

                    subjectIds.Add(id);
                }

                try
                {
                    UpdatedStudent = await StudentHttpService
                        .UpdateSubjects(_student.Id, subjectIds.ToArray());

                    string message = string
                        .Format("Has actualizado las asignaturas cursadas por el alumno {0}",
                        _student.FullName);
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
        ///     Evento al pulsar Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

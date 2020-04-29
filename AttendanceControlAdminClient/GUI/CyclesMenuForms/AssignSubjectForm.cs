using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    public partial class AssignSubjectForm : CustomDialogForm
    {
        private string _cycleName;
        private Course _course;//El curso recibido 
        private List<Subject> _subjects;//La lista de todas las asignaturas 
        public bool IsAdded { get; set; }//Indica si se ha añadido la nueva asignatura o no

        public AssignSubjectForm(Course course, string cycleName)
        {
            _course = course;
            _cycleName = cycleName;
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        ///     Asigna medidas a la tabla de asignaturas
        /// </summary>
        private void SetDataGridViewSubjects()
        {
            this.dgvSubjects.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        ///     Recibe la lista de todas las asignaturas del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllSubjects()
        {
            try
            {
                _subjects = await SubjectHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Rellena la tabla de asignaturas con las asignaturas cuyo 
        ///     nombre empiezen por la cadena pasada
        /// </summary>
        /// <param name="subjectName">
        ///     Nombre de la asignatura
        /// </param>
        private void PopulateSubjectsTable(string subjectName)
        {
            this.dgvSubjects.Rows.Clear();

            //Por defecto se retira el evento de selección
            this.dgvSubjects.SelectionChanged -=
                new EventHandler(this.DataGridViewSubjects_SelectionChanged);

            subjectName = subjectName.TrimStart();
            int length = subjectName.Length;

            if (!(_subjects is null) && _subjects.Count > 0)
            {
                _subjects.ForEach(s =>
                {
                    //Si las letras introducidas corresponden a los nombres 
                    //de las asignaturas 
                    if (s.Name.Length >= length
                        && subjectName
                            .Equals(s.Name.Substring(0, length),
                                StringComparison.InvariantCultureIgnoreCase))
                    {
                        //Solo agrego a la tabla las asignaturas que el curso 
                        //no tiene ya asignadas para evitar asignar dos veces la misma
                        bool found = false;
                        for (int i = 0; i < _course.Subjects.Count && !found; i++)
                        {
                            if (s.Name.Equals(_course.Subjects[i].Name))
                            {
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            this.dgvSubjects.Rows.Add(s.Id, s.Name);
                        }
                    }
                });


            }

            //Si se ha añadido al menos una asignatura a la tabla ,
            //se crea el evento de selección
            if (this.dgvSubjects.Rows.Count > 0)
            {
                this.dgvSubjects.SelectionChanged +=
                    new EventHandler(this.DataGridViewSubjects_SelectionChanged);
            }

            //Si no hay asignaturas, se crean 5 registros vacios(diseño)
            if (_subjects is null || _subjects.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvSubjects.Rows.Add();
                }
            }
     
            this.dgvSubjects.ClearSelection();
            this.btnAssign.Enabled = false;
        }

        #region EVENTOS DEL FORMULARIO

        /// <summary>
        ///     Evento al cargarse este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AssignNewSubjectForm_Load(object sender, EventArgs e)
        {
            this.setMessageLabel();
            this.SetDataGridViewSubjects();
            await this.GetAllSubjects();
            PopulateSubjectsTable("");
        }

        private void setMessageLabel()
        {
            string courseName = string.Format("{0}º de {1}",_course.Year, _cycleName);
            this.labelCourse.Text = courseName;
        }

        /// <summary>
        ///     Evento al escribir en el textbox:
        ///     Se vuelve a rellenar la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSubject_TextChanged(object sender, EventArgs e)
        {
            this.PopulateSubjectsTable(this.tbSubject.Text);

        }

        /// <summary>
        ///     Evento al seleccionar una asignatura:
        ///     Se habilita el botón para asignarla al curso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewSubjects_SelectionChanged(object sender, EventArgs e)
        {
            if (!(_subjects is null) && _subjects.Count > 0
                && this.dgvSubjects.SelectedRows.Count>0)
            {
                this.btnAssign.Enabled = true;
            }
        }

        /// <summary>
        ///     Evento al pulsar cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///     Evento al pulsar asignar:
        ///     Se crea una copia del curso a la cuál se agrega la asignatura
        ///     seleccionada y se envia el cliente http, el cuál retorna 
        ///     el curso modificado del servidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAssign_Click(object sender, EventArgs e)
        {
            //Recupera el id de la asignatura seleccionada
            int selectedId = (int)this.dgvSubjects
                .SelectedRows[0].Cells[0].Value;

            //Recupera la asignatura
            Subject subject = _subjects.FirstOrDefault(s => s.Id == selectedId);

            try
            {
                IsAdded = await CourseHttpService.AssignSubject(_course.Id, selectedId);
                _course.Subjects.Add(subject);
                this.Close();
            }
            catch (ServerErrorException ex)
            {
                IsAdded = false;
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
        }

        #endregion

       
    }
}

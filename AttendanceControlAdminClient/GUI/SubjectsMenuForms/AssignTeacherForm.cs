using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;


namespace AttendanceControlAdminClient.GUI.SubjectsMenuForms
{
    public partial class AssignTeacherForm : CustomDialogForm
    {
        private Subject _subject;//La asignatura recibida
        private List<Teacher> _teachers; //La lista de todos los profesores
        private Teacher _selectedTeacher;//El profesor seleccionado en la tabla

        public Subject UpdatedSubject { get; set; }//La asignatura actualizada
        public bool SubjectIsAssigned { get; set; }//Indica si se ha asignado o no

        public AssignTeacherForm(Subject subject)
        {
            _subject = subject;
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        ///     Rellena los distintos labels con el nombre de la asignatura
        ///     y el nombre del profesor asignado hasta ahora
        /// </summary>
        private void SetLabels()
        {
            this.LabelCurrentSubject.Text = _subject.Name;

            //Si la asignatura no esta asignada a ningún profesor
            if (_subject.Teacher is null)
            {
                this.LabelCurrentTeacher.Text = "Sin asignar";
                this.SubjectIsAssigned = false;
                this.ButtonRemoveAssignment.Enabled = false;
            }
            else
            {
                this.LabelCurrentTeacher.Text = _subject.Teacher.FullName;
                this.SubjectIsAssigned = true;
            }

            this.LabelCurrentSubject.ForeColor = Color.Black;
            this.LabelCurrentTeacher.ForeColor = Color.Black;
        }

        /// <summary>
        ///     Establece una anchura automática a la columna del nombre de 
        ///     los profesores.
        /// </summary>
        private void SetDataGridViewTeachers()
        {
            this.dgvTeachers.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        ///     Rellena la tabla de los profesores
        /// </summary>
        private void PopulateTeachersTable()
        {
            this.dgvTeachers.ClearSelection();

            //Por defecto se retira el evento de selección
            this.dgvTeachers.SelectionChanged -=
                new System.EventHandler(this.DataGridViewTeachers_SelectionChanged);

            if (!(this._teachers is null) && this._teachers.Count > 0)
            {
                this._teachers.ForEach(t =>
                {
                    this.dgvTeachers.Rows.Add(t.Id, t.Dni, t.FullName);
                });
                //Si hay al menos un profesor, se crea el evento de selección
                this.dgvTeachers.SelectionChanged +=
                    new System.EventHandler(this.DataGridViewTeachers_SelectionChanged);

            }
            //Si no hay profesores, se rellena la tabla con 5 registros vacíos
            if ((this._teachers is null) || this._teachers.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvTeachers.Rows.Add();
                }
            }

            this.dgvTeachers.ClearSelection();
            this.btnAssign.Enabled = false;
            this.LabelNewAssignedTeacher.Text = "";
        }

        /// <summary>
        ///     Recibe la lista de todos los profesores del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllTeachers()
        {
            try
            {
                _teachers = await TeacherHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                Console.WriteLine("AAA" + ex.Message);
            }
        }

        /// <summary>
        ///     Evento al seleccionar un profesor en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (!(_teachers is null) && _teachers.Count > 0
                && this.dgvTeachers.SelectedRows.Count > 0)
            {

                ///Se habilita el botón para modificar un ciclo
                this.btnAssign.Enabled = true;

                //Recupera el Id del profesor seleccionado
                int selectedId = int
                    .Parse(this.dgvTeachers.SelectedRows[0].Cells[0].Value
                    .ToString());

                //Recupera el profesor seleccionado
                _selectedTeacher = this._teachers
                 .FirstOrDefault(c => c.Id == selectedId);

                //Escribe su nombre en el label 
                this.LabelNewAssignedTeacher.Text = _selectedTeacher.FullName;
            }
        }

        /// <summary>
        ///     Evento al pulsar Asignar:
        ///     Se envia al cliente http, el id de la asignatura y 
        ///     el id del nuevo profesor asignado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnAssign_Click(object sender, EventArgs e)
        {
            if (!(_teachers is null) && _teachers.Count > 0
                && this.dgvTeachers.SelectedRows.Count > 0)
            {
                try
                {
                    this.UpdatedSubject = await SubjectHttpService
                        .UpdateAssignedTeacher(_subject.Id, this._selectedTeacher.Id);

                    this.SubjectIsAssigned = true;

                    //Ventanita de mensaje de éxito
                    string message = string.Format("{0} es ahora profesor de {1}.",
                        _selectedTeacher.FullName, _subject.Name);
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
        ///     Evento al pulsar Retirar asignación:
        ///     Envia al cliente http el id de la asignatura seleccionada para que se le retire
        ///     la asignación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonRemoveAssignment_Click(object sender, EventArgs e)
        {

            //El cliente http retorna la asignatura sin profesor asignado
            this.UpdatedSubject = await SubjectHttpService
            .RemoveTeacherAssignment(_subject.Id);
            this.SubjectIsAssigned = false;

            //Ventanita de mensaje de éxito
            string message = string
                .Format("{0} ha dejado de tener un profesor asignado.", _subject.Name);
            new CustomSuccesMessageWindow(message,0).ShowDialog();
            this.Close();

        }

        /// <summary>
        ///     Evento al cargar este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AssignTeacherForm_Load(object sender, EventArgs e)
        {
            this.SetLabels();
            this.SetDataGridViewTeachers();
            await this.GetAllTeachers();
            PopulateTeachersTable();
        }

        /// <summary>
        ///     Evento al pulsar Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SubjectIsAssigned = false;
            UpdatedSubject = null;
            this.Close();
        }
    }
}

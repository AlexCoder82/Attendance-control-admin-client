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
        private Subject _subject;//La asignatura recibida por referencia
        private List<Teacher> teachers; //La lista de todos los profesores
        private Teacher selectedTeacher;//El profesor seleccionado en la tabla

        public AssignTeacherForm(Subject subject)
        {
            this._subject = subject;
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        ///     Evento al cargar este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AssignTeacherForm_Load(object sender, EventArgs e)
        {

            this.SetTitle();
            this.SetToolTips();
            this.SetDataGridViewTeachers();
            await this.GetAllTeachers();
            PopulateTeachersTable();

        }

        /// <summary>
        ///     Rellena los distintos labels con el nombre de la asignatura
        ///     y el nombre del profesor asignado hasta ahora
        /// </summary>
        private void SetTitle()
        {

            this.groupBox.Text = "Nuevo profesor de "+ this._subject.Name;
           
        }

        private void SetToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.buttonAssign, "Asignar profesor");
        }

        /// <summary>
        ///     Establece diseño de la cabezera de la tabla.
        /// </summary>
        private void SetDataGridViewTeachers()
        {

            this.dgvTeachers.Columns[2].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTeachers.Columns[1].HeaderCell.Style.Alignment = 
                    DataGridViewContentAlignment.MiddleLeft;
            this.dgvTeachers.Columns[1].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;

        }

        /// <summary>
        ///     Rellena la tabla de los profesores
        /// </summary>
        private void PopulateTeachersTable()
        {
            this.dgvTeachers.ClearSelection();

            //Si hay al menos un profesor, se rellena la tabla
            if (!(this.teachers is null) && this.teachers.Count > 0)
            {
                this.teachers.ForEach(t =>
                {
                    this.dgvTeachers.Rows.Add(t.Id, t.Dni, t.FullName);
                });             
            }
            //Si no hay profesores se rellena la tabla con 5 registros vacíos
            if ((this.teachers is null) )
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvTeachers.Rows.Add();
                }
            }
            //sy hay menos de 7 profesores se rellena los huecos hasta 7 registros
            if ((this.teachers != null) || this.teachers.Count < 7)
            {
                for (int i = this.teachers.Count; i < 7; i++)
                {
                    this.dgvTeachers.Rows.Add();
                }
            }

            
    
        }

        /// <summary>
        ///     Recibe la lista de todos los profesores del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllTeachers()
        {
            try
            {
                teachers = await TeacherHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
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
            if (this.dgvTeachers.SelectedRows[0].Cells[0].Value != null)
            {
                try
                {
                    //Recupera el Id del profesor seleccionado
                    int selectedId = int
                        .Parse(this.dgvTeachers.SelectedRows[0].Cells[0].Value
                        .ToString());

                    //Recupera el profesor seleccionado y lo guarda en la proprieda de clase
                    this.selectedTeacher = this.teachers
                            .FirstOrDefault(c => c.Id == selectedId);

                    //El cliente http retorna la asignatura actualizada
                    Subject subject = await SubjectHttpService
                        .UpdateAssignedTeacher(this._subject.Id, this.selectedTeacher.Id);

                    this._subject.Teacher = subject.Teacher;

                    //Ventanita de mensaje de éxito
                    string message = string.Format("{0} es ahora el profesor de {1}.",
                        selectedTeacher.FullName, this._subject.Name);
                    new CustomSuccesMessageWindow(message).ShowDialog();
                    this.Close();
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un profesor antes.")
                    .ShowDialog();
            }
            
        }
       
    }
}

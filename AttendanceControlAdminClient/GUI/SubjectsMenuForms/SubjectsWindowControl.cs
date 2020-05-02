using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.GUI.SubjectsMenuForms
{
    public partial class SubjectsWindowControl : UserControl
    {
        private List<Subject> subjects;//Lista de todas las asignaturas
        private Subject selectedSubject;
        public SubjectsWindowControl()
        {
            InitializeComponent();
        }


        /// <summary>
        ///     Evento al cargar este formulario:  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SubjectsWindowControl_Load(object sender, EventArgs e)
        {
            this.SetSubjectsDataGridView();
            this.SetIconsToolTips();
            await this.GetAllSubjects();
            this.PopulateSubjectsTable("");
        }

        /// <summary>
        ///     Establece una anchura automática
        ///     a la columna del nombre de las asignaturas
        /// </summary>
        private void SetSubjectsDataGridView()
        {
            this.dgvSubjects.Columns[1].Width = 300;
            this.dgvSubjects.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSubjects.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvSubjects.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void SetIconsToolTips()
        {

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.buttonAdd, "Crear una nueva asignatura");
            toolTip.SetToolTip(this.buttonModify, "Modificar asignatura");
            toolTip.SetToolTip(this.buttonAsignTeacher, "Asignar un profesor");
            toolTip.SetToolTip(this.buttonRemoveTeacher, "Retirar la asignación");

        }

        /// <summary>
        ///     Recibe la lista de asignaturas del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllSubjects()
        {
            try
            {
                subjects = await SubjectHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Rellena la tabla de asignaturas con las asignaturas cuyo nombre empieze
        ///     por la cadena recibida en parametro
        /// </summary>
        private void PopulateSubjectsTable(string subjectName)
        {
            this.dgvSubjects.Rows.Clear();

            //Se retira el evento de selección por defecto
            this.dgvSubjects.SelectionChanged -=
                   new EventHandler(DataGridViewSubjects_SelectionChanged);

            subjectName = subjectName.TrimStart();
            int length = subjectName.Length;

            //Si existen asignaturas 
            if (!(subjects is null) && subjects.Count > 0)
            {
                subjects.ForEach(s =>
                {
                    //Si el nombre corresponde
                    if (s.Name.Length >= length
                        && subjectName.Equals(s.Name.Substring(0, length),
                            StringComparison.InvariantCultureIgnoreCase))
                    {
                        //Si la asignatura no esta asignada a ningún profesor
                        if (s.Teacher is null)
                        {
                            this.dgvSubjects.Rows.Add(s.Id, s.Name, "Sin asignar");
                        }
                        else
                        {
                            string teacherFullName = String
                            .Format("{0} {1} {2}", s.Teacher.FirstName,
                                s.Teacher.LastName1, s.Teacher.LastName2);

                            this.dgvSubjects.Rows.Add(s.Id, s.Name, teacherFullName);
                        }
                    }
                });
            }

            //Si se ha agregado al menos una asignatura a la tabla
            //se activa el evento de selección
            if (this.dgvSubjects.Rows.Count > 0)
            {
                this.dgvSubjects.SelectionChanged +=
                    new EventHandler(DataGridViewSubjects_SelectionChanged);

            }

            //Si no sa recibido asignaturas del cliente http, se rellena
            //la tabla con 5 registros vacíos
            if ((subjects is null) || subjects.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvSubjects.Rows.Add();
                }
            }

            this.dgvSubjects.ClearSelection();
            this.buttonAsignTeacher.Visible = false;
            this.buttonModify.Visible = false;
        }



        /// <summary>
        ///     Evento al escribir el nombre de la asignatura en el textbox:
        ///     Se vuelve a rellenar la tabla 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxSubject_TextChanged(object sender, EventArgs e)
        {
            this.PopulateSubjectsTable(this.tbSubject.Text);
        }



        /// <summary>
        ///     Selecciona el registro de la tabla cuyo valor de la celda "id" corresponda
        ///     al Id de la asignatura pasado en parámetro. De paso desplaza el scroll de la
        ///     tabla para que el registro seleccionado aparezca centrado.
        /// </summary>
        /// <param name="subjectId"></param>
        private void SetDataGridViewSubjectsSelectedRow(int subjectId)
        {
            //Recupero el registro de la asignatura
            DataGridViewRow row = this.dgvSubjects.Rows
            .Cast<DataGridViewRow>()
                 .FirstOrDefault(r => r.Cells[0].Value.ToString().Equals(subjectId.ToString()));

            int index = row.Index;
            this.dgvSubjects.Rows[index].Selected = true;
            this.dgvSubjects.FirstDisplayedScrollingRowIndex = this.dgvSubjects.SelectedRows[0].Index;

        }

        /// <summary>
        ///     Evento al seleccionar una asignatura de la tabla:
        ///     Se habilitan los botones para modificar la asignatura 
        ///     y asignarle un profesor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewSubjects_SelectionChanged(object sender, EventArgs e)
        {
            if (!(subjects is null) && subjects.Count > 0
                && this.dgvSubjects.SelectedRows.Count > 0)
            {
                int id = (int)this.dgvSubjects.SelectedRows[0].Cells[0].Value;
                this.selectedSubject = subjects.Find(s => s.Id == id);
                if (selectedSubject.Teacher is null)
                {
                    this.buttonAsignTeacher.Visible = true;
                    this.buttonRemoveTeacher.Visible = false;
                }
                else
                {
                    this.buttonAsignTeacher.Visible = false;
                    this.buttonRemoveTeacher.Visible = true;
                }

                this.buttonModify.Visible = true;
            }

        }


        /// <summary>
        ///     Evento al pulsar Añadir asignatura:
        ///     Se instancia el formulario para crear una asignatura y
        ///     se recupera la asignatura creada para agregarla a la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddSubject_Click(object sender, EventArgs e)
        {
            //Formulario para crear la asignatura
            CreateSubjectForm csForm = new CreateSubjectForm();
            csForm.ShowDialog();

            //Al cerrarse la ventana, se recupera la nueva asignatura creada
            Subject createdSubject = csForm.CreatedSubject;

            //Si existe
            if (!(createdSubject is null))
            {
                //Se agrega a la lista
                subjects.Add(createdSubject);
                //Ordeno la lista
                subjects = this.subjects.OrderBy(s => s.Name).ToList();

                //Pongo el nombre de la nueva asignatura en el combobox para disparar el evento
                //y asi mostrar la nueva asignatura
                this.tbSubject.Text = createdSubject.Name;

                //Selecciona en la tabla la nueva asignatura creada
                this.SetDataGridViewSubjectsSelectedRow(createdSubject.Id);
            }
        }

        /// <summary>
        ///     Evento al pulsar el botón Modificar asignatura:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifySubject_Click(object sender, EventArgs e)
        {
            if (!(subjects is null) && subjects.Count > 0
                && this.dgvSubjects.SelectedRows.Count > 0)
            {
                //Recupera el Id de la asignatura seleccionada
                int selectedId = int
                .Parse(this.dgvSubjects.SelectedRows[0].Cells[0].Value
                .ToString());

                //Recupera la asignatura
                Subject subject = subjects
                    .FirstOrDefault(c => c.Id == selectedId);

                //Se instancia el formulario para modificar la asignatura
                //y se le pasa la asignatura seleccionada como parametro
                ModifySubjectForm mdForm = new ModifySubjectForm(subject);
                mdForm.ShowDialog();

                //Al cerrarse la ventana, se recupera la asignatura actualizada
                Subject updatedSubject = mdForm.UpdatedSubject;

                //Si existe
                if (!(updatedSubject is null))
                {
                    //La asignatura original pasa a ser la asignatura actualizada
                    subject = updatedSubject;

                    //Refresca el nombre en la tabla
                    this.dgvSubjects.SelectedRows[0].Cells[1].Value = subject.Name;
                }
            }
        }

        /// <summary>
        ///     Evento al pulsar Asignar:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAssign_Click(object sender, EventArgs e)
        {
            
            //Se instancia el formulario para asignar la asignatura a un profesor
            //y se le pasa la asignatura seleccionada como parametro
            AssignTeacherForm assignTeacherForm = new AssignTeacherForm(this.selectedSubject);
            assignTeacherForm.ShowDialog();

            //Si ha sido asignado a un nuevo profesor se actualiza la tabla y las opciones
            if (!(this.selectedSubject.Teacher is null))
            {
                this.dgvSubjects.SelectedRows[0].Cells[2].Value = this.selectedSubject.Teacher.FullName;
                this.buttonAsignTeacher.Visible = false;
                this.buttonRemoveTeacher.Visible = true;
            }
            
        }

        /// <summary>
        ///     Evento al pulsar Retirar asignación:
        ///     Envia al cliente http el id de la asignatura seleccionada para que se le retire
        ///     la asignación de profesor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonRemoveTeacher_Click(object sender, EventArgs e)
        {

            string message = string
                .Format("Si retiras la asignación del profesor {0}, todas las " +
                "clases de la asignatura {1} quedarán canceladas.¿Estas seguro " +
                "de querer retirar la asignación?",
                this.selectedSubject.Teacher.FullName,
                this.selectedSubject.Name);

            //Ventanita de confirmación
            CustomConfirmDialogForm dialog = new CustomConfirmDialogForm(message);
            dialog.ShowDialog();

            if (dialog.Confirmed)
            {
                try
                {
                    await SubjectHttpService
                               .RemoveTeacherAssignment(this.selectedSubject.Id);

                    this.selectedSubject.Teacher = null;
                    //Actualiza la tabla y las opciones
                    this.dgvSubjects.SelectedRows[0].Cells[2].Value = "Sin asignar";
                    this.buttonAsignTeacher.Visible = true;
                    this.buttonRemoveTeacher.Visible = false;

                    //Ventanita de mensaje de éxito
                    message = string
                       .Format("La asignatura {0} ya no tiene profesor asignado y las" +
                       "clases han sido cancelada.",
                       this.selectedSubject.Name);

                    new CustomSuccesMessageWindow(message, 0).ShowDialog();

                   
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }
            }

        }

    }
}

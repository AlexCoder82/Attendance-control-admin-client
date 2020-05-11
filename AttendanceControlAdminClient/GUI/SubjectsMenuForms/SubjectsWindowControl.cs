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
        ///     Evento Load del formulario:  
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
        ///     Establece una anchura a las columnas de la tabla
        /// </summary>
        private void SetSubjectsDataGridView()
        {
            this.dgvSubjects.Columns[1].Width = 300;
            this.dgvSubjects.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSubjects.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvSubjects.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

        }

        /// <summary>
        ///     Establece los tooltips de los iconos
        /// </summary>
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

            int totalTableSubjects = 0;

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

                        //Suma una asignatura en la tabla
                        totalTableSubjects++;
                    }
                });
            }


            //Si no sa recibido asignaturas del cliente http, se rellena
            //la tabla con 5 registros vacíos
            if ((subjects is null))
            {
                for (int i = 0; i < 7; i++)
                {
                    this.dgvSubjects.Rows.Add();
                }
            }
            if (!(subjects is null) || totalTableSubjects < 7)
            {
                int last = totalTableSubjects;
                for (int i = last; i < 7; i++)
                {
                    this.dgvSubjects.Rows.Add();
                }
            }

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
        ///     Evento al pulsar Añadir asignatura:
        ///     Se instancia el formulario para crear una asignatura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddSubject_Click(object sender, EventArgs e)
        {

            //Formulario para crear la asignatura
            CreateSubjectForm form = new CreateSubjectForm();
            form.OnCreatedSubjectDelegate += OnCreatedSubjectCallBack;
            form.ShowDialog();

        }

        private void OnCreatedSubjectCallBack(Subject subject)
        {

            //Se agrega a la lista
            subjects.Add(subject);
            //Ordena la lista
            subjects = this.subjects.OrderBy(s => s.Name).ToList();
            //Pongo el nombre de la nueva asignatura en el textBox y lleno la tabla de nuevo
            this.tbSubject.Text = subject.Name;
            this.PopulateSubjectsTable(subject.Name);

        }

        /// <summary>
        ///     Evento al pulsar el botón Modificar asignatura:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnModifySubject_Click(object sender, EventArgs e)
        {

            if (this.dgvSubjects.SelectedRows[0].Cells[0].Value != null)
            {
                //Recupera el Id de la asignatura seleccionada
                int selectedId = int
                .Parse(this.dgvSubjects.SelectedRows[0].Cells[0].Value
                .ToString());

                //Recupera la asignatura de la lista
                Subject subject = subjects
                    .FirstOrDefault(c => c.Id == selectedId);

                //Se instancia el formulario para modificar la asignatura
                //y se le pasa la asignatura seleccionada como parametro
                ModifySubjectForm form = new ModifySubjectForm(subject);
                form.OnUpdatedSubjectDelegate += OnUpdatedSubjectCallBack;
                form.ShowDialog();
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar una asignatura antes.")
                    .ShowDialog();
            }

        }

        /// <summary>
        ///     Callback de la asignatura modificada
        /// </summary>
        /// <param name="subject"></param>
        private void OnUpdatedSubjectCallBack(Subject subject)
        {

            //La asignatura original pasa a ser la asignatura actualizada
            this.selectedSubject = subject;
            //Refresca el nombre en la tabla
            this.dgvSubjects.SelectedRows[0].Cells[1].Value = subject.Name;

        }

        /// <summary>
        ///     Evento al pulsar Asignar:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAssign_Click(object sender, EventArgs e)
        {
            if (this.dgvSubjects.SelectedRows[0].Cells[0].Value != null)
            {
                int id = (int)this.dgvSubjects.SelectedRows[0].Cells[0].Value;
                this.selectedSubject = subjects.Find(s => s.Id == id);

                //Si no tiene profesor asignado, se abre la ventana de asignacion
                if (this.selectedSubject.Teacher is null)
                {
                    //Se instancia el formulario para asignar la asignatura a un profesor
                    //y se le pasa la asignatura seleccionada como parametro 
                    AssignTeacherForm form = new AssignTeacherForm(this.selectedSubject);
                    form.OnNewAssignedTeacherDelegate += OnNewAssignedTeacherCallback;
                    form.ShowDialog();
                }
                else
                {
                    new CustomErrorMessageWindow("La asignatura " + this.selectedSubject.Name + " ya tiene un profesor asignado.")
                        .ShowDialog();
                }

            }
            else if (this.dgvSubjects.SelectedRows[0].Cells[0].Value is null)
            {
                new CustomErrorMessageWindow("Debes seleccionar una asignatura antes.")
                    .ShowDialog();
            }

        }

        //Callback con la asignatura actualizada si se asigna un nuevo profesor
        private void OnNewAssignedTeacherCallback(Subject subject)
        {

            this.selectedSubject.Teacher = subject.Teacher;
            //Actualiza la tabla
            this.dgvSubjects.SelectedRows[0].Cells[2].Value = this.selectedSubject.Teacher.FullName;

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

            if (this.dgvSubjects.SelectedRows[0].Cells[0].Value != null)
            {
                int id = (int)this.dgvSubjects.SelectedRows[0].Cells[0].Value;
                this.selectedSubject = subjects.Find(s => s.Id == id);

                if (this.selectedSubject.Teacher != null)
                {
                    string message = string
                        .Format("Si retiras la asignación del profesor {0}, todas las " +
                        "clases de {1} quedarán canceladas.¿Estas seguro " +
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
                            //Actualiza la tabla 
                            this.dgvSubjects.SelectedRows[0].Cells[2].Value = "Sin asignar";

                            //Ventanita de mensaje de éxito
                            message = string
                               .Format("La asignatura {0} ya no tiene profesor asignado y las" +
                               " clases han sido canceladash.",
                               this.selectedSubject.Name);

                            new CustomSuccesMessageWindow(message).ShowDialog();

                        }
                        catch (ServerErrorException ex)
                        {
                            new CustomErrorMessageWindow(ex.Message).ShowDialog();
                        }
                    }
                }
                else
                {
                    new CustomErrorMessageWindow("La asignatura " + this.selectedSubject.Name + " no tiene profesor asignado.")
                        .ShowDialog();
                }
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar una asignatura antes.")
                    .ShowDialog();
            }

        }

    }
}

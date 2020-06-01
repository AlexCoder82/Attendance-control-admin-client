using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;


namespace AttendanceControlAdminClient.GUI.TeachersMenuForms
{
    /// <summary>
    ///     Menu profesores
    /// </summary>
    public partial class TeachersWindowControl : UserControl
    {

        private List<Teacher> teachers;//Lista de profesores
        private Teacher selectedTeacher;//El profesor seleccionado

        public TeachersWindowControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Evento Load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void TeachersWindowControl_Load(object sender, EventArgs e)
        {

            this.SetDataGridViewTeachers();
            this.SetToolTips();
            await this.GetAllTeachers();
            this.PopulateDataGridViewTeachers("");

        }

        /// <summary>
        ///     Establece los tooltips de los iconos
        /// </summary>
        private void SetToolTips()
        {

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.buttonAdd, "Nuevo profesor");
            toolTip.SetToolTip(this.buttonModify, "Modificar datos personales");

        }

        /// <summary>
        ///     Establece medidas de la tabla de profesores
        /// </summary>
        private void SetDataGridViewTeachers()
        {

            this.dgvTeachers.Columns[1].Width = 150;
            this.dgvTeachers.Columns[1].Resizable = DataGridViewTriState.False;
            this.dgvTeachers.Columns[1].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleLeft;

            this.dgvTeachers.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTeachers.Columns[2].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            this.dgvTeachers.Columns[3].Width = 200;
            this.dgvTeachers.Columns[3].Resizable = DataGridViewTriState.False;
            this.dgvTeachers.Columns[3].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

        }

        /// <summary>
        ///     Recibe la lista de profesores del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllTeachers()
        {

            try
            {
                this.teachers = await TeacherHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Rellena la tabla de profesores con los profesores cuyo
        ///     apellido empieze por la cadena pasada por parametro
        /// </summary>
        /// <param name="lastName"></param>
        private void PopulateDataGridViewTeachers(string lastName)
        {

            this.dgvTeachers.Rows.Clear();
            int totalTableTeachers = 0;

            lastName = lastName.TrimStart();
            int length = lastName.Length;

            if (!(teachers is null) && teachers.Count > 0)
            {
                teachers.ForEach(t =>
                {
                    if (t.LastName1.Length >= length && lastName
                        .Equals(t.LastName1.Substring(0, length),
                        StringComparison.InvariantCultureIgnoreCase))
                    {
                        this.dgvTeachers.Rows.Add(t.Id, t.Dni,
                            t.LastName1 + " " + t.LastName2, t.FirstName);

                        //Se suma un profesor en la tabla
                        totalTableTeachers++;
                    }

                });
            }

            //Si no hay profesores, se crea 5 registros vacios
            if ((teachers is null))
            {
                for (int i = 0; i < 7; i++)
                {
                    this.dgvTeachers.Rows.Add();
                }
            }
            //Se rellena el resto de la tabla
            if ((teachers != null) || totalTableTeachers < 7)
            {
                for (int i = totalTableTeachers; i < 7; i++)
                {
                    this.dgvTeachers.Rows.Add();
                }
            }

        }


        /// <summary>
        ///     Evento al pulsar el botón Dar alta:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCreate_Click(object sender, EventArgs e)
        {

            //Instancia el formulario de alta de profesor
            CreateTeacherForm form = new CreateTeacherForm();
            form.OnTeacherCreatedDelegate += OnTeacherCreatedCallBack;
            form.ShowDialog();

        }

        /// <summary>
        ///         Callback con el profesor creado
        /// </summary>
        /// <param name="teacher"></param>
        private void OnTeacherCreatedCallBack(Teacher teacher)
        {
            //Se agrega a la lista
            teachers.Add(teacher);
            //Ordena la lista
            teachers = teachers
                .OrderBy(s => s.FirstName).ToList();
            //Escribe el apellido del nuevo profesor en el textbox
            //para disparar el evento y asi aparezca el registro en la tabla
            this.tbLastName.Text = "";
            this.SortTable();
            this.SelectLastCreatedTeacher(teacher.Id);

        }

        /// <summary>
        ///     Ordena la tabla de profesores por apellidos 
        /// </summary>
        private void SortTable()
        {

            this.teachers = this.teachers.OrderBy(t => t.LastName1).ToList();
            this.PopulateDataGridViewTeachers("");

        }

        /// <summary>
        ///     Al crear un nuevo ciclo, lo selecciona automaticamente en la tabla
        /// </summary>
        /// <param name="cycleId"></param>
        private void SelectLastCreatedTeacher(int teacherId)
        {

            DataGridViewRow row = dgvTeachers.Rows
                .Cast<DataGridViewRow>()
                .Where(r => ((int)(r.Cells[0].Value)).Equals(teacherId))
                .First();

            this.dgvTeachers.ClearSelection();
            this.dgvTeachers.Rows[row.Index].Selected = true; ;
            this.dgvTeachers.FirstDisplayedScrollingRowIndex = dgvTeachers.SelectedRows[0].Index;
        }


        /// <summary>
        ///     Evento al pulsar Modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if (this.dgvTeachers.SelectedRows[0].Cells[0].Value != null)
            {

                // Recupera el Id del profesor seleccionado
                int selectedId = int
                    .Parse(this.dgvTeachers.SelectedRows[0].Cells[0].Value
                        .ToString());

                //Recupera el profesor
                this.selectedTeacher = this.teachers
                    .FirstOrDefault(t => t.Id == selectedId);

                //Instancia el formulario de modificacion de los datos del profesor
                ModifyTeacherForm form = new ModifyTeacherForm(this.selectedTeacher);
                form.OnTeacherUpdatedDelegate += OnTeacherUpdatedCallBack;
                form.ShowDialog();
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar un profesor antes.")
                    .ShowDialog();
            }

        }

        /// <summary>
        ///     Callback con el profesor actualizado
        /// </summary>
        /// <param name="teacher"></param>
        private void OnTeacherUpdatedCallBack(Teacher teacher)
        {

            //El profesor original pasa a ser el profesor actualizado
            this.selectedTeacher.Id = teacher.Id;
            this.selectedTeacher.Dni = teacher.Dni;
            this.selectedTeacher.FirstName = teacher.FirstName;
            this.selectedTeacher.LastName1 = teacher.LastName1;
            this.selectedTeacher.LastName2 = teacher.LastName2;

            this.tbLastName.Text = teacher.LastName1;
            this.SortTable();

        }



        /// <summary>
        ///     Evento al modificar el textbox:
        ///     Rellena al tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbLastName_TextChanged(object sender, EventArgs e)
        {

            this.PopulateDataGridViewTeachers(this.tbLastName.Text);

        }

    }
}

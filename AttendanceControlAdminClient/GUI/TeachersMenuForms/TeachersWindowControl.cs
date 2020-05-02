using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;

namespace AttendanceControlAdminClient.GUI.TeachersMenuForms
{
    public partial class TeachersWindowControl : UserControl
    {
        private List<Teacher> _teachers;

        public TeachersWindowControl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Evento al cargar este formulario
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

        private void SetToolTips()
        {

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.buttonAdd, "Alta de un profesor");
            toolTip.SetToolTip(this.buttonModify, "Modificar datos del profesor");

        }
        /// <summary>
        ///     Establece medidas y opciones de la tabla de profesores
        /// </summary>
        private void SetDataGridViewTeachers()
        {
            this.dgvTeachers.Columns[1].Width = 100;
            this.dgvTeachers.Columns[1].Resizable = DataGridViewTriState.False;
            this.dgvTeachers.Columns[2].Width = 200;
            this.dgvTeachers.Columns[2].Resizable = DataGridViewTriState.False;
            this.dgvTeachers.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvTeachers.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            this.dgvTeachers.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        /// <summary>
        ///     Recibe la lista de profesores del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllTeachers()
        {
            try
            {
                this._teachers = await TeacherHttpService.GetAll();
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

            //Retira el evento de seleccion por defecto
            this.dgvTeachers.SelectionChanged -=
                new System.EventHandler(this.DataGridViewTeachers_SelectionChanged);

            lastName = lastName.TrimStart();
            int length = lastName.Length;

            if (!(_teachers is null) && _teachers.Count > 0)
            {
                _teachers.ForEach(t =>
                {
                    if (t.LastName1.Length >= length && lastName
                        .Equals(t.LastName1.Substring(0, length),
                        StringComparison.InvariantCultureIgnoreCase))
                    {
                        this.dgvTeachers.Rows.Add(t.Id, t.Dni, t.FirstName,
                            t.LastName1 + " " + t.LastName2);

                    }
                });
            }

            //Si hay al menos un profesor en la tabla, habilita el evento de seleccion
            if (this.dgvTeachers.Rows.Count > 0)
            {
                this.dgvTeachers.SelectionChanged += new System.EventHandler(this.DataGridViewTeachers_SelectionChanged);
            }

            //Si no hay profesores, se crear 5 registros vacios
            if ((_teachers is null) || _teachers.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvTeachers.Rows.Add();
                }
            }

            this.dgvTeachers.ClearSelection();
            this.buttonModify.Visible = false;

        }

        /// <summary>
        ///     Evento al seleccionar un profesor en la tabla:
        ///     Habilita el botón para modificar los datos
        ///     del profesor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (!(_teachers is null) && _teachers.Count > 0
                && this.dgvTeachers.SelectedRows.Count > 0)
            {
                this.buttonModify.Visible = true;
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
            CreateTeacherForm ctForm = new CreateTeacherForm();
            ctForm.ShowDialog();

            //Al cerrarse el formulario, se recupera el profesor creado
            Teacher createdTeacher = ctForm.CreatedTeacher;

            //Si existe
            if (!(createdTeacher is null))
            {
                //Se agrega a la lista
                _teachers.Add(createdTeacher);
                //Ordena la lista
                _teachers = _teachers
                    .OrderBy(s => s.FirstName).ToList();
                //Escribe el apellido del nuevo profesor en el textbox
                //para disparar el evento y asi aparezca el registro en la tabla
                this.tbLastName.Text = createdTeacher.LastName1;

                this.SetDataGridViewTeachersSelectedRow(createdTeacher.Id);
            }
        }

        /// <summary>
        ///     Selecciona en la tabla el profesor 
        ///     con el id pasado por parametro y centra el scroll
        ///     en el registro
        /// </summary>
        /// <param name="teacherId"></param>
        private void SetDataGridViewTeachersSelectedRow(int teacherId)
        {
            try
            {
                //Recupero el registro de la asignatura
                DataGridViewRow row = this.dgvTeachers.Rows
                .Cast<DataGridViewRow>()
                     .FirstOrDefault(r => r.Cells[0].Value.ToString()
                     .Equals(teacherId.ToString()));

                int index = row.Index;
                this.dgvTeachers.Rows[index].Selected = true;
                this.dgvTeachers.FirstDisplayedScrollingRowIndex =
                    this.dgvTeachers.SelectedRows[0].Index;
            }
            catch (Exception ex)
            {

            }
        }


        /// <summary>
        ///     Evento al pulsar Modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModify_Click(object sender, EventArgs e)
        {
            if (this.dgvTeachers.SelectedRows.Count > 0)
            {

                // Recupera el Id del profesor seleccionado
                int selectedId = int
                    .Parse(this.dgvTeachers.SelectedRows[0].Cells[0].Value
                        .ToString());

                //Recupera el profesor
                Teacher teacher = this._teachers
                    .FirstOrDefault(c => c.Id == selectedId);

                //Instancia el formulario de modificacion de los datos del profesor
                ModifyTeacherForm modifyTeacherForm = new ModifyTeacherForm(teacher);
                modifyTeacherForm.ShowDialog();

                // Al cerrarse la ventana, se recupera el profesor actualizado
                Teacher updatedTeacher = modifyTeacherForm.UpdatedTeacher;

                //Si existe
                if (!(updatedTeacher is null))
                {
                    //El profesor original pasa a ser el profesor actualizado
                    teacher = updatedTeacher;
                    //Actualiza el registro de la tabla
                    this.dgvTeachers.SelectedRows[0].Cells[1].Value = teacher.Dni;
                    this.dgvTeachers.SelectedRows[0].Cells[2].Value = teacher.FirstName;
                    this.dgvTeachers.SelectedRows[0].Cells[3].Value = teacher.LastName1 
                        + " " + teacher.LastName2;

                }
            }
        }

        

        /// <summary>
        ///     Evento al modificar el textbox:
        ///     Rellena al tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            this.PopulateDataGridViewTeachers(this.tbLastName.Text);
        }

    }
}

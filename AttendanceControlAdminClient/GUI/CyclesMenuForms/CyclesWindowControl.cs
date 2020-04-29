using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    public partial class CyclesWindowControl : UserControl
    {
        private List<Cycle> _cycles;//Lista donde se guarda los ciclos recibidos del servidor
        private Cycle _selectedCycle;//Ciclo seleccionado en la tabla de ciclos
        private Course _selectedCourse;//Curso seleccionado en el comboBox

        public CyclesWindowControl()
        {
            InitializeComponent();

            //this.ButtonModifyCycle.Enabled = false;
        }

        /// <summary>
        ///     Establece una anchura automática
        ///     a las columnas de cada tabla
        /// </summary>
        private void SetDataGridViews()
        {
            this.dgvCycles.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSubjects1.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

        }

        /// <summary>
        ///     Recibe la lista de ciclos del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllCycles()
        {
            try
            {
                _cycles = await CycleHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Rellena la tabla de ciclos, en caso de que no haya ciclos, 
        ///     crea 5 registros vacíos por defectos
        /// </summary>
        private void PopulateCyclesTable()
        {
            this.dgvCycles.Rows.Clear();

            //Si hay ciclos 
            if (!(this._cycles is null) && this._cycles.Count > 0)
            {
                this._cycles.ForEach(c =>
                {
                    this.dgvCycles.Rows.Add(c.Id, c.Name);
                });
                //si hay al menos una asignatura, se instancia el evento de selección
                this.dgvCycles.SelectionChanged +=
                    new EventHandler(DataGridViewCycles_SelectionChanged);

            }
            //si la lista es nula o no hay ciclos
            if ((this._cycles is null) || this._cycles.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvCycles.Rows.Add();
                }
                //si no hay al menos un ciclo, se retira el evento de selección
                this.dgvCycles.SelectionChanged -=
                    new EventHandler(DataGridViewCycles_SelectionChanged);
            }

            this.dgvCycles.ClearSelection();
            this.btnModifyCycle.Enabled = false;
            this.btnRemoveSubject1.Enabled = false;
            this.btnAddSubject1.Enabled = false;

        }

        /// <summary>
        ///     Rellena la tabla de asignaturas del primer curso, 
        ///     en caso de que no haya ciclos, 
        ///     crea 5 registros vacíos por defectos
        /// </summary>
        private void PopulateCourseSubjectsTable()
        {
            this.dgvSubjects1.Rows.Clear();
            if (!(_selectedCourse is null) && !(_selectedCourse.Subjects is null) && _selectedCourse.Subjects.Count > 0)
            {
                _selectedCourse.Subjects.ForEach(s =>
                {
                    this.dgvSubjects1.Rows.Add(s.Id, s.Name);
                });
                //si hay al menos una asignatura, se instancia el evento de selección
                this.dgvSubjects1.SelectionChanged +=
                    new EventHandler(DataGridViewSubjects1_SelectionChanged);

            }

            this.dgvSubjects1.ClearSelection();
            this.btnRemoveSubject1.Enabled = false;
            this.btnAddSubject1.Enabled = true;

        }




        /// <summary>
        ///     Rellena el comboBox de cursos
        /// </summary>
        private void PopulateCoursesComboBoxes()
        {

            this.CbCourses.DataSource = _selectedCycle.Courses;
            this.CbCourses.DisplayMember = "Year";
            this.CbCourses.ValueMember = "Id";


            //Establece el mismo evento de seleccion para ambos
            this.CbCourses.SelectedIndexChanged += new EventHandler(CbCourses_SelectedIndexChanged);

            //Provoca el evento para que muestre las asignaturas del primer curso por defecto
            this.CbCourses.SelectedIndex = 1;
            this.CbCourses.SelectedIndex = 0;

        }

        #region EVENTOS DEL FORMULARIO


        /// <summary>
        ///     Evento al crear este formulario:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CyclesWindowControl_Load(object sender, EventArgs e)
        {
            this.SetDataGridViews();
            await this.GetAllCycles();
            this.PopulateCyclesTable();
        }

        /// <summary>
        ///     Evento al seleccionar un registro de la tabla ciclos: Se cargan
        ///     las asignaturas del ciclo seleccionado en las tablas asignaturas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewCycles_SelectionChanged(object sender, EventArgs e)
        {
            if (!(_cycles is null) && _cycles.Count > 0
                && this.dgvCycles.SelectedRows.Count > 0)
            {
                ///Se habilita el botón para modificar un ciclo
                this.btnModifyCycle.Enabled = true;

                //Recupera el Id del ciclo del registro seleccionado
                int selectedId = int
                    .Parse(this.dgvCycles.SelectedRows[0].Cells[0].Value
                    .ToString());

                //Recupera el ciclo seleccionado
                _selectedCycle = this._cycles
                    .FirstOrDefault(c => c.Id == selectedId);







                this.ShowSubjectsOptions();
                this.PopulateCoursesComboBoxes();

            }
        }

        private void ShowSubjectsOptions()
        {
            this.labelCourse.Visible = true;
            this.CbCourses.Visible = true;
            this.dgvSubjects1.Visible = true;
            this.btnAddSubject1.Visible = true;
            this.btnRemoveSubject1.Visible = true;
        }

        /// <summary>
        ///     Evento al seleccionar un registro de la tabla de 
        ///     asignaturas del primer curso:
        ///     Se habilita el botón para borrar la asignatura seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridViewSubjects1_SelectionChanged(object sender, EventArgs e)
        {
            if (!(_selectedCourse is null) && _selectedCourse.Subjects.Count > 0
                && this.dgvSubjects1.SelectedRows.Count > 0)
            {
                this.btnRemoveSubject1.Enabled = true;
            }

        }



        /// <summary>
        ///     Al pulsar añadir , se abre la ventana de creación de ciclo, 
        ///     si al cerrarse existe un ciclo creado, 
        ///     se agrega a la lista y a la tabla de ciclos
        /// </summary>
        /// <param name="sender">
        ///     El botón añadir ciclo
        /// </param>
        /// <param name="e"></param>
        private void ButtonAddCycle_Click(object sender, EventArgs e)
        {
            CreateCycleForm createCycleForm = new CreateCycleForm();
            createCycleForm.ShowDialog();

            //Al cerrarse la ventana, se recupera el nuevo ciclo creado
            Cycle createdCycle = createCycleForm.CreatedCycle;

            //Si existe se agrega
            if (!(createdCycle is null))
            {
                this._cycles.Add(createdCycle);
                this.dgvCycles.Rows.Add(createdCycle.Id, createdCycle.Name);
            }
        }

        /// <summary>
        ///     Evento al pulsar el botón modificar ciclo:
        ///     Se instancia el formulario para modificar los datos 
        ///     del ciclo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModifyCycle_Click(object sender, EventArgs e)
        {
            try
            {
                //Recupera el Id del ciclo seleccionado
                int selectedId = int
                    .Parse(this.dgvCycles.SelectedRows[0].Cells[0].Value
                    .ToString());

                //Recupera el ciclo
                Cycle cycle = this._cycles.FirstOrDefault(c => c.Id == selectedId);

                ModifyCycleForm mcForm = new ModifyCycleForm(cycle);
                mcForm.ShowDialog();

                //Al cerrarse la ventana, se recupera el ciclo modificado
                string updatedName = mcForm.UpdatedName;

                //Si existe se actualiza la lista y la tabla
                if (!(updatedName is null))
                {
                    cycle.Name = updatedName;
                    this.dgvCycles.SelectedRows[0].Cells[1].Value = cycle.Name;
                }
            }
            catch (Exception)
            {
                //En caso de error de selección 

            }

        }

        /// <summary>
        ///     Evento al pulsar el botón Retirar asignatura del primer curso:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonRemoveSubject1_Click(object sender, EventArgs e)
        {
            try
            {

                //Recupera el Id de la asignatura seleccionada
                int selectedId = int
                    .Parse(this.dgvSubjects1.SelectedRows[0].Cells[0].Value.ToString());

                //new CustomDialogForm()
                //Envio el curso copiado al servicio http y este retorna 
                //el curso modificado por el servidor
                bool isRemoved = await CourseHttpService
                    .RemoveAssignedSubject(_selectedCourse.Id, selectedId);
                //Recupero la asignatura de la copia del curso
                Subject subjectToRemove = _selectedCourse.Subjects.FirstOrDefault(s => s.Id == selectedId);

                //Borro la asignatura en la copia del curso
                _selectedCourse.Subjects.Remove(subjectToRemove);

                //Refresca la tabla de asignaturas del primer curso
                this.PopulateCourseSubjectsTable();

                //Ventanita con mensaje de éxito
                string message = string.Format("La asignatura {0} ha sido " +
                    "retirada del primer curso de {1}",
                    subjectToRemove.Name, _selectedCycle.Name);
                new CustomSuccesMessageWindow(message,0).ShowDialog();

            }
            catch (ServerErrorException ex)
            {
                //Ventanita de mensaje de error devuelto por el servidor
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
            catch (Exception)
            {
                //En caso de error de selección 
            }
            finally
            {

            }

        }



        /// <summary>
        ///     Evento al pulsar añadir asignatura al primer curso:
        ///     Se instancia un formulario al que se le pasa 
        ///     el curso para que añada la asignatura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddSubject1_Click(object sender, EventArgs e)
        {
            AssignSubjectForm asForm = new AssignSubjectForm(_selectedCourse, _selectedCycle.Name);
            asForm.ShowDialog();

            //Al cerrarse el formulario, se recupera una copia del curso 
            //con la asignatura añadida
            bool isAssigned = asForm.IsAdded;

            //Si la copia existe
            if (isAssigned)
            {
                //Se refresca la tabla
                this.PopulateCourseSubjectsTable();
            }
        }



        #endregion

        private async void CbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!(_selectedCycle is null) && _selectedCycle.Courses.Count > 0)
            {

                try
                {
                    int id = (int)CbCourses.SelectedValue;
                    _selectedCourse = _selectedCycle.Courses.Find(c => c.Id == id);
                    _selectedCourse.Subjects = await SubjectHttpService.GetByCourse(_selectedCourse.Id);
                    this.PopulateCourseSubjectsTable();
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }


            }

        }
    }
}


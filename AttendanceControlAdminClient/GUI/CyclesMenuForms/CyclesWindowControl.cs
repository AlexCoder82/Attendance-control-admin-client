using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AttendanceControlAdminClient.Models;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using System.Threading.Tasks;
using AttendanceControlAdminClient.Properties;

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
        }

        /// <summary>
        ///     Evento al crear este formulario:
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CyclesWindowControl_Load(object sender, EventArgs e)
        {
            this.SetDataGridViews();
            this.SetIconsToolTips();
            await this.GetAllCycles();
            this.PopulateCyclesTable();
        }

        /// <summary>
        ///     Agrega tooltips a los iconos
        /// </summary>
        private void SetIconsToolTips()
        {

            ToolTip toolTip = new ToolTip();
            toolTip.ForeColor = Settings.Default.OPTIMA_COLOR;
            toolTip.SetToolTip(this.buttonAdd, "Crear nuevo ciclo");
            toolTip.SetToolTip(this.buttonAddSubject, "Añadir una asignatura");
            toolTip.SetToolTip(this.buttonModify, "Modificar");
            toolTip.SetToolTip(this.buttonRemoveSubject, "Retirar asignatura");

        }

        /// <summary>
        ///     Establece una anchura automática
        ///     a las columnas de cada tabla
        /// </summary>
        private void SetDataGridViews()
        {
            this.dgvCycles.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCycles.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvCycles.Columns[2].Width = 120;
            this.dgvSubjects1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCycles.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

        }

        /// <summary>
        ///     Recibe la lista de ciclos del cliente http
        /// </summary>
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
        ///     crea 5 registros vacíos por defectos.
        ///     Método llamado cada vez que se actualiza la lista de ciclos.
        /// </summary>
        private void PopulateCyclesTable()
        {
            this.dgvCycles.Rows.Clear();

            //Si hay ciclos 
            if (!(this._cycles is null) && this._cycles.Count > 0)
            {
                this._cycles.ForEach(c =>
                {
                    this.dgvCycles.Rows.Add(c.Id, c.Name,c.Shift.Description);
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
            this.buttonModify.Visible = false;
            this.buttonRemoveSubject.Visible = false;
            this.buttonAddSubject.Visible = false;

        }

        /// <summary>
        ///     Rellena la tabla de asignaturas del curso seleccionado
        ///     en el comboBox de cursos.
        /// </summary>
        private void PopulateSubjectsTable()
        {
            this.dgvSubjects1.SelectionChanged -=
                    new EventHandler(DataGridViewSubjects_SelectionChanged);
            this.dgvSubjects1.Rows.Clear();
            if (!(_selectedCourse is null) && !(_selectedCourse.Subjects is null) && _selectedCourse.Subjects.Count > 0)
            {
                _selectedCourse.Subjects.ForEach(s =>
                {
                    this.dgvSubjects1.Rows.Add(s.Id, s.Name);
                });
                //si hay al menos una asignatura, se instancia el evento de selección
                this.dgvSubjects1.SelectionChanged +=
                    new EventHandler(DataGridViewSubjects_SelectionChanged);

            }

            //si la lista es nula ,crea 5 registros vacios
            if ((this._selectedCourse.Subjects is null) )
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvSubjects1.Rows.Add();
                }
            }

            //si la lista tiene menos de 5 asignaturas 
            if ((this._selectedCourse.Subjects is null) || this._selectedCourse.Subjects.Count < 5)
            {
                int last = this._selectedCourse.Subjects.Count;
                for (int i =last ; i < 5; i++)
                {
                    this.dgvSubjects1.Rows.Add();
                }
            }
            this.dgvSubjects1.ClearSelection();
            this.buttonRemoveSubject.Visible = false;
            this.buttonAddSubject.Visible = true;

        }




        /// <summary>
        ///     Evento al seleccionar un registro de la tabla ciclos.
        ///     Guarda el ciclo seleccionado en una propriedad de la clase
        ///     y rellena el comboBox de cursos con los cursos del ciclo.
        /// </summary>
        private void DataGridViewCycles_SelectionChanged(object sender, EventArgs e)
        {

            if (!(_cycles is null) && _cycles.Count > 0 && this.dgvCycles.SelectedRows.Count > 0)
            {
                //Recupera el Id del ciclo del registro seleccionado
                int selectedId = int
                    .Parse(this.dgvCycles.SelectedRows[0].Cells[0].Value
                    .ToString());

                //Recupera el ciclo seleccionado
                _selectedCycle = this._cycles
                    .FirstOrDefault(c => c.Id == selectedId);

                ///Se habilita el botón para modificar el ciclo seleccionado
                this.buttonModify.Visible = true;

                this.ShowSubjectsOptions();
                this.PopulateCoursesComboBoxes();
            }

        }

        /// <summary>
        ///     Al pulsar añadir , se abre la ventana de creación de ciclo, 
        ///     si al cerrarse existe un ciclo creado, 
        ///     se agrega a la lista y a la tabla de ciclos
        /// </summary>
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
                this.dgvCycles.Rows.Add(createdCycle.Id, createdCycle.Name,createdCycle.Shift.Description);
            }

        }

        /// <summary>
        ///     Evento al pulsar el botón modificar ciclo:
        ///     Se instancia el formulario para modificar los datos 
        ///     del ciclo seleccionado.
        ///     Si al cerrarse se ha modificado el ciclo, 
        ///     se actualiza el ciclo en la lista y en la tabla.
        /// </summary>
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
               

                //Si existe se actualiza la lista y la tabla
                if (mcForm.Updated)
                {
                    this._selectedCycle = mcForm.UpdatedCycle;
                    this.dgvCycles.SelectedRows[0].Cells[1].Value = cycle.Name;
                    this.dgvCycles.SelectedRows[0].Cells[2].Value = cycle.Shift.Description;
                }
            }
            catch (Exception)
            {
                //En caso de error de selección 

            }

        }

        /// <summary>
        ///     Rellena el comboBox de cursos. 
        ///     Método llamado cada vez que se selecciona un ciclo en la tabla
        ///     de ciclos.
        /// </summary>
        private async void PopulateCoursesComboBoxes()
        {
            //Retira el evento de seleccion hasta 
            this.CbCourses.SelectedIndexChanged -= new EventHandler(CbCourses_SelectedIndexChanged);


            this.CbCourses.DataSource = _selectedCycle.Courses;
            this.CbCourses.DisplayMember = "Year";
            this.CbCourses.ValueMember = "Id";

            //Primer curso por defecto y listo sus asignaturas
            this.CbCourses.SelectedIndex = 0;
            await this.GetSubjects();
            this.PopulateSubjectsTable();

            //Vuelve a poner el evento de seleccion
            this.CbCourses.SelectedIndexChanged += new EventHandler(CbCourses_SelectedIndexChanged);
        }

        /// <summary>
        ///     Muestra las opciones relacionadas a los cursos y asignaturas
        /// </summary>
        private void ShowSubjectsOptions()
        {

            this.labelCourse.Visible = true;
            this.CbCourses.Visible = true;
            this.dgvSubjects1.Visible = true;
            this.buttonAddSubject.Visible = true;

        }


        /// <summary>
        ///     Evento de seleccion del comboBox de cursos.
        ///     Se recibe del cliente http las asignaturas del curso seleccionado y
        ///     se rellena la tabla de asignaturas
        /// </summary>
        private async void CbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!(_selectedCycle is null) && _selectedCycle.Courses.Count > 0)
            {
                try
                {
                    Console.WriteLine("YYYYYYYYYYYYYYYYYYYYYYYYY");
                    await this.GetSubjects();
                    this.PopulateSubjectsTable();
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }
                catch (Exception ex)
                {

                }
            }

        }

        /// <summary>
        ///     Recibe las asignaturas de un curso del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetSubjects()
        {
            int id = (int)CbCourses.SelectedValue;
            _selectedCourse = _selectedCycle.Courses.Find(c => c.Id == id);
            try
            {
                _selectedCourse.Subjects = await SubjectHttpService.GetByCourse(_selectedCourse.Id);
            }catch(ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
            
        }

        /// <summary>
        ///     Evento al seleccionar un registro de la tabla de asignaturas.
        ///     Se habilita el botón para poder borrar la asignatura seleccionada
        /// </summary>
        private void DataGridViewSubjects_SelectionChanged(object sender, EventArgs e)
        {

            if (!(_selectedCourse is null) && _selectedCourse.Subjects.Count > 0
                            && this.dgvSubjects1.SelectedRows.Count > 0)
            {
                this.buttonRemoveSubject.Visible = true;
            }

        }

        /// <summary>
        ///     Evento al pulsar añadir asignatura.
        ///     Se instancia un formulario con el curso seleccionado como
        ///     parametro.
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
                this.PopulateSubjectsTable();
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
                //Recupero la asignatura de la copia del curso
                Subject subject = _selectedCourse.Subjects.FirstOrDefault(s => s.Id == selectedId);


                //Abre dialogo de confirmación
                string message = string.Format("Si retiras la asignatura {0} de {1}º de {2}, " +
                     "se cancelaran todas las clases, ¿Estás seguro de querer retirarla? ",
                     subject.Name, _selectedCourse.Year, _selectedCycle.Name);

                CustomConfirmDialogForm dialog = new CustomConfirmDialogForm(message);
                dialog.ShowDialog();

                //Si se confirma se retira la asignatura
                if (dialog.Confirmed)
                {
                    //Envio el curso copiado al servicio http y este retorna 
                    //el curso modificado por el servidor
                    bool isRemoved = await CourseHttpService
                        .RemoveAssignedSubject(_selectedCourse.Id, selectedId);

                    //Borro la asignatura en la copia del curso
                    _selectedCourse.Subjects.Remove(subject);

                    //Refresca la tabla de asignaturas del primer curso
                    this.PopulateSubjectsTable();

                    //Ventanita con mensaje de éxito
                     message = string.Format("La asignatura {0} ha sido " +
                        "retirada de {1}º de {2}",
                        subject.Name,_selectedCourse.Year, _selectedCycle.Name);

                    new CustomSuccesMessageWindow(message, 0).ShowDialog();
                }

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
            
        }


    }
}


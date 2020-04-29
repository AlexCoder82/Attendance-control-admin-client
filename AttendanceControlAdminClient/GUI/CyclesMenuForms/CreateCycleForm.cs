using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    public partial class CreateCycleForm : CustomDialogForm
    {
        public Cycle CreatedCycle { get; set; }//El ciclo creado devuelto por el servidor
        public List<Shift> _shifts { get; set; }//La lista de turnos disponibles

        public CreateCycleForm()
        {
            InitializeComponent();
            this.PopulateCoursesComboBoxes();
        }

        /// <summary>
        ///     Rellena el comboBox de cursos
        /// </summary>
        private void PopulateCoursesComboBoxes()
        {
            object[] courses = new object[]{ 1, 2, 3, 4, 5 };
            this.cbCourses.Items.AddRange(courses);

            //Establece el mismo evento de seleccion para ambos
            this.cbCourses.SelectedIndexChanged += new EventHandler(cbCourses_SelectedIndexChanged);
            this.cbCourses.SelectedIndex = 0;
        

        }

        /// <summary>
        ///     Evento al pulsar crear :
        ///     Se instancia un objeto ciclo con el nombre de ciclo introducido y
        ///     se envia al cliente http, el cuál retorna el mismo ciclo creado
        ///     pero con su id generado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonCreateCycle_Click(object sender, EventArgs e)
        {
            string cycleName = this.tbCycleName.Text;
            int totalCourses = this.cbCourses.SelectedIndex + 1;

            if(cycleName.Length >0 && cbShiftes.SelectedValue!= null )
            {
                this.btnCreateCycle.Enabled = false;

                //Crea la lista de cursos segun la cantidad elegida
                List<Course> courses = new List<Course>();
                for(int i=1; i <= totalCourses; i++)
                {
                    courses.Add(new Course
                    {
                        Year = i
                    }); 
                }
                Cycle cycle = new Cycle()
                {
                    Name = cycleName,
                    Shift = _shifts.FirstOrDefault(s => s.Id == (int)cbShiftes.SelectedValue),
                    Courses = courses
                };

                try
                {                
                    this.CreatedCycle = await CycleHttpService.Save(cycle);

                    //Ventanita con mensaje de éxito
                    string message = string.Format("Has registrado el ciclo formativo de {0}.", 
                        this.CreatedCycle.Name);
                    new CustomSuccesMessageWindow(message,0).ShowDialog();

                    this.Close();
                }
                catch(ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                    this.btnCreateCycle.Enabled = true;
                }   
            }
        }

        /// <summary>
        ///      Evento al pulsar el botón cancelar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateShiftsComboBox()
        {
            this.cbShiftes.DataSource = _shifts;
            this.cbShiftes.DisplayMember = "Description";
            this.cbShiftes.ValueMember = "Id";
        }

        private async void CreateCycleForm_Load(object sender, EventArgs e)
        {
            await this.ListAllShiftes();
            this.PopulateShiftsComboBox();
        }

        private async Task ListAllShiftes()
        {
            try
            {
                _shifts = await ShiftHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

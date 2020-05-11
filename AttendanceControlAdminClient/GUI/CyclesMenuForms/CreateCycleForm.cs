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
        //Callback cuando se crea un nuevo ciclo
        public delegate void  OnCycleCreatedCallback( Cycle cycle);
        public OnCycleCreatedCallback OnCycleCreatedDelegate;

        public List<Shift> shifts { get; set; }//La lista de turnos disponibles

        public CreateCycleForm( )
        {

            InitializeComponent();
            this.PopulateCoursesComboBoxes();

        }

        /// <summary>
        ///     Evento Load del formulatio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CreateCycleForm_Load(object sender, EventArgs e)
        {
            await this.ListAllShiftes();
            this.PopulateShiftsComboBox();
        }

        /// <summary>
        ///     Obtiene la lista de turnos del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task ListAllShiftes()
        {

            try
            {
                shifts = await ShiftHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Rellena el combobox de turnos
        /// </summary>
        private void PopulateShiftsComboBox()
        {
            this.cbShiftes.DataSource = shifts;
            this.cbShiftes.DisplayMember = "Description";
            this.cbShiftes.ValueMember = "Id";
        }

        /// <summary>
        ///     Rellena el comboBox de cursos con la posibilidad de crear un ciclo de hasta 5 cursos
        /// </summary>
        private void PopulateCoursesComboBoxes()
        {

            object[] courses = new object[]{ 1, 2, 3, 4, 5 };
            this.cbCourses.Items.AddRange(courses);
            this.cbCourses.SelectedIndex = 0;
    
        }

        /// <summary>
        ///     Evento al pulsar crear :
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
                //Instancia un ciclo
                Cycle cycle = new Cycle()
                {
                    Name = cycleName,
                    Shift = shifts.FirstOrDefault(s => s.Id == (int)cbShiftes.SelectedValue),
                    Courses = courses
                };

                try
                {                
                    //El ciclo pasa a ser el ciclo retornado por el servicio http 
                    cycle =  await CycleHttpService.Save(cycle);

                    //Ventanita con mensaje de éxito
                    string message = string.Format("Has registrado el ciclo formativo de {0}.", 
                        cycle.Name);
                    new CustomSuccesMessageWindow(message).ShowDialog();

                    this.OnCycleCreatedDelegate(cycle);//Callback con el ciclo creado

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

    }
}

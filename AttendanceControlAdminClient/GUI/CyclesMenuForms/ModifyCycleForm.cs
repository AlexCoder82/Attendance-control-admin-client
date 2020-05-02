using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    public partial class ModifyCycleForm : CustomDialogForm
    {
        private List<Shift> shifts; //La lista de turnos disponibles
        private int defaultShiftid;

        public Cycle UpdatedCycle { get; set; }//El ciclo a modificar
        public string UpdatedName { get; set; }//El nombre actualizado    
        public bool Updated { get; set; }//Indica si se ha actualizado

        public ModifyCycleForm(Cycle cycle)
        {
            UpdatedCycle = new Cycle();//Para evitar el paso por referencia
            UpdatedCycle = cycle;
            this.defaultShiftid = cycle.Shift.Id;
            InitializeComponent();
        }

        /// <summary>
        ///     Evento al cargar el formularo:
        ///     Se rellena el textbox con el nombre actual del ciclo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ModifyCycleForm_Load(object sender, EventArgs e)
        {
            
            this.tbCycleName.Text = UpdatedCycle.Name;
            await this.ListAllShiftes();
            this.PopulateShiftsComboBox();

        }

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

        private void PopulateShiftsComboBox()
        {

            this.cbShiftes.DataSource = shifts;
            this.cbShiftes.DisplayMember = "Description";
            this.cbShiftes.ValueMember = "Id";

            this.cbShiftes.SelectedValue = UpdatedCycle.Shift.Id;
            Console.WriteLine(this.cbShiftes.SelectedValue);
        }
        //protected override void OnPaint(PaintEventArgs pe)
        //{
        //    base.OnPaint(pe);
        //}

        /// <summary>
        ///     Evento al pulsar cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///     Evento al pulsar Modificar:
        ///     Se envia el nuevo nombre del ciclo al cliente http
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonModifyCycle_Click(object sender, EventArgs e)
        {
            string cycleName = this.tbCycleName.Text;

            if (cycleName.Length > 0)
            {
                this.btnModifyCycle.Enabled = false;
                try
                {
                    bool confirmed = true;

                    int shiftId = (int)this.cbShiftes.SelectedValue;
                    //Si se cambia el turno -> mensaje de aviso
                    if ( shiftId != this.defaultShiftid)
                    {
                        string message = "Si cambias el turno, se cancelaran todas las clases del ciclo," +
                            " ¿Estás seguro de querer cambiar el turno?";
                        CustomConfirmDialogForm dialog = new CustomConfirmDialogForm(message);
                        dialog.ShowDialog();

                        if (!dialog.Confirmed)
                        {
                            confirmed = false;
                        }
                    }

                    if (confirmed)
                    {
                        UpdatedCycle.Name = cycleName;
                        UpdatedCycle.Shift = this.shifts.Find(s => s.Id == shiftId);
                        bool updated = await CycleHttpService.Update(UpdatedCycle);

                        //Si el cliente http devuelve true, se guarda el nuevo nobre en un objecto ciclo
                        if (updated)
                        {
                            this.Updated = true;
                        }

                        //Ventanita con mensaje de éxito
                        string message = "Se han guardado los cambios del ciclo formativo.";
                        new CustomSuccesMessageWindow(message, 0).ShowDialog();
                        this.Close();
                    }
                   
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                    this.btnModifyCycle.Enabled = true;
                }
            }
        }

        
    }
}

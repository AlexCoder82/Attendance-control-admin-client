using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;


namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    public partial class ModifyCycleForm : CustomDialogForm
    {
        private Cycle _cycle;//El ciclo a modificar
        public string UpdatedName { get; set; }//El nombre actualizado

        public ModifyCycleForm(Cycle cycle)
        {
            _cycle = cycle;
            InitializeComponent();
           
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
                    bool updated = await CycleHttpService.UpdateName(_cycle.Id, cycleName);

                    //Si el cliente http devuelve true, se guarda el nuevo nobre en un objecto ciclo
                    if (updated)
                    {
                        this.UpdatedName = cycleName;
                    }
                    
                    //Ventanita con mensaje de éxito
                    string message = "Has registrado el nuevo nombre del ciclo.";
                    new CustomSuccesMessageWindow(message,0).ShowDialog();
                    this.Close();
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                    this.btnModifyCycle.Enabled = true;
                }
            }
        }

        /// <summary>
        ///     Evento al cargar el formularo:
        ///     Se rellena el textbox con el nombre actual del ciclo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModifyCycleForm_Load(object sender, EventArgs e)
        {
            this.tbCycleName.Text = _cycle.Name;
        }
    }
}

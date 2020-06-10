using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.StudentsMenuForms
{
    /// <summary>
    ///     Formulario de ausencias 
    /// </summary>
    public partial class AbsencesForm : CustomDialogForm
    {

        private readonly Student _student;
        private List<Absence> absences;
        private int _totalExcused;
     
        public AbsencesForm(Student student)
        {
            _student = student;
            _totalExcused = 0;
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        ///     Evento Load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AbsencesForm_Load(object sender, EventArgs e)
        {

            this.FillData();
            this.SetDataGridViewAbsences();
            this.SetDataGridViewDelays();
            await this.GetStudentAbsences();
            this.PopulateDataGridViewAbsences();

        }



        /// <summary>
        ///     Recibe la lista de ausencias del alumno del cliente http
        /// </summary>
        private async Task GetStudentAbsences()
        {

            try
            {
                this.absences = await AbsenceHttpService.GetByStudent(_student.Id);       
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Rellena los datos del alumno
        /// </summary>
        private void FillData()
        {

            this.labelStudent.Text = _student.FullName;
            if(_student.Course is null)
            {
                this.labelCourse.Text = "Sin asignar";
            }
            else
            {
                this.labelCourse.Text = _student.Course.Year + "º de " + _student.Course.Cycle.Name;
            }
            this.labelTotalClasses.Text = _student.TotalAbsences.ToString();
            this.labelTotalDelays.Text = _student.TotalDelays.ToString();
            this.labelTotal.Text = (_student.TotalAbsences + _student.TotalDelays).ToString();

            this.dgvAbsences.Rows.Clear();
        
        }

        /// <summary>
        ///     Rellena la tabla de ausencias por dia
        /// </summary>
        private void PopulateDataGridViewAbsences()
        {
            if (!(absences is null) && absences.Count > 0)
            {         
                //ORDENA POR FECHA
                absences = absences.OrderBy(a => a.Date).ThenBy(a => a.Schedule.Start).ToList();

                
                int totalExcused = 0;// Total justificado

                CultureInfo cultureInfo = new CultureInfo("es-ES");

                //Filtra las ausencia por día
                List<List<Absence>> dayAbsences = absences.GroupBy(a => a.Date).Select(group=>group.ToList()).ToList();

                foreach(List<Absence> absences in dayAbsences)//Cada dia
                {
                    int absenceCounter = 0;//Contador de clases perdidas un mismo dia
                    int delaysCounter = 0;//Contador de retrasos un mismo día
                    string date = absences[0].Date.ToString(cultureInfo.DateTimeFormat.LongDatePattern);
                    date = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(date.ToLower());

                    foreach(Absence absence in absences)//Cada ausencia del dia
                    {
                        if(absence.Type == Enums.AbsenceType.TOTAL)
                        {
                            absenceCounter++;
                        }
                        else
                        {
                            delaysCounter++;
                        }

                        if (absence.IsExcused)
                        {
                            totalExcused++;
                        }
                    };
                    this.dgvAbsences.Rows.Add(date, absenceCounter, delaysCounter);
                };

      
                this.dgvAbsences.Rows[0].Selected = true;
                this.dgvDetails.Visible = true;
                _totalExcused = totalExcused;
                this.labelTotalExcused.Text = _totalExcused.ToString();

            }

            if(absences is null)
            {
                for(int i =0; i < 5; i++)
                {
                    this.dgvAbsences.Rows.Add();

                    this.dgvDetails.Visible = false;
                }
                
            }

            if(absences != null && absences.Count < 3)
            {
                for (int i = absences.Count; i < 3; i++)
                {
                    this.dgvAbsences.Rows.Add();
                    
                }
            }

           
        }
        /// <summary>
        ///     Establece las medidas de las columnas de la tabla de retrasos
        /// </summary>
        private void SetDataGridViewDelays()
        {
            this.dgvDetails.Columns[1].Width = 90;
            this.dgvDetails.Columns[1].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            this.dgvDetails.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            this.dgvDetails.Columns[2].Width = 200;
            this.dgvDetails.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvDetails.Columns[2].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleLeft;
            this.dgvDetails.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;


            this.dgvDetails.Columns[3].Width = 100;
            this.dgvDetails.Columns[3].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            this.dgvDetails.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            this.dgvDetails.Columns[4].Width = 90;
            this.dgvDetails.Columns[4].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            this.dgvDetails.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

        }

        /// <summary>
        ///     Establece las medidas de las columnas de la tabla de ausencias
        /// </summary>
        private void SetDataGridViewAbsences()
        {
            this.dgvAbsences.Columns[0].Width = 280;
            this.dgvAbsences.Columns[0].HeaderCell.Style.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            this.dgvAbsences.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            this.dgvAbsences.Columns[1].Width = 160;
            this.dgvAbsences.Columns[1].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
            this.dgvAbsences.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            this.dgvAbsences.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvAbsences.Columns[2].HeaderCell.Style.Alignment =
               DataGridViewContentAlignment.MiddleCenter;
            this.dgvAbsences.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


        }


        /// <summary>
        ///     Evento al hacer click en una celda de la tabla de retrasos:
        ///     Si se hace click en una celda de la columna "Justificado",
        ///     se marca el retraso como justificado o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void dgvDelays_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = -1;
            int row = -1;
            DataGridViewCell cell = null;
            try
            {
                 cell = this.dgvDetails.CurrentCell;
                // se recupera la celda clickeada
                col = cell.ColumnIndex;

                row = cell.RowIndex;

            }
            catch (Exception ex)
            {

            }


            if (col == 4)
            {
                int selectedId = int
                    .Parse(this.dgvDetails.Rows[row].Cells[0].Value.ToString());

                bool isExcused = !(bool)cell.Value;

                try
                {
                    await AbsenceHttpService.SetExcused(selectedId, isExcused);
                    cell.Value = isExcused;

                    if (isExcused)
                    {
                        _totalExcused++;
                    }
                    else
                    {
                        _totalExcused--;
                    }

                    //Refresco el contador de ausencias justificadas
                    this.labelTotalExcused.Text = _totalExcused.ToString();

                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }
            }

        }

        private void DgvAbsences_SelectionChanged(object sender, EventArgs e)
        {

            if (absences.Count > 0 && dgvAbsences.Rows.Count > 0
                && dgvAbsences.SelectedRows.Count > 0)
            {
                //Recupera la fecha de la linea seleccionada
                string sDate = dgvAbsences.SelectedRows[0].Cells[0].Value.ToString();
                DateTime date = DateTime.Parse(sDate);


                //Rellena la tabla con las ausencias de dicha fecha
                this.PopulateDataGridViewDetails(date);
            }

        }

        /// <summary>
        ///     Rellena la tabla de detalles de ausencias
        /// </summary>
        /// <param name="date"></param>
        private void PopulateDataGridViewDetails(DateTime date)
        {

            this.dgvDetails.Rows.Clear();
            absences.ForEach(a =>
            {
     
                if (a.Date.DayOfYear == date.DayOfYear)
                {
    
                    string absenceType = "";
                    if (a.Type == Enums.AbsenceType.TOTAL)
                    {
                        absenceType = "Clase perdida";
                    }
                    else
                    {
                        absenceType = "Retraso";
                    }

                    this.dgvDetails.Rows.Add(a.Id, a.Schedule.Start + " - " + a.Schedule.End,
                        a.Subject.Name, absenceType, a.IsExcused);
                }
            });

        }
    }
}

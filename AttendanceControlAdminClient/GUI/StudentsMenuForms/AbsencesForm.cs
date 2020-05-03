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
    public partial class AbsencesForm : CustomDialogForm
    {
        private Student _student;
        private List<Absence> _absences;
        private int _totalExcused;
        private Dictionary<string, string> days;
        public AbsencesForm(Student student)
        {
            this.SetDays();
            _student = student;
            _totalExcused = 0;
            InitializeComponent();
            this.CenterToScreen();
        }

        private void SetDays()
        {

        }
        /// <summary>
        ///     Evento al cargar este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AbsencesForm_Load(object sender, EventArgs e)
        {
            this.SetDataGridViewAbsences();
            this.SetDataGridViewDelays();
            await this.GetStudentAbsences();
            this.FillData();
           
        }

        /// <summary>
        ///     Rellena los labels con los datos del alumno y sus ausencias
        /// </summary>
        private void SetLabels()
        {
           
        }


        /// <summary>
        ///     Recibe la lista de ausencias del alumno del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetStudentAbsences()
        {
            try
            {
                _absences = await AbsenceHttpService.GetByStudent(_student.Id);
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }
        }

        /// <summary>
        ///     Rellena laa tablaa de ausencias y retrasos
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
            // this.dgvDelays.Rows.Clear();      

            _absences.Add(new Absence
            {
                Id = 1,
                Date = DateTime.Now,
                Type = Enums.AbsenceType.DELAY,
                Schedule = new Schedule
                {
                    Id = 1,
                    Start = "08h30",
                    End = "09h25"
                },
                Subject = new Subject
                {
                    Name = "AAAAAAAA"
                }

            });
            _absences.Add(
            new Absence
            {
                Id = 2,
                Date = DateTime.Now,
                Type = Enums.AbsenceType.TOTAL,
                Schedule = new Schedule
                {
                    Id = 2,
                    Start = "09h25",
                    End = "10h20"
                },
                Subject = new Subject
                {
                    Name = "DDDDDDDDDDDDDD"
                }

            });
            _absences.Add(new Absence
            {
                Id = 3,
                Date = DateTime.Now,
                Type = Enums.AbsenceType.TOTAL,
                Schedule = new Schedule
                {
                    Id = 1,
                    Start = "10h20",
                    End = "11h15"
                },
                Subject = new Subject
                {
                    Name = "CCCCCCCCCCCCC"
                }

            });
            _absences.Add(new Absence
            {
                Id = 4,
                Date = DateTime.Now,
                Type = Enums.AbsenceType.TOTAL,
                Schedule = new Schedule
                {
                    Id = 1,
                    Start = "10h20",
                    End = "11h15"
                },
                Subject = new Subject
                {
                    Name = "CCCCCCCCCCCCC"
                },
                IsExcused = true

            });
            _absences.Add(new Absence
            {
                Id = 5,
                Date = DateTime.Now,
                Type = Enums.AbsenceType.TOTAL,
                Schedule = new Schedule
                {
                    Id = 1,
                    Start = "10h20",
                    End = "11h15"
                },
                Subject = new Subject
                {
                    Name = "CCCCCCCCCCCCC"
                },
                IsExcused = true

            });
            _absences.Add(new Absence
            {
                Id = 6,
                Date = DateTime.Now,
                Type = Enums.AbsenceType.TOTAL,
                Schedule = new Schedule
                {
                    Id = 1,
                    Start = "10h20",
                    End = "11h15"
                },
                Subject = new Subject
                {
                    Name = "CCCCCCCCCCCCC"
                }

            });

            if (!(_absences is null) && _absences.Count > 0)
            {
                //ORDENA POR FECHA
                _absences = _absences.OrderBy(a => a.Date).ThenBy(a => a.Schedule.Start).ToList();

                int absenceCounter = 0;
                int delaysCounter = 0;
                int totalExcused = 0;
                CultureInfo cultureInfo = new CultureInfo("es-ES");
                for (int i = 1; i < _absences.Count; i++)
                {

                    if (_absences[i].Date.DayOfYear == _absences[i - 1].Date.DayOfYear)
                    {
                        if (_absences[i - 1].Type == Enums.AbsenceType.TOTAL)
                        {
                            absenceCounter++;
                            
                            
                        }
                        else
                        {
                            delaysCounter++;
                        }
                        if (i == _absences.Count - 1)
                        {
                            if (_absences[i].Type == Enums.AbsenceType.TOTAL)
                            {
                                absenceCounter++;
                            }
                            else
                            {
                                delaysCounter++;
                            }
                            string date = _absences[i - 1].Date.ToString(cultureInfo.DateTimeFormat.LongDatePattern);
                            date = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(date.ToLower());
                            this.dgvAbsences.Rows.Add(date, absenceCounter, delaysCounter);
                            if (_absences[i ].IsExcused)
                            {
                                totalExcused++;
                            }
                        }
                    }
                    else
                    {
                        string date = _absences[i - 1].Date.ToString(cultureInfo.DateTimeFormat.LongDatePattern);
                        date = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(date.ToLower());
                        this.dgvAbsences.Rows.Add(date, absenceCounter, delaysCounter);
                        absenceCounter = 0;
                        delaysCounter = 0;
                    }
                    if (_absences[i - 1].IsExcused)
                    {
                        totalExcused++;
                    }
                    




                }
                this.dgvAbsences.Rows[0].Selected = true;
                _totalExcused = totalExcused;
                this.labelTotalExcused.Text = _totalExcused.ToString();
  
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

                    //Refresco el contado de ausencias justificadas
                    this.labelExcusedDelays.Text = _totalExcused.ToString();

                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }
            }
        }

        private void dgvAbsences_SelectionChanged(object sender, EventArgs e)
        {
            if (_absences.Count > 0 && dgvAbsences.Rows.Count > 0
                && dgvAbsences.SelectedRows.Count > 0)
            {
                //Recupera la fecha de la linea seleccionada
                string sDate = dgvAbsences.SelectedRows[0].Cells[0].Value.ToString();
                DateTime date = DateTime.Parse(sDate);


                //Rellena la tabla con las ausencias de dicha fecha
                this.PopulateDataGridViewDetails(date);
            }
        }

        private void PopulateDataGridViewDetails(DateTime date)
        {
            this.dgvDetails.Rows.Clear();
            _absences.ForEach(a =>
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

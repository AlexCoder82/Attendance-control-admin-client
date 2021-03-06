﻿using AttendanceControlAdminClient.Exceptions;
using AttendanceControlAdminClient.GUI.CustomControls;
using AttendanceControlAdminClient.HttpServices;
using AttendanceControlAdminClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    public partial class AssignSubjectForm : CustomDialogForm
    {
        private string _cycleName;//El nombre del ciclo formativo
        private readonly Course _course;//El curso recibido 
        private List<Subject> subjects;//La lista de todas las asignaturas 

        //Callback con la asignatura añadida al curso
        public delegate void OnSubjectAddedCallBack(Subject subject);
        public OnSubjectAddedCallBack OnSubjectAddedDelegate;

        public AssignSubjectForm(string cycleName, Course course)
        {
            _course = course;
            _cycleName = cycleName;
            InitializeComponent();
            this.CenterToScreen();
        }

        /// <summary>
        ///     Evento al cargarse este formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AssignNewSubjectForm_Load(object sender, EventArgs e)
        {
            this.SetTitle();
            this.SetDataGridViewSubjects();
            await this.GetAllSubjects();
            PopulateSubjectsTable("");
        }

        /// <summary>
        ///     Pone en el nombre del curso como titulo
        /// </summary>
        private void SetTitle()
        {

            string courseName = string.Format("{0}º de {1}", _course.Year, _cycleName);
            this.groupBoxSubjects.Text = "Nueva asignatura de " + courseName;

        }

        /// <summary>
        ///     Asigna medidas a la tabla de asignaturas
        /// </summary>
        private void SetDataGridViewSubjects()
        {

            this.dgvSubjects.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

        }

        /// <summary>
        ///     Recibe la lista de todas las asignaturas del cliente http
        /// </summary>
        /// <returns></returns>
        private async Task GetAllSubjects()
        {

            try
            {
                subjects = await SubjectHttpService.GetAll();
            }
            catch (ServerErrorException ex)
            {
                new CustomErrorMessageWindow(ex.Message).ShowDialog();
            }

        }

        /// <summary>
        ///     Rellena la tabla de asignaturas con las asignaturas cuyo 
        ///     nombre empiezen por la cadena pasada
        /// </summary>
        /// <param name="subjectName">
        ///     Nombre de la asignatura
        /// </param>
        private void PopulateSubjectsTable(string subjectName)
        {

            this.dgvSubjects.Rows.Clear();

            subjectName = subjectName.TrimStart();
            int length = subjectName.Length;

            if (!(subjects is null))
            {
                subjects.ForEach(s =>
                {
                    //Si las letras introducidas corresponden a los nombres 
                    //de las asignaturas 
                    if (s.Name.Length >= length
                        && subjectName
                            .Equals(s.Name.Substring(0, length),
                                StringComparison.InvariantCultureIgnoreCase))
                    {
                        //Solo agrego a la tabla las asignaturas que el curso 
                        //no tiene ya asignadas para evitar asignar dos veces la misma
                        bool found = false;
                        for (int i = 0; i < _course.Subjects.Count && !found; i++)
                        {
                            if (s.Name.Equals(_course.Subjects[i].Name))
                            {
                                found = true;
                            }
                        }
                        if (!found)
                        {
                            this.dgvSubjects.Rows.Add(s.Id, s.Name);
                        }
                    }
                });

            }

            //Si la lista es nula, se crean 5 registros vacios(diseño)
            //y se desabilita el botón
            if (subjects is null)
            {
                for (int i = 0; i < 5; i++)
                {
                    this.dgvSubjects.Rows.Add();
                }
            }

            if (this.subjects != null && this.dgvSubjects.Rows.Count < 5)
            {
                for (int i = this.dgvSubjects.Rows.Count; i < 5; i++)
                {
                    this.dgvSubjects.Rows.Add();
                }
            }

            this.dgvSubjects.Rows[0].Selected = true;

        }

        /// <summary>
        ///     Evento al escribir en el textbox:
        ///     Se vuelve a rellenar la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbSubject_TextChanged(object sender, EventArgs e)
        {

            this.PopulateSubjectsTable(this.tbSubject.Text);

        }



        /// <summary>
        ///     Evento al pulsar asignar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonAssign_Click(object sender, EventArgs e)
        {
            if (this.dgvSubjects.SelectedRows[0].Cells[0].Value != null)
            {
                //Recupera el id de la asignatura seleccionada
                int selectedId = (int)this.dgvSubjects
                    .SelectedRows[0].Cells[0].Value;

                //Recupera la asignatura
                Subject subject = subjects.FirstOrDefault(s => s.Id == selectedId);

                try
                {
                    //Agrega la asignatura al curso
                    await CourseHttpService.AssignSubject(_course.Id, selectedId);


                    string name = (string)this.dgvSubjects
                        .SelectedRows[0].Cells[1].Value;

                    string message = string.Format("Se ha añadidio la asignatura {0} a {1}º de {2}.",
                        name, _course.Year, _cycleName);
                    CustomSuccesMessageWindow dialog = new CustomSuccesMessageWindow(message);
                    dialog.ShowDialog();

                    this.OnSubjectAddedDelegate(subject);//Callback con la asignatura añadida
                    this.Close();
                }
                catch (ServerErrorException ex)
                {
                    new CustomErrorMessageWindow(ex.Message).ShowDialog();
                }
            }
            else
            {
                new CustomErrorMessageWindow("Debes seleccionar una asignatura antes.")
                   .ShowDialog();
            }

        }




    }
}

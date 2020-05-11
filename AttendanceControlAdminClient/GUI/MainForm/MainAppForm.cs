using AttendanceControlAdminClient.GUI.CyclesMenuForms;
using AttendanceControlAdminClient.GUI.SchedulesMenuForms;
using AttendanceControlAdminClient.GUI.StudentsMenuForms;
using AttendanceControlAdminClient.GUI.SubjectsMenuForms;
using AttendanceControlAdminClient.GUI.TeachersMenuForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.MainForm
{
    /// <summary>
    ///     Formulario principal de la aplicacion
    /// </summary>
    public partial class MainAppForm : Form
    {

        private bool mouseIsDown;//Indica si el raton esta pulsado o no
        private Point lastLocation;
        private CyclesWindowControl cyclesWindowControl;
        private SubjectsWindowControl subjectsWindowControl;
        private TeachersWindowControl teachersWindowControl;
        private ClassesWindowControl schedulesWindowControl;
        private StudentsWindowControl studentsWindowControl;

        public MainAppForm()
        {
            InitializeComponent();
            //Abre el menú de ciclos por defecto
            this.cyclesWindowControl = new CyclesWindowControl();
            this.PanelContainer.Controls.Add(this.cyclesWindowControl);
        }

        private void SetCursorPosition(Button button)
        {

            this.PanelCursor.Location = new Point()
            {
                X = this.PanelCursor.Location.X,
                Y = button.Location.Y
            };

        }

        /// <summary>
        ///     Evento al pulsar el boton Ciclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCycles_Click(object sender, EventArgs e)
        {

            this.SetCursorPosition((Button)sender);
            this.cyclesWindowControl = new CyclesWindowControl();
            this.PanelContainer.Controls.Clear();
            this.PanelContainer.Controls.Add(this.cyclesWindowControl);

        }

        /// <summary>
        ///     Evento al pulsar el boton Profesores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTeachers_Click(object sender, EventArgs e)
        {

            this.SetCursorPosition((Button)sender);
            this.teachersWindowControl = new TeachersWindowControl();
            this.PanelContainer.Controls.Clear();
            this.PanelContainer.Controls.Add(this.teachersWindowControl);

        }

        /// <summary>
        ///     Evento al pulsar el boton Clases
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSchedules_Click(object sender, EventArgs e)
        {

            this.SetCursorPosition((Button)sender);
            this.schedulesWindowControl = new ClassesWindowControl();
            this.PanelContainer.Controls.Clear();
            this.PanelContainer.Controls.Add(this.schedulesWindowControl);

        }

        /// <summary>
        ///     Evento al pulsar el boton Alumnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStudents_Click(object sender, EventArgs e)
        {

            this.SetCursorPosition((Button)sender);
            this.studentsWindowControl = new StudentsWindowControl();
            this.PanelContainer.Controls.Clear();
            this.PanelContainer.Controls.Add(this.studentsWindowControl);

        }

        /// <summary>
        ///     Evento al pulsar el boton Asignaturas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSubjects_Click(object sender, EventArgs e)
        {

            this.SetCursorPosition((Button)sender);
            this.subjectsWindowControl = new SubjectsWindowControl();
            this.PanelContainer.Controls.Clear();
            this.PanelContainer.Controls.Add(this.subjectsWindowControl);

        }

        // EVENTOS PARA PODER DESPLAZAR LA VENTANA

        /// <summary>
        ///     Al pulsar el raton se guarda el Location del raton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelUp_MouseDown(object sender, MouseEventArgs e)
        {

            mouseIsDown = true;
            lastLocation = e.Location;

        }

        /// <summary>
        ///     Al mover el raton, si esta pulsado, desplaza la ventana hacia la nueva
        ///     posicion del raton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelUp_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseIsDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();//Refresca
            }

        }

        /// <summary>
        ///     Al soltar el boton del raton 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelUp_MouseUp(object sender, MouseEventArgs e)
        {

            mouseIsDown = false;

        }

    }
}

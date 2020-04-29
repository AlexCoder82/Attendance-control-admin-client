using AttendanceControlAdminClient.GUI.CyclesMenuForms;
using AttendanceControlAdminClient.GUI.SchedulesMenuForms;
using AttendanceControlAdminClient.GUI.ShiftsMenuForms;
using AttendanceControlAdminClient.GUI.StudentsMenuForms;
using AttendanceControlAdminClient.GUI.SubjectsMenuForms;
using AttendanceControlAdminClient.GUI.TeachersMenuForms;
using AttendanceControlAdminClient.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AttendanceControlAdminClient.GUI.MainForm
{
    public partial class MainAppForm : Form
    {
        private bool mouseIsDown;
        private Point lastLocation;
        private CyclesWindowControl _cyclesWindowControl;
        private SubjectsWindowControl SubjectsWindowControl;
        private TeachersWindowControl TeachersWindowControl;
        private ClassesWindowControl SchedulesWindowControl;
        private StudentsWindowControl StudentsWindowControl;

        public MainAppForm()
        {
            InitializeComponent();
            this._cyclesWindowControl = new CyclesWindowControl();
            this.PanelContainer.Controls.Add(this._cyclesWindowControl);
        }


        private void ButtonCycles_Click(object sender, EventArgs e)
        {
            this.PanelCursor.Location = new Point()
            {
                X = this.PanelCursor.Location.X,
                Y = this.ButtonCycles.Location.Y
            };

            this._cyclesWindowControl = new CyclesWindowControl();

            this.PanelContainer.Controls.Clear();
            this.PanelContainer.Controls.Add(this._cyclesWindowControl);
        }



        private void ButtonTeachers_Click(object sender, EventArgs e)
        {
            this.PanelCursor.Location = new Point()
            {
                X = this.PanelCursor.Location.X,
                Y = this.ButtonTeachers.Location.Y
            };


            this.TeachersWindowControl = new TeachersWindowControl();

            this.PanelContainer.Controls.Clear();
            this.PanelContainer.Controls.Add(this.TeachersWindowControl);
        }

        private void ButtonSchedules_Click(object sender, EventArgs e)
        {
            this.PanelCursor.Location = new Point()
            {
                X = this.PanelCursor.Location.X,
                Y = this.ButtonClasses.Location.Y
            };

            this.SchedulesWindowControl = new ClassesWindowControl();

            this.PanelContainer.Controls.Clear();
            this.PanelContainer.Controls.Add(this.SchedulesWindowControl);
        }

        private void ButtonStudents_Click(object sender, EventArgs e)
        {
            this.PanelCursor.Location = new Point()
            {
                X = this.PanelCursor.Location.X,
                Y = this.ButtonStudents.Location.Y
            };

            this.StudentsWindowControl = new StudentsWindowControl();

            this.PanelContainer.Controls.Clear();
            this.PanelContainer.Controls.Add(this.StudentsWindowControl);
        }

       

        private void ButtonSubjects_Click(object sender, EventArgs e)
        {
            this.PanelCursor.Location = new Point()
            {
                X = this.PanelCursor.Location.X,
                Y = this.ButtonSubjects.Location.Y
            };

            this.SubjectsWindowControl = new SubjectsWindowControl();

            this.PanelContainer.Controls.Clear();
            this.PanelContainer.Controls.Add(this.SubjectsWindowControl);
        }

       

        #region EVENTOS PARA DESPLAZAR LA APLICACIÖN EN LA PANTALLA


        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            lastLocation = e.Location;
        }

        private void panelUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelUp_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        #endregion


    }
}

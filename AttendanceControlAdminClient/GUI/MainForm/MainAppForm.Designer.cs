

namespace AttendanceControlAdminClient.GUI.MainForm
{
    partial class MainAppForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ButtonSubjects = new System.Windows.Forms.Button();
            this.PanelCursor = new System.Windows.Forms.Panel();
            this.ButtonStudents = new System.Windows.Forms.Button();
            this.ButtonClasses = new System.Windows.Forms.Button();
            this.ButtonTeachers = new System.Windows.Forms.Button();
            this.ButtonCycles = new System.Windows.Forms.Button();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.panelUp = new System.Windows.Forms.Panel();
            this.customMinimizeButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomMinimizeButton();
            this.customCloseButton1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomCloseButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customMinimizeButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.ButtonSubjects);
            this.MenuPanel.Controls.Add(this.PanelCursor);
            this.MenuPanel.Controls.Add(this.ButtonStudents);
            this.MenuPanel.Controls.Add(this.ButtonClasses);
            this.MenuPanel.Controls.Add(this.ButtonTeachers);
            this.MenuPanel.Controls.Add(this.ButtonCycles);
            resources.ApplyResources(this.MenuPanel, "MenuPanel");
            this.MenuPanel.Name = "MenuPanel";
            // 
            // ButtonSubjects
            // 
            this.ButtonSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSubjects.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonSubjects, "ButtonSubjects");
            this.ButtonSubjects.ForeColor = global::AttendanceControlAdminClient.Properties.Settings.Default.OPTIMA_COLOR;
            this.ButtonSubjects.Name = "ButtonSubjects";
            this.ButtonSubjects.UseVisualStyleBackColor = false;
            this.ButtonSubjects.Click += new System.EventHandler(this.ButtonSubjects_Click);
            // 
            // PanelCursor
            // 
            this.PanelCursor.BackColor = global::AttendanceControlAdminClient.Properties.Settings.Default.OPTIMA_COLOR;
            resources.ApplyResources(this.PanelCursor, "PanelCursor");
            this.PanelCursor.Name = "PanelCursor";
            // 
            // ButtonStudents
            // 
            this.ButtonStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStudents.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonStudents, "ButtonStudents");
            this.ButtonStudents.ForeColor = global::AttendanceControlAdminClient.Properties.Settings.Default.OPTIMA_COLOR;
            this.ButtonStudents.Name = "ButtonStudents";
            this.ButtonStudents.UseVisualStyleBackColor = false;
            this.ButtonStudents.Click += new System.EventHandler(this.ButtonStudents_Click);
            // 
            // ButtonClasses
            // 
            this.ButtonClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClasses.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonClasses, "ButtonClasses");
            this.ButtonClasses.ForeColor = global::AttendanceControlAdminClient.Properties.Settings.Default.OPTIMA_COLOR;
            this.ButtonClasses.Name = "ButtonClasses";
            this.ButtonClasses.UseVisualStyleBackColor = false;
            this.ButtonClasses.Click += new System.EventHandler(this.ButtonSchedules_Click);
            // 
            // ButtonTeachers
            // 
            this.ButtonTeachers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTeachers.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonTeachers, "ButtonTeachers");
            this.ButtonTeachers.ForeColor = global::AttendanceControlAdminClient.Properties.Settings.Default.OPTIMA_COLOR;
            this.ButtonTeachers.Name = "ButtonTeachers";
            this.ButtonTeachers.UseVisualStyleBackColor = false;
            this.ButtonTeachers.Click += new System.EventHandler(this.ButtonTeachers_Click);
            // 
            // ButtonCycles
            // 
            this.ButtonCycles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCycles.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonCycles, "ButtonCycles");
            this.ButtonCycles.ForeColor = global::AttendanceControlAdminClient.Properties.Settings.Default.OPTIMA_COLOR;
            this.ButtonCycles.Name = "ButtonCycles";
            this.ButtonCycles.UseVisualStyleBackColor = false;
            this.ButtonCycles.Click += new System.EventHandler(this.ButtonCycles_Click);
            // 
            // PanelContainer
            // 
            resources.ApplyResources(this.PanelContainer, "PanelContainer");
            this.PanelContainer.Name = "PanelContainer";
            // 
            // panelUp
            // 
            this.panelUp.Controls.Add(this.customMinimizeButton1);
            this.panelUp.Controls.Add(this.customCloseButton1);
            this.panelUp.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panelUp, "panelUp");
            this.panelUp.Name = "panelUp";
            this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelUp_MouseDown);
            this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelUp_MouseMove);
            this.panelUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseUp);
            // 
            // customMinimizeButton1
            // 
            resources.ApplyResources(this.customMinimizeButton1, "customMinimizeButton1");
            this.customMinimizeButton1.Name = "customMinimizeButton1";
            this.customMinimizeButton1.TabStop = false;
            // 
            // customCloseButton1
            // 
            resources.ApplyResources(this.customCloseButton1, "customCloseButton1");
            this.customCloseButton1.Name = "customCloseButton1";
            this.customCloseButton1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttendanceControlAdminClient.Properties.Resources.logo_optima;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MainAppForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.panelUp);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainAppForm";
            this.MenuPanel.ResumeLayout(false);
            this.panelUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customMinimizeButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCloseButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ButtonCycles;
        private System.Windows.Forms.Button ButtonStudents;
        private System.Windows.Forms.Button ButtonClasses;
        private System.Windows.Forms.Button ButtonTeachers;
        private System.Windows.Forms.Panel PanelCursor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Button ButtonSubjects;
        private System.Windows.Forms.Panel panelUp;
        private CustomControls.CustomCloseButton customCloseButton1;
        private CustomControls.CustomMinimizeButton customMinimizeButton1;
    }
}


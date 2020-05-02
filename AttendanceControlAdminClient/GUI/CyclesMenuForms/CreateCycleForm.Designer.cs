using AttendanceControlAdminClient.GUI.CustomControls;

namespace AttendanceControlAdminClient.GUI.CyclesMenuForms
{
    partial class CreateCycleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customLabel1 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.btnCreateCycle = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.tbCycleName = new AttendanceControlAdminClient.GUI.CustomControls.CustomTextBox();
            this.btnCancel = new AttendanceControlAdminClient.GUI.CustomControls.CustomButton();
            this.cbShiftes = new AttendanceControlAdminClient.GUI.CustomControls.CustomComboBox();
            this.customLabel2 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.customLabel3 = new AttendanceControlAdminClient.GUI.CustomControls.CustomLabel();
            this.cbCourses = new AttendanceControlAdminClient.GUI.CustomControls.CustomComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.customLabel1.Location = new System.Drawing.Point(30, 50);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(336, 16);
            this.customLabel1.TabIndex = 1;
            this.customLabel1.Text = "¿Qué nombre tendrá el nuevo ciclo formativo?";
            // 
            // btnCreateCycle
            // 
            this.btnCreateCycle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCreateCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCycle.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCreateCycle.ForeColor = System.Drawing.Color.White;
            this.btnCreateCycle.Location = new System.Drawing.Point(271, 247);
            this.btnCreateCycle.Name = "btnCreateCycle";
            this.btnCreateCycle.Size = new System.Drawing.Size(75, 25);
            this.btnCreateCycle.TabIndex = 0;
            this.btnCreateCycle.Text = "Crear";
            this.btnCreateCycle.UseVisualStyleBackColor = false;
            this.btnCreateCycle.Click += new System.EventHandler(this.ButtonCreateCycle_Click);
            // 
            // tbCycleName
            // 
            this.tbCycleName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.tbCycleName.ForeColor = System.Drawing.Color.Black;
            this.tbCycleName.Location = new System.Drawing.Point(30, 90);
            this.tbCycleName.Name = "tbCycleName";
            this.tbCycleName.Size = new System.Drawing.Size(403, 20);
            this.tbCycleName.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(123, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // cbShiftes
            // 
            this.cbShiftes.BackColor = System.Drawing.Color.White;
            this.cbShiftes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShiftes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbShiftes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.cbShiftes.FormattingEnabled = true;
            this.cbShiftes.Location = new System.Drawing.Point(314, 190);
            this.cbShiftes.Name = "cbShiftes";
            this.cbShiftes.Size = new System.Drawing.Size(121, 22);
            this.cbShiftes.TabIndex = 5;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.customLabel2.Location = new System.Drawing.Point(30, 190);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(265, 16);
            this.customLabel2.TabIndex = 6;
            this.customLabel2.Text = "¿Durante que turno se desarrollará?";
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.customLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.customLabel3.Location = new System.Drawing.Point(30, 140);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(186, 16);
            this.customLabel3.TabIndex = 7;
            this.customLabel3.Text = "¿Cuantos cursos tendrá?";
            // 
            // cbCourses
            // 
            this.cbCourses.BackColor = System.Drawing.Color.White;
            this.cbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourses.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.cbCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(5)))), ((int)(((byte)(12)))));
            this.cbCourses.FormattingEnabled = true;
            this.cbCourses.Location = new System.Drawing.Point(393, 140);
            this.cbCourses.Name = "cbCourses";
            this.cbCourses.Size = new System.Drawing.Size(42, 22);
            this.cbCourses.TabIndex = 8;
            this.cbCourses.SelectedIndexChanged += new System.EventHandler(this.cbCourses_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customLabel1);
            this.groupBox1.Controls.Add(this.cbShiftes);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.customLabel2);
            this.groupBox1.Controls.Add(this.btnCreateCycle);
            this.groupBox1.Controls.Add(this.cbCourses);
            this.groupBox1.Controls.Add(this.tbCycleName);
            this.groupBox1.Controls.Add(this.customLabel3);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 295);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de ciclo formativo";
            // 
            // CreateCycleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 345);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "CreateCycleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNewCycleForm";
            this.Load += new System.EventHandler(this.CreateCycleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton btnCreateCycle;
        private CustomLabel customLabel1;
        private CustomTextBox tbCycleName;
        private CustomButton btnCancel;
        private CustomComboBox cbShiftes;
        private CustomLabel customLabel2;
        private CustomLabel customLabel3;
        private CustomComboBox cbCourses;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
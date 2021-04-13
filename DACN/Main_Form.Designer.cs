
namespace DACN
{
    partial class Main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageLecturers = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClass = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRegistrationCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLecturers,
            this.manageStudents,
            this.manageClass,
            this.manageSubjectToolStripMenuItem,
            this.manageCourseToolStripMenuItem,
            this.manageRegistrationCourseToolStripMenuItem,
            this.manageAttendanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(956, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageLecturers
            // 
            this.manageLecturers.Name = "manageLecturers";
            this.manageLecturers.Size = new System.Drawing.Size(113, 20);
            this.manageLecturers.Text = "Manage Lecturers";
            this.manageLecturers.Click += new System.EventHandler(this.manageLecturers_Click);
            // 
            // manageStudents
            // 
            this.manageStudents.Name = "manageStudents";
            this.manageStudents.Size = new System.Drawing.Size(111, 20);
            this.manageStudents.Text = "Manage Students";
            this.manageStudents.Click += new System.EventHandler(this.manageStudents_Click);
            // 
            // manageClass
            // 
            this.manageClass.Name = "manageClass";
            this.manageClass.Size = new System.Drawing.Size(92, 20);
            this.manageClass.Text = "Manage Class";
            this.manageClass.Click += new System.EventHandler(this.manageClass_Click);
            // 
            // manageSubjectToolStripMenuItem
            // 
            this.manageSubjectToolStripMenuItem.Name = "manageSubjectToolStripMenuItem";
            this.manageSubjectToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.manageSubjectToolStripMenuItem.Text = "Manage Subject";
            this.manageSubjectToolStripMenuItem.Click += new System.EventHandler(this.manageSubjectToolStripMenuItem_Click);
            // 
            // manageCourseToolStripMenuItem
            // 
            this.manageCourseToolStripMenuItem.Name = "manageCourseToolStripMenuItem";
            this.manageCourseToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.manageCourseToolStripMenuItem.Text = "Manage Course";
            this.manageCourseToolStripMenuItem.Click += new System.EventHandler(this.manageCourseToolStripMenuItem_Click);
            // 
            // manageRegistrationCourseToolStripMenuItem
            // 
            this.manageRegistrationCourseToolStripMenuItem.Name = "manageRegistrationCourseToolStripMenuItem";
            this.manageRegistrationCourseToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.manageRegistrationCourseToolStripMenuItem.Text = "Manage Registration Course";
            this.manageRegistrationCourseToolStripMenuItem.Click += new System.EventHandler(this.manageRegistrationCourseToolStripMenuItem_Click);
            // 
            // manageAttendanceToolStripMenuItem
            // 
            this.manageAttendanceToolStripMenuItem.Name = "manageAttendanceToolStripMenuItem";
            this.manageAttendanceToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.manageAttendanceToolStripMenuItem.Text = "Manage Attendance";
            this.manageAttendanceToolStripMenuItem.Click += new System.EventHandler(this.manageAttendanceToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageLecturers;
        private System.Windows.Forms.ToolStripMenuItem manageStudents;
        private System.Windows.Forms.ToolStripMenuItem manageClass;
        private System.Windows.Forms.ToolStripMenuItem manageSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRegistrationCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAttendanceToolStripMenuItem;
    }
}
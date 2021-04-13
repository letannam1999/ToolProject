using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageLecturers_Click(object sender, EventArgs e)
        {
            ManageLecturersForm manageLecturersForm = new ManageLecturersForm();
            manageLecturersForm.ShowDialog();
        }

        private void manageStudents_Click(object sender, EventArgs e)
        {
            ManageStudentsForm manageStudentsForm = new ManageStudentsForm();
            manageStudentsForm.ShowDialog();
        }

        private void manageClass_Click(object sender, EventArgs e)
        {
            ManageClassListsForm manageClassListsForm = new ManageClassListsForm();
            manageClassListsForm.ShowDialog();
        }

        private void manageSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSubjectForm manageSubjectForm = new ManageSubjectForm();
            manageSubjectForm.ShowDialog();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageCourseForm = new ManageCourseForm();
            manageCourseForm.ShowDialog();
        }

        private void manageRegistrationCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRegistrationCourseForm manageRegistrationCourseForm = new ManageRegistrationCourseForm();
            manageRegistrationCourseForm.ShowDialog();
        }

        private void manageAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageAttendanceForm manageAttendanceForm = new ManageAttendanceForm();
            manageAttendanceForm.ShowDialog();
        }
    }
}

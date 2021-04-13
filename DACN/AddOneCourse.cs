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
    public partial class AddOneCourse : Form
    {
        Course course = new Course();
        public AddOneCourse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClass.Text.Trim().Equals("") || txtAcademicYear.Text.Trim().Equals("") || txtSubjectId.Text.Trim().Equals("") || txtTerm.Text.Trim().Equals("") || txtLecturerId.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Required Feilds - Missing Information", "Required Feilds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String classid = txtClass.Text;
                    int lecturerid = Convert.ToInt32(txtLecturerId.Text);
                    String academyyear = txtAcademicYear.Text;
                    String subjectid = txtSubjectId.Text;
                    String term = txtTerm.Text;
                    String courseid = classid + subjectid;
                    Boolean insertCourse = course.insertCourse(courseid, subjectid, lecturerid, term, academyyear, classid);

                    if (insertCourse)
                    {
                        MessageBox.Show("New Course Has Been Added", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Can Not Add New Course", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTerm.Text = "";
            txtSubjectId.Text = "";
            txtLecturerId.Text = "";
            txtClass.Text = "";
            txtAcademicYear.Text = "";
        }
    }
}

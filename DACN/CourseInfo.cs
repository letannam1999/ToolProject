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
    public partial class CourseInfo : Form
    {
        Course course = new Course();
        public CourseInfo()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String classid = txtClass.Text;
            String subjectid = txtSubjectId.Text;
            String courseid = txtCourseId.Text;
            String term = txtTerm.Text;
            String academicyear = txtAcademicYear.Text;
            try
            {
                int lecturerid = Convert.ToInt32(txtLecturerId.Text);
                if (txtAcademicYear.Text.Trim().Equals("") || txtClass.Text.Trim().Equals("") || txtCourseId.Text.Trim().Equals("") || txtLecturerId.Text.Trim().Equals("") || txtSubjectId.Text.Trim().Equals("") || txtTerm.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Required Feilds - Missing Information", "Required Feilds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean edit=course.editCourse(courseid,subjectid,lecturerid,term,academicyear,classid);

                    if (edit)
                    {
                        MessageBox.Show("Course Has Been Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Course Can Be Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String courseid = txtCourseId.Text;

                Boolean remove = course.removeCourse(courseid);

                if (remove)
                {
                    MessageBox.Show("Course Has Been Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Course Can Be Not Removed", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

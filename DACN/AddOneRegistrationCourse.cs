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
    public partial class AddOneRegistrationCourse : Form
    {
        RegistrationCourse registrationCourse = new RegistrationCourse();
        public AddOneRegistrationCourse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentId.Text.Trim().Equals("") || txtCourseId.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Required Feilds - Missing Information", "Required Feilds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String courseid = txtCourseId.Text;
                    int studentid = Convert.ToInt32(txtStudentId.Text);
                    Boolean insertRegistrationCourse = registrationCourse.insertRegistrationCourse(courseid, studentid);

                    if (insertRegistrationCourse)
                    {
                        MessageBox.Show("New Registration Course Has Been Added", "Add Registration Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Can Not Add New Registration Course", "Add Registration Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtCourseId.Text = "";
            txtStudentId.Text = "";
        }
    }
}

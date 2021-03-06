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
    public partial class StudentInfo : Form
    {
        Student student = new Student();
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String fname = txtFName.Text;
            String mname = txtMName.Text;
            String lname = txtLName.Text;
            String classid = txtClass.Text;
            String email = txtEmail.Text;
            String phone = txtPhone.Text;
            String birth = txtDOB.Text;
            String status = cbbStatus.Text;

            try
            {
                int id = Convert.ToInt32(txtMSSV.Text);

                if (txtFName.Text.Trim().Equals("") || txtMName.Text.Trim().Equals("") || txtLName.Text.Trim().Equals("") || txtClass.Text.Trim().Equals("") || txtEmail.Text.Trim().Equals("") || txtPhone.Text.Trim().Equals("") || txtDOB.Text.Trim().Equals("") || cbbStatus.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Required Feilds - Missing Information", "Required Feilds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean edit = student.editStudent(id, fname, mname, lname, classid, email, phone, birth, status);

                    if (edit)
                    {
                        MessageBox.Show("Student Has Been Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Student Can Be Not Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtMSSV.Text);

                Boolean remove = student.removeStudent(id);

                if (remove)
                {
                    MessageBox.Show("Student Has Been Removed", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Student Can Be Not Removed", "Remove Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

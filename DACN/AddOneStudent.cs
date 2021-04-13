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
    public partial class AddOneStudent : Form
    {
        Student student = new Student();
        public AddOneStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFName.Text.Trim().Equals("") || txtClass.Text.Trim().Equals("") || txtMName.Text.Trim().Equals("") || txtLName.Text.Trim().Equals("") || txtEmail.Text.Trim().Equals("") || txtPhone.Text.Trim().Equals("") || txtDOB.Text.Trim().Equals("") || cbbStatus.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Required Feilds - Missing Information", "Required Feilds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String password = "1";
                    String fname = txtFName.Text;
                    String mname = txtMName.Text;
                    String lname = txtLName.Text;
                    String classid = txtClass.Text;
                    String email = txtEmail.Text;
                    String phone = txtPhone.Text;
                    String birth = txtDOB.Text;
                    String status = cbbStatus.Text;

                    Boolean insertStudent = student.insertStudent(password, fname, mname, lname, classid, email, phone, birth, status);

                    if (insertStudent)
                    {
                        MessageBox.Show("New Student Has Been Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Can Not Add New Student", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtDOB.Text = "";
            txtEmail.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtMName.Text = "";
            txtPhone.Text = "";
            cbbStatus.Text = "";
            txtClass.Text = "";
        }
    }
}

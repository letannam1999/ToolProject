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
    public partial class AddOneSubject : Form
    {
        Subject subject = new Subject();
        public AddOneSubject()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSubjectId.Text.Trim().Equals("") || txtPeriods.Text.Trim().Equals("") || txtName.Text.Trim().Equals("") || txtCredits.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Required Feilds - Missing Information", "Required Feilds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String subjectId = txtSubjectId.Text;
                    String name = txtName.Text;
                    String periods = txtPeriods.Text;
                    String credits = txtCredits.Text;

                    Boolean insertSubject = subject.insertSubject(subjectId, name, periods, credits);

                    if (insertSubject)
                    {
                        MessageBox.Show("New Subject Has Been Added", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Can Not Add New Subject", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtCredits.Text = "";
            txtName.Text = "";
            txtPeriods.Text = "";
            txtSubjectId.Text = "";
        }
    }
}

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
    public partial class SubjectInfo : Form
    {
        Subject subject = new Subject();
        public SubjectInfo()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            String name = txtName.Text;
            String periods = txtPeriods.Text;
            String credits = txtCredits.Text;

            try
            {

                if (txtCredits.Text.Trim().Equals("") || txtId.Text.Trim().Equals("") || txtName.Text.Trim().Equals("") || txtPeriods.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Required Feilds - Missing Information", "Required Feilds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean edit = subject.editSubject(id,name,periods,credits);

                    if (edit)
                    {
                        MessageBox.Show("Subject Has Been Updated", "Edit Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Subject Can Be Not Updated", "Edit Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            String id = txtId.Text;
            try
            {
                Boolean remove = subject.removeSubject(id);

                if (remove)
                {
                    MessageBox.Show("Subject Has Been Removed", "Remove Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Subject Can Be Not Removed", "Remove Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

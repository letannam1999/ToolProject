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
    public partial class AddOneClass : Form
    {
        ClassList classList = new ClassList();
        public AddOneClass()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBegin.Text = "";
            txtClassId.Text = "";
            txtMajor.Text = "";
            txtType.Text = "";
            txtYearTraining.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBegin.Text.Trim().Equals("") || txtMajor.Text.Trim().Equals("") || txtClassId.Text.Trim().Equals("") || txtType.Text.Trim().Equals("") || txtYearTraining.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Required Feilds - Missing Information", "Required Feilds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String classid = txtClassId.Text;
                    String major = txtMajor.Text;
                    String timebegin = txtBegin.Text;
                    String yeartraining = txtYearTraining.Text;
                    String typeeducation = txtType.Text;

                    Boolean insertClass = classList.insertClassList(classid, major, timebegin, yeartraining, typeeducation);

                    if (insertClass)
                    {
                        MessageBox.Show("New Class Has Been Added", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error - Can Not Add New Class", "Add Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

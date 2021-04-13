using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACN
{
    public partial class RegistrationCourseInfo : Form
    {
        RegistrationCourse registration = new RegistrationCourse();
        Connection connection = new Connection();
        public RegistrationCourseInfo()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String cid = txtCourseId.Text;
                int sid = Convert.ToInt32(txtMSSV.Text);

                Boolean remove = registration.removeRegistrationCourse(cid, sid);

                if (remove)
                {
                    MessageBox.Show("Student Has Been Removed Out Of Course", "Remove Student Out Of Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Student Can Be Not Removed Out Of Course", "Remove Student Out Of Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

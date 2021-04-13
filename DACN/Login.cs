using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DACN
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin" && txtPass.Text == "123")
            {
                this.Hide();
                Main_Form main_Form = new Main_Form();
                main_Form.Show();
            }
            else
            {
                if (txtName.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your UserName to Login", "Empty UserName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtPass.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("UserName or Password doesn't exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

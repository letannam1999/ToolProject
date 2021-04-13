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
    public partial class ManageRegistrationCourseForm : Form
    {
        RegistrationCourse registrationCourse = new RegistrationCourse();
        Connection connection = new Connection();
        public ManageRegistrationCourseForm()
        {
            InitializeComponent();
        }

        private void ManageRegistrationCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registrationCourseDataSet.RegistrationCourse' table. You can move, or remove it, as needed.
            this.registrationCourseTableAdapter.Fill(this.registrationCourseDataSet.RegistrationCourse);

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            AddRegistrationCourseExcelFile importRegistrationCourseExcelFile = new AddRegistrationCourseExcelFile();
            importRegistrationCourseExcelFile.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOneRegistrationCourse addOneRegistrationCourse = new AddOneRegistrationCourse();
            addOneRegistrationCourse.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = registrationCourse.getRegistrationCourse();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistrationCourseInfo info = new RegistrationCourseInfo();
            info.txtCourseId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            info.txtMSSV.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[1].Value.ToString());
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE StudentId=@id", connection.GetSqlConnection());
            command.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            adapter.Fill(dt);
            connection.openConnection();

            if (dt.Rows.Count == 1)
            {
                info.txtFName.Text = dt.Rows[0][2].ToString();
                info.txtMName.Text = dt.Rows[0][3].ToString();
                info.txtLName.Text = dt.Rows[0][4].ToString();
                info.txtClass.Text = dt.Rows[0][5].ToString();
                info.txtEmail.Text = dt.Rows[0][6].ToString();
                info.txtPhone.Text = dt.Rows[0][7].ToString();
                info.txtDOB.Text = dt.Rows[0][8].ToString();
                connection.closeConnection();
            }
            else
            {
                connection.closeConnection();
            }

            info.ShowDialog();
        }
    }
}

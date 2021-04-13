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
    public partial class ManageStudentsForm : Form
    {
        Student student = new Student();
        public ManageStudentsForm()
        {
            InitializeComponent();
        }

        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dACNDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dACNDataSet1.Student);
            dataGridView2.DataSource = student.getStudent();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = student.getStudent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            AddStudentExcelFile addStudentExcelFile = new AddStudentExcelFile();
            addStudentExcelFile.ShowDialog();
        }

        private void dataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            StudentInfo studentInfo = new StudentInfo();
            
            studentInfo.txtMSSV.Text = this.dataGridView2.CurrentRow.Cells[0].Value.ToString();
            studentInfo.txtFName.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();
            studentInfo.txtMName.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            studentInfo.txtLName.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            studentInfo.txtClass.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            studentInfo.txtEmail.Text = this.dataGridView2.CurrentRow.Cells[5].Value.ToString();
            studentInfo.txtPhone.Text = this.dataGridView2.CurrentRow.Cells[6].Value.ToString();
            studentInfo.txtDOB.Text = Convert.ToDateTime(this.dataGridView2.CurrentRow.Cells[7].Value).ToString("MM/dd/yyyy");
            studentInfo.cbbStatus.Text = this.dataGridView2.CurrentRow.Cells[8].Value.ToString();
            studentInfo.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOneStudent addOneStudent = new AddOneStudent();
            addOneStudent.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string value = txtValue.Text.ToString();
                dataGridView2.DataSource = student.searchStudent(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

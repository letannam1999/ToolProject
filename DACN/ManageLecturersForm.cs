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
    public partial class ManageLecturersForm : Form
    {
        Lecturer lecturer = new Lecturer();
        public ManageLecturersForm()
        {
            InitializeComponent();
        }
        private void ManageLecturersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dACNDataSet3.Lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter.Fill(this.dACNDataSet3.Lecturer);
            dataGridView1.DataSource = lecturer.getLecturer();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LecturerInfo lecturerInfo = new LecturerInfo();
            lecturerInfo.txtMSGV.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lecturerInfo.txtFName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lecturerInfo.txtMName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lecturerInfo.txtLName.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lecturerInfo.txtEmail.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            lecturerInfo.txtPhone.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lecturerInfo.txtDOB.Text = Convert.ToDateTime(this.dataGridView1.CurrentRow.Cells[6].Value).ToString("MM/dd/yyyy");
            lecturerInfo.cbbStatus.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            lecturerInfo.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lecturer.getLecturer();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            AddLecturerExcelFile addLecturerExcelFile = new AddLecturerExcelFile();
            addLecturerExcelFile.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOneLecturer addOneLecturer = new AddOneLecturer();
            addOneLecturer.ShowDialog();
        }
    }
}

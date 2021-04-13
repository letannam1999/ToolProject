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
    public partial class ManageSubjectForm : Form
    {
        Subject subject = new Subject();
        public ManageSubjectForm()
        {
            InitializeComponent();
        }

        private void ManageSubjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'subjectDataSet.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.subjectDataSet.Subject);

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            AddSubjectExcelFile addSubjectExcelFile = new AddSubjectExcelFile();
            addSubjectExcelFile.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOneSubject addOneSubject = new AddOneSubject();
            addOneSubject.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = subject.getSubject();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SubjectInfo subjectInfo = new SubjectInfo();
            subjectInfo.txtId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            subjectInfo.txtName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            subjectInfo.txtPeriods.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            subjectInfo.txtCredits.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            subjectInfo.ShowDialog();
        }
    }
}

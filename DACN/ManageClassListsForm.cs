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
    public partial class ManageClassListsForm : Form
    {
        ClassList classList = new ClassList();
        public ManageClassListsForm()
        {
            InitializeComponent();
        }

        private void ManageClassListsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dACNDataSet4.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.dACNDataSet4.Class);
            dataGridView3.DataSource = classList.getClassList();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            dataGridView3.DataSource = classList.getClassList();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            AddClassExcelFile addClassExcelFile = new AddClassExcelFile();
            addClassExcelFile.ShowDialog();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddOneClass addOneClass = new AddOneClass();
            addOneClass.ShowDialog();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassInfo classInfo = new ClassInfo();
            classInfo.txtClass.Text = this.dataGridView3.CurrentRow.Cells[0].Value.ToString();
            classInfo.txtMajor.Text = this.dataGridView3.CurrentRow.Cells[1].Value.ToString();
            classInfo.txtBegin.Text = this.dataGridView3.CurrentRow.Cells[2].Value.ToString();
            classInfo.txtYearTraining.Text = this.dataGridView3.CurrentRow.Cells[3].Value.ToString();
            classInfo.txtType.Text = this.dataGridView3.CurrentRow.Cells[4].Value.ToString();
            classInfo.ShowDialog();
        }
    }
}

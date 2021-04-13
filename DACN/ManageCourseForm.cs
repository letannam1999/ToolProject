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
    public partial class ManageCourseForm : Form
    {
        Course course = new Course();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.courseDataSet.Course);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CourseInfo courseInfo = new CourseInfo();
            courseInfo.txtCourseId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            courseInfo.txtSubjectId.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            courseInfo.txtLecturerId.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            courseInfo.txtTerm.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            courseInfo.txtAcademicYear.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            courseInfo.txtClass.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            courseInfo.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            AddCourseExcelFile addCourseExcelFile = new AddCourseExcelFile();
            addCourseExcelFile.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOneCourse addOneCourse = new AddOneCourse();
            addOneCourse.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = course.getCourse();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using Z.Dapper.Plus;
using System.IO;

namespace DACN
{
    public partial class AddCourseExcelFile : Form
    {
        DataTableCollection tableCollection;
        Connection connection = new Connection();
        public AddCourseExcelFile()
        {
            InitializeComponent();
        }

        private void AddCourseExcelFile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDataSet1.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.courseDataSet1.Course);


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

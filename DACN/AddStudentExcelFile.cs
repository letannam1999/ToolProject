using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using Z.Dapper.Plus;

namespace DACN
{
    public partial class AddStudentExcelFile : Form
    {
        public AddStudentExcelFile()
        {
            InitializeComponent();
        }

        private void AddStudentExcelFile_Load(object sender, EventArgs e)
        {
           
            this.studentTableAdapter.Fill(this.dACNDataSet.Student);

        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        DataTableCollection tableCollection;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
        }
        Connection connection = new Connection();

        private void btnImport_Click(object sender, EventArgs e)
        {
            
        }
    }
}

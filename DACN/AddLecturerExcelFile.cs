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
    public partial class AddLecturerExcelFile : Form
    {
        public AddLecturerExcelFile()
        {
            InitializeComponent();
        }

        private void AddLecturerExcelFile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dACNDataSet2.Lecturer' table. You can move, or remove it, as needed.
            this.lecturerTableAdapter1.Fill(this.dACNDataSet2.Lecturer);
           

        }
        Connection connection = new Connection();
        private void btnImport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
        }
        DataTableCollection tableCollection;
        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

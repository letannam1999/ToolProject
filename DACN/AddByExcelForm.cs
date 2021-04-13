using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class AddByExcelForm : Form
    {
        public AddByExcelForm()
        {
            InitializeComponent();
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            if (dt != null)
            {
                List<ExcelClassList> excelClassLists = new List<ExcelClassList>();
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    ExcelClassList excelClassList = new ExcelClassList();
                    excelClassList.LecturerFirstName = dt.Rows[i]["LecturerFirstName"].ToString();
                    excelClassList.LecturerLastName = dt.Rows[i]["LecturerLastName"].ToString();
                    excelClassList.MSGV = dt.Rows[i]["MSGV"].ToString();
                    excelClassList.LectureName = dt.Rows[i]["LectureName"].ToString();
                    excelClassList.LectureCode = dt.Rows[i]["LectureCode"].ToString();
                    excelClassList.StudentFirstName = dt.Rows[i]["StudentFirstName"].ToString();
                    excelClassList.StudentLastName = dt.Rows[i]["StudentLastName"].ToString();
                    excelClassList.MSSV = dt.Rows[i]["MSSV"].ToString();
                    //excelClassList.Day1 = dt.Rows[i]["Day1"].ToString();
                    //excelClassList.Day2 = dt.Rows[i]["Day2"].ToString();
                    //excelClassList.Day3 = dt.Rows[i]["Day3"].ToString();
                    //excelClassList.Day4 = dt.Rows[i]["Day4"].ToString();
                    //excelClassList.Day5 = dt.Rows[i]["Day5"].ToString();
                    //excelClassList.Day6 = dt.Rows[i]["Day6"].ToString();
                    //excelClassList.MidtermScore = dt.Rows[i]["MidtermScore"].ToString();
                    excelClassLists.Add(excelClassList);
                }
                classListBindingSource.DataSource = excelClassLists;
            }
        }
        DataTableCollection tableCollection;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog=new OpenFileDialog() { Filter="Excel Sheet (*.xls)|*.xls|WPS Excel (*xlsx)|*.xlsx|All Files(*.*)|*.*" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    txtPath.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName);
                        }
                    }
                }
            }
        }
        Connection connection = new Connection();
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {              
                DapperPlusManager.Entity<ExcelClassList>().Table("ClassList");
                List<ExcelClassList> excelClassLists = classListBindingSource.DataSource as List<ExcelClassList>;
                if (excelClassLists != null)
                {
                    using (IDbConnection db = connection.GetSqlConnection())
                    {
                        db.BulkInsert(excelClassLists);
                    }
                }
                MessageBox.Show("Finish", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}

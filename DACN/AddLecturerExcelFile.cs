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
            try
            {
                DapperPlusManager.Entity<ImportLecturerExcelFile>().Table("Lecturer");
                List<ImportLecturerExcelFile> importLecturerExcelFiles = lecturerBindingSource1.DataSource as List<ImportLecturerExcelFile>;
                if (importLecturerExcelFiles != null)
                {
                    using (IDbConnection db = connection.GetSqlConnection())
                    {
                        db.BulkInsert(importLecturerExcelFiles);
                    }
                }
                MessageBox.Show("All information have been imported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Sheet (*.xls)|*.xls|WPS Excel (*xlsx)|*.xlsx|All Files(*.*)|*.*" })
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
        DataTableCollection tableCollection;
        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
                if (dt != null)
                {
                    List<ImportLecturerExcelFile> imports = new List<ImportLecturerExcelFile>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ImportLecturerExcelFile import = new ImportLecturerExcelFile();
                        import.FirstName = dt.Rows[i]["FirstName"].ToString();
                        import.MidName = dt.Rows[i]["MidName"].ToString();
                        import.LastName = dt.Rows[i]["LastName"].ToString();
                        import.Email = dt.Rows[i]["Email"].ToString();
                        import.Phone = dt.Rows[i]["Phone"].ToString();
                        import.Birth = dt.Rows[i]["Birth"].ToString();
                        import.Status = dt.Rows[i]["Status"].ToString();
                        imports.Add(import);
                    }
                    lecturerBindingSource1.DataSource = imports;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

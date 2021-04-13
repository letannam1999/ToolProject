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
    public partial class AddSubjectExcelFile : Form
    {
        Connection connection = new Connection();
        DataTableCollection tableCollection;
        public AddSubjectExcelFile()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                DapperPlusManager.Entity<ImportSubjectExcelFile>().Table("Subject");
                List<ImportSubjectExcelFile> importSubjectExcelFiles = subjectDataSetBindingSource.DataSource as List<ImportSubjectExcelFile>;
                if (importSubjectExcelFiles != null)
                {
                    using (IDbConnection db = connection.GetSqlConnection())
                    {
                        db.BulkInsert(importSubjectExcelFiles);
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

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
                if (dt != null)
                {
                    List<ImportSubjectExcelFile> imports = new List<ImportSubjectExcelFile>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ImportSubjectExcelFile import = new ImportSubjectExcelFile();
                        import.SubjectId = dt.Rows[i]["Subject"].ToString();
                        import.NameSubject = dt.Rows[i]["NameSubject"].ToString();
                        import.NumberOfPeriods = dt.Rows[i]["NumberOfPeriods"].ToString();
                        import.NumberOfCredits = dt.Rows[i]["NumberOfCredits"].ToString();
                        imports.Add(import);
                    }
                    subjectDataSetBindingSource.DataSource = imports;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class AddClassExcelFile : Form
    {
        Connection connection = new Connection();
        DataTableCollection tableCollection;
        public AddClassExcelFile()
        {
            InitializeComponent();
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                DapperPlusManager.Entity<ImportClassExcelFile>().Table("Class");
                List<ImportClassExcelFile> importClassExcelFiles = dACNDataSet4BindingSource.DataSource as List<ImportClassExcelFile>;
                if (importClassExcelFiles != null)
                {
                    using (IDbConnection db = connection.GetSqlConnection())
                    {
                        db.BulkInsert(importClassExcelFiles);
                    }
                }
                MessageBox.Show("All information have been imported", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
                if (dt != null)
                {
                    List<ImportClassExcelFile> imports = new List<ImportClassExcelFile>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ImportClassExcelFile import = new ImportClassExcelFile();
                        import.ClassId = dt.Rows[i]["ClassId"].ToString();
                        import.Major = dt.Rows[i]["Major"].ToString();
                        import.TimeBegin = dt.Rows[i]["TimeBegin"].ToString();
                        import.YearOfTraining = dt.Rows[i]["YearOfTraining"].ToString();
                        import.TypeOfEducation = dt.Rows[i]["TypeOfEducation"].ToString();
                        imports.Add(import);
                    }
                    dACNDataSet4BindingSource.DataSource = imports;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class AddRegistrationCourseExcelFile : Form
    {
        DataTableCollection tableCollection;
        Connection connection = new Connection();
        public AddRegistrationCourseExcelFile()
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
                DapperPlusManager.Entity<ImportRegistrationCourseExcelFile>().Table("RegistrationCourse");
                List<ImportRegistrationCourseExcelFile> excelRegistrationCourseLists = registrationCourseDataSetBindingSource.DataSource as List<ImportRegistrationCourseExcelFile>;
                if (excelRegistrationCourseLists != null)
                {
                    using (IDbConnection db = connection.GetSqlConnection())
                    {
                        db.BulkInsert(excelRegistrationCourseLists);
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
                    List<ImportRegistrationCourseExcelFile> imports = new List<ImportRegistrationCourseExcelFile>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ImportRegistrationCourseExcelFile import = new ImportRegistrationCourseExcelFile();
                        import.CourseId = dt.Rows[i]["CourseId"].ToString();
                        import.StudentId = dt.Rows[i]["StudentId"].ToString();
                        imports.Add(import);
                    }
                    registrationCourseDataSetBindingSource.DataSource = imports;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

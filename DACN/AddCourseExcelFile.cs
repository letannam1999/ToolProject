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
                DapperPlusManager.Entity<ImportCourseExcelFile>().Table("Course");
                List<ImportCourseExcelFile> excelCourseLists = courseBindingSource.DataSource as List<ImportCourseExcelFile>;
                if (excelCourseLists != null)
                {
                    using (IDbConnection db = connection.GetSqlConnection())
                    {
                        db.BulkInsert(excelCourseLists);
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
                    List<ImportCourseExcelFile> imports = new List<ImportCourseExcelFile>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ImportCourseExcelFile import = new ImportCourseExcelFile();
                        import.SubjectId = dt.Rows[i]["SubjectId"].ToString();
                        import.LecturerId = dt.Rows[i]["LecturerId"].ToString();
                        import.Term = dt.Rows[i]["Term"].ToString();
                        import.AcademicYear = dt.Rows[i]["AcademicYear"].ToString();
                        import.ClassId = dt.Rows[i]["Classid"].ToString();
                        import.CourseId = dt.Rows[i]["Classid"].ToString() + dt.Rows[i]["SubjectId"].ToString();
                        imports.Add(import);
                    }
                    courseBindingSource.DataSource = imports;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

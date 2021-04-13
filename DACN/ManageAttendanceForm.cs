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
    public partial class ManageAttendanceForm : Form
    {
        Attendance attendance = new Attendance();
        public ManageAttendanceForm()
        {
            InitializeComponent();
        }

        private void ManageAttendanceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.attendanceDataSet.Attendance);
            dataGridView1.DataSource = attendance.getAttendance();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = attendance.getAttendance();
        }
    }
}

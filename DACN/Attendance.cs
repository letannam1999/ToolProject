using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN
{
    class Attendance
    {
        Connection connection = new Connection();
        public DataTable getAttendance()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Attendance", connection.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt;
        }
    }
}

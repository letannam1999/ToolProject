using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN
{
    class RegistrationCourse
    {
        Connection connection = new Connection();

        public bool insertRegistrationCourse(String courseid,int studentid)
        {
            SqlCommand command = new SqlCommand();
            String insertQuery = "INSERT INTO Course(CourseId,StudentId) VALUES(@courseid,@studentid)";
            command.CommandText = insertQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@courseid", courseid);
            command.Parameters.AddWithValue("@studentid", studentid);

            connection.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }
        public DataTable getRegistrationCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM RegistrationCourse", connection.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt;
        }



        public bool removeRegistrationCourse(String cid,int sid)
        {
            SqlCommand command = new SqlCommand();
            String removeQuery = "DELETE FROM RegistrationCourse WHERE CourseId=@courseid and StudentId=@studentid";
            command.CommandText = removeQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@courseid", cid);
            command.Parameters.AddWithValue("@studentid", sid);

            connection.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }
    }
}

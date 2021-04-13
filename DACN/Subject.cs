using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN
{
    class Subject
    {
        Connection connection = new Connection();

        public bool insertSubject(String subjectid, String subjectname, String numberofperiods, String numberofcredits)
        {
            SqlCommand command = new SqlCommand();
            String insertQuery = "INSERT INTO Subject(SubjectId,NameSubject,NumberOfPeriods,NumberOfCredits) VALUES(@id,@name,@np,@nc)";
            command.CommandText = insertQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@id", subjectid);
            command.Parameters.AddWithValue("@name", subjectname);
            command.Parameters.AddWithValue("@np", numberofperiods);
            command.Parameters.AddWithValue("@nc", numberofcredits);

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
        public DataTable getSubject()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Subject", connection.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt;
        }

        public bool editSubject(String subjectid, String subjectname, String numberofperiods, String numberofcredits)
        {
            SqlCommand command = new SqlCommand();
            String editQuery = "UPDATE Subject SET NameSubject=@name,NumberOfPeriods=@np, NumberOfCredits=@nc WHERE SubjectId=@id";
            command.CommandText = editQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@id", subjectid);
            command.Parameters.AddWithValue("@name", subjectname);
            command.Parameters.AddWithValue("@np", numberofperiods);
            command.Parameters.AddWithValue("@nc", numberofcredits);

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

        public bool removeSubject(String id)
        {
            SqlCommand command = new SqlCommand();
            String removeQuery = "DELETE FROM Subject WHERE SubjectId=@id";
            command.CommandText = removeQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@id", id);

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

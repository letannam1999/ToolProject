using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN
{
    class ClassList
    {
        Connection connection = new Connection();

        public bool insertClassList(String classid, String major, String timebegin, String yeartraining, String typeeducation)
        {
            SqlCommand command = new SqlCommand();
            String insertQuery = "INSERT INTO Class(ClassId,Major,TimeBegin,TypeOfTraining,TypeOfEducation) VALUES(@classid,@major,@timebegin,@yearoftraining,@typeofeducation)";
            command.CommandText = insertQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@classid", classid);
            command.Parameters.AddWithValue("@major", major);
            command.Parameters.AddWithValue("@timebegin", timebegin);
            command.Parameters.AddWithValue("@yearoftraining", yeartraining);
            command.Parameters.AddWithValue("@typeofeducation", typeeducation);

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
        public DataTable getClassList()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Class", connection.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt;
        }

        public bool editClassList(String classid, String major, String timebegin, String yeartraining, String typeeducation)
        {
            SqlCommand command = new SqlCommand();
            String editQuery = "UPDATE Class SET Major=@major, TimeBegin=@timebegin, YearOfTraining=@yearoftraining, TypeOfEducation=@typeofeducation WHERE ClassId=@classid";
            command.CommandText = editQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@classid", classid);
            command.Parameters.AddWithValue("@major", major);
            command.Parameters.AddWithValue("@timebegin", timebegin);
            command.Parameters.AddWithValue("@yearoftraining", yeartraining);
            command.Parameters.AddWithValue("@typeofeducation", typeeducation);

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

        public bool removeClassList(String id)
        {
            SqlCommand command = new SqlCommand();
            String removeQuery = "DELETE FROM Class WHERE ClassId=@id";
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN
{
    class Student
    {
        Connection connection = new Connection();

        public bool insertStudent(String password, String fname, String mname, String lname, String classid, String email, String phone, String birth, String status)
        {
            SqlCommand command = new SqlCommand();
            String insertQuery = "INSERT INTO Student(Password,FirstName,MidName,LastName,ClassId,Email,Phone,Birth,Status) VALUES(@password,@fname,@mname,@lname,@class,@email,@phone,@birth,@status)";
            command.CommandText = insertQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@fname", fname);
            command.Parameters.AddWithValue("@mname", mname);
            command.Parameters.AddWithValue("@lname", lname);
            command.Parameters.AddWithValue("@class", classid);
            command.Parameters.AddWithValue("@status", status);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@birth", birth);

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
        public DataTable getStudent()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Student", connection.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt;
        }

        public DataTable searchStudent(string value)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Student WHERE CONCAT(Password,FirstName,MidName,LastName,ClassId,Email,Phone,Birth,Status) like '%"+value+"%'", connection.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }
        public bool editStudent(int id, String fname, String mname, String lname, String classid, String email, String phone, String birth, String status)
        {
            SqlCommand command = new SqlCommand();
            String editQuery = "UPDATE Student SET FirstName=@fname, MidName=@mname,LastName=@lname, ClassId=@classid, Email=@email, Phone=@phone, Birth=@birth, Status=@status  WHERE StudentId=@id";
            command.CommandText = editQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@fname", fname);
            command.Parameters.AddWithValue("@mname", mname);
            command.Parameters.AddWithValue("@lname", lname);
            command.Parameters.AddWithValue("@classid",classid);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@birth", birth);
            command.Parameters.AddWithValue("@status", status);

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

        public bool removeStudent(int id)
        {
            SqlCommand command = new SqlCommand();
            String removeQuery = "DELETE FROM Student WHERE StudentId=@id";
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

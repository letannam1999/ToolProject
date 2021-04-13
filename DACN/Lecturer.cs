using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DACN
{
    class Lecturer
    {
        Connection connection = new Connection();

        public bool insertLecturer(String password, String fname, String mname, String lname, String email, String phone, String birth, String status)
        {
                SqlCommand command = new SqlCommand();
                String insertQuery = "INSERT INTO Lecturer(Password,FirstName,MidName,LastName,Email,Phone,Birth,Status) VALUES(@password,@fname,@mname,@lname,@email,@phone,@birth,@status)";
                command.CommandText = insertQuery;
                command.Connection = connection.GetSqlConnection();

                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@fname", fname);
                command.Parameters.AddWithValue("@mname", mname);
                command.Parameters.AddWithValue("@lname", lname);
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
        public DataTable getLecturer()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Lecturer", connection.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt;
        }

        public bool editLecturer(int id, String fname, String mname, String lname, String email, String phone, String birth, String status)
        {
            SqlCommand command = new SqlCommand();
            String editQuery = "UPDATE Lecturer SET FirstName=@fname, MidName=@mname,LastName=@lname, Email=@email, Phone=@phone, Birth=@birth, Status=@status WHERE LecturerId=@id";
            command.CommandText = editQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@fname", fname);
            command.Parameters.AddWithValue("@mname", mname);
            command.Parameters.AddWithValue("@lname", lname);
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

        public bool removeLecturer(int id)
        {
            SqlCommand command = new SqlCommand();
            String removeQuery = "DELETE FROM Lecturer WHERE LecturerId=@id";
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

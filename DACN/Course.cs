using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DACN
{
    class Course
    {
        Connection connection = new Connection();

        public bool insertCourse(String courseid, String subjectid, int lecturerid, String term, String academicyear, String classid)
        {
            SqlCommand command = new SqlCommand();
            String insertQuery = "INSERT INTO Course(CourseId,SubjectId,LecturerId,Term,AcademicYear,ClassId) VALUES(@courseid,@subjectid,@lecturerid,@term,@academicyear,@classid)";
            command.CommandText = insertQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@courseid", courseid);
            command.Parameters.AddWithValue("@subjectid", subjectid);
            command.Parameters.AddWithValue("@lecturerid", lecturerid);
            command.Parameters.AddWithValue("@term", term);
            command.Parameters.AddWithValue("@academicyear", academicyear);
            command.Parameters.AddWithValue("@classid", classid);

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
        public DataTable getCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course", connection.GetSqlConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            return dt;
        }

        public bool editCourse(String courseid, String subjectid, int lecturerid, String term, String academicyear, String classid)
        {
            SqlCommand command = new SqlCommand();
            String editQuery = "UPDATE Course SET SubjectId=@subjjectid, LecturerId=@lecturerid,Term=@term, AcademicYear=@academicyear, ClassId=@classid WHERE CourseId=@id";
            command.CommandText = editQuery;
            command.Connection = connection.GetSqlConnection();

            command.Parameters.AddWithValue("@id", courseid);
            command.Parameters.AddWithValue("@fname", subjectid);
            command.Parameters.AddWithValue("@mname", lecturerid);
            command.Parameters.AddWithValue("@lname", term);
            command.Parameters.AddWithValue("@email", academicyear);
            command.Parameters.AddWithValue("@phone", classid);

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

        public bool removeCourse(String id)
        {
            SqlCommand command = new SqlCommand();
            String removeQuery = "DELETE FROM Course WHERE CourseId=@id";
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

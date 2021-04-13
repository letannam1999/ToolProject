using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DACN
{
    class Connection
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-NM9QRUHJ\SQLEXPRESS;Initial Catalog=DACN;Integrated Security=True");
        public SqlConnection GetSqlConnection()
        {
            return connection;
        }
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

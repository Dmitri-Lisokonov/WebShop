using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WebShop
{
    class DataBaseConnection
    {
        public class Database
        {
            private static readonly string connectionString = @"";  //insert connectionstring


            public static SqlConnection OpenConnection()
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                return conn;
            }

            public static void CloseConnection(SqlConnection conn)
            {
                conn.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Data

{
    public class DatabaseConnection
    {

        private static readonly string connectionString = @"Server=mssql.fhict.local;Database=dbi419547;User Id=dbi419547;Password=Xb4s3828NOF";


        public static SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            Console.WriteLine(conn);
            return conn;

        }

        public static void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        }
    }

}

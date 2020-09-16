using System;
using System.Data.SqlClient;

namespace Lagersystem_project
{
    class Program
    {
        static void Main(string[] args)
        {

            Database db = new Database();
            SqlConnection conn = db.Connection();

            string sql = "SELECT * FROM Table_Products;";
            SqlCommand Command = new SqlCommand(sql, conn);
            
            Command.ExecuteReader();
            conn.Close();
        }
    }
}

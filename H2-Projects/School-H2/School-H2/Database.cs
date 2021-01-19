using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace School_H2
{
    public class Database
    {

        public SqlConnection connection()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "JACK-ANDERSEN-J";
                builder.InitialCatalog = "School-H2";
                builder.IntegratedSecurity = true;

                return new SqlConnection(builder.ToString());
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        public static SqlConnection openConnection()
        {
            Database db = new Database();
            SqlConnection conn = db.connection();
            conn.Open();

            return conn;
        }
    }
}

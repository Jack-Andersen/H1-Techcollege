using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Lagersystem_project
{
    public class Database
    {

        public SqlConnection connection()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "JACK-ANDERSEN-J";
                builder.InitialCatalog = "Lagersystem_H1";
                builder.IntegratedSecurity = true;

                return new SqlConnection(builder.ToString());
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}

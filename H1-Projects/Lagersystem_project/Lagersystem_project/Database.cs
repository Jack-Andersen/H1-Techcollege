using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Lagersystem_project
{
    class Database
    {



        public SqlConnection Connection()
        {
            SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = "JACK-ANDERSEN-J";
            connectionString.InitialCatalog = "Lagersystem_H1";
            connectionString.UserID = "JACK-ANDERSEN-J\\Elder";
            connectionString.Password = "";
            connectionString.IntegratedSecurity = true;

            return new SqlConnection(connectionString.ConnectionString);
        }
    }
}

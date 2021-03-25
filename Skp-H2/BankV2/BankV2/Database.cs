using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

class Database
{
    #region Database_Connection...
    static SqlConnection connection;

    public static bool db_connection(string username, string password)
    {

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "JACK-ANDERSEN-J";
        builder.InitialCatalog = "Bank-SkpH2";
        builder.UserID = username;
        builder.Password = password;

        connection = new SqlConnection(builder.ToString());
        try
        {
            connection.Open();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    #endregion
}

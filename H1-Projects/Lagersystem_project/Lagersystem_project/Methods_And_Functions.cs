using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Lagersystem_project
{
    public class Methods_And_Functions
    {

        public static void Menu()
        {
            Console.WriteLine("Menu\n" +
                              "Press 1 Insert product.\n" +
                              "Press 2 Delete product.\n" +
                              "Press 3 Update product.\n" +
                              "Press 4 Show all products.\n" +
                              "Press 5 Show all locations of products\n");
        }

        public static string InsertProduct(string ProductName, int ProductAmount, SqlConnection conn)
        {
            try
            {
                string SQL = (@" 
                INSERT INTO Table_Products (ProductName, ProductAmount)
                VALUES ('{0}', {1})");
                string formatted = string.Format(SQL, ProductName, ProductAmount);
                SqlCommand command = new SqlCommand(formatted, conn);
                Console.WriteLine(formatted);
                int result = command.ExecuteNonQuery();

                if (ProductAmount > 0)
                {
                    string SQLLocastion = (@"
                    SELECT ProductID FROM Table_Products
                    WHERE ProductName LIKE '{0}' AND ProductAmount LIKE {1}");
                    string formattedLocation = string.Format(SQLLocastion, ProductName, ProductAmount);
                    SqlCommand commandForProductLocastion = new SqlCommand(formattedLocation, conn);
                    SqlDataReader sdr = commandForProductLocastion.ExecuteReader();
                    int id = 0;
                    while (sdr.Read())
                    {
                        id = (int)sdr[0];
                        Console.WriteLine(id);
                    }
                    sdr.Close();

                    InsertLocation(id, conn);

                }

                return result + " rows affected.\n";
            }
            catch (SqlException e)
            {
                Console.WriteLine("SQL exception caught in insert " + e.ToString());
                return "0 rows affected.\n";
            }

        }
        public static void InsertLocation(int ProductID, SqlConnection conn)
        {
            string SQL = (@" 
            INSERT INTO Table_Products_Location (ProductID)
            VALUES ({0})");
            string formatted = string.Format(SQL, ProductID);
            Console.WriteLine(formatted);
            ExecuteQuery(conn, formatted);

        }

        public static void DeleteProduct(int ProductID, SqlConnection conn)
        {

            try
            {
                DeleteLocation(ProductID, conn);
            }
            finally
            {
                string SQL = (@"
                DELETE FROM Table_Products WHERE ProductID = {0}");
                string formatted = string.Format(SQL, ProductID);
                Console.WriteLine(formatted);
                ExecuteQuery(conn, formatted);
            }
        }

        public static void DeleteLocation(int ProductID, SqlConnection conn)
        {
            string SQL = (@"
            DELETE FROM Table_Products_Location WHERE ProductID = {0}");
            string formatted = string.Format(SQL, ProductID);
            Console.WriteLine(formatted);
            ExecuteQuery(conn, formatted);
        }

        public static void UpdateProduct(int ProductID, string ProductName, int ProductAmount, SqlConnection conn)
        {
            string SQL = (@"
            UPDATE Table_Products SET ProductName = '{0}', ProductAmount = {1} 
            WHERE ProductID = {2}");
            string formatted = string.Format(SQL, ProductName, ProductAmount, ProductID);
            Console.WriteLine(formatted);
            ExecuteQuery(conn, formatted);
        }

        public static void ShowAllProducts(SqlConnection conn)
        {

            string SQL = (@"
            SELECT * FROM Table_Products");
            SqlCommand command = new SqlCommand(SQL, conn);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("{0,-10} {1,-20} {2,-10}", sdr[0], sdr[1], sdr[2]);

            }

            Console.WriteLine("");
            sdr.Close();

        }

        public static void ShowAllLocations(SqlConnection conn)
        {

            string SQL = (@"
            SELECT * FROM Table_Products_Location
            INNER JOIN Table_Products
            ON Table_Products_Location.ProductID = Table_Products.ProductID");
            string formatted = string.Format(SQL);
            SqlCommand command = new SqlCommand(formatted, conn);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("{0,-11} {1,-20}", sdr[0], sdr[1]);
            }

            Console.WriteLine("");
            sdr.Close();

        }

        public static void ExecuteQuery(SqlConnection conn, string formatted)
        {
            SqlCommand command = new SqlCommand(formatted, conn);
            command.ExecuteNonQuery();
        }

    }
}

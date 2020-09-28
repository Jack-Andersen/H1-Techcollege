using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Lagersystem_project
{
    public class Methods_And_Functions
    {
        public static void InsertProduct(string ProductName, int ProductAmount, SqlConnection conn)
        {
            string SQL = (@" 
            INSERT INTO Table_Products (ProductName, ProductAmount)
            VALUES ('{0}', {1})");
            string formatted = string.Format(SQL, ProductName, ProductAmount);
            Console.WriteLine(formatted);
            ExecuteQuery(conn, formatted);
            if (ProductAmount > 0)
            {
                string SQLLocastion = (@"
                SELECT ProductID FROM Table_Products
                WHERE ProductName LIKE '{0}' AND ProductAmount LIKE {1}");
                string formattedLocation = string.Format(SQLLocastion, ProductName, ProductAmount);
                SqlCommand command = new SqlCommand(formattedLocation, conn);
                SqlDataReader sdr = command.ExecuteReader();
                int id;
                while (sdr.Read())
                {
                    //id = sdr[0];
                    //Console.WriteLine(sdr[0].GetInt32());
                }
                //while (sdr.Read())
                //{
                //    Console.WriteLine(sdr[0]);
                //    //InsertLocation( conn);
                //}

                sdr.Close();

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
            string SQL = (@"
            DELETE FROM Table_Products WHERE ProductID = {0}");
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
                Console.WriteLine("{0,-10} {1,-20}", sdr[0], sdr[1]);
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

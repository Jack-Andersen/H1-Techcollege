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
            SqlCommand command = new SqlCommand(formatted, conn);
            command.ExecuteNonQuery();

        }

        public static void DeleteProduct(int ProductID, SqlConnection conn)
        {
            string SQL = (@"
            DELETE FROM Table_Products WHERE ProductID = {0}");
            string formatted = string.Format(SQL, ProductID);
            Console.WriteLine(formatted);
            SqlCommand command = new SqlCommand(formatted, conn);
            command.ExecuteNonQuery();
        }

        public static void UpdateProduct(int ProductID, string ProductName, int ProductAmount, SqlConnection conn)
        {
            string SQL = (@"
            UPDATE Table_Products SET ProductName = '{0}', ProductAmount = {1} 
            WHERE ProductID = {2}");
            string formatted = string.Format(SQL, ProductName, ProductAmount, ProductID);
            Console.WriteLine(formatted);
            SqlCommand command = new SqlCommand(formatted, conn);
            command.ExecuteNonQuery();
        }

        public static void ShowAllProducts(SqlConnection conn)
        {
        
            string SQL = (@"
            SELECT * FROM Table_Products");
            string formatted = string.Format(SQL);        
            SqlCommand command = new SqlCommand(formatted, conn);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("{0,-10} {1,-20} {2,-10}", sdr[0], sdr[1], sdr[2]);         
           
                //Another way of writing it.
                //Console.WriteLine(sdr[0].ToString() + "\t" + sdr[1] + "\t" + sdr[2]);
            }

            Console.WriteLine("");
            sdr.Close();

            //Another wat of writing it.
            //conn.Close();
            //conn.Open();
        }
    }
}

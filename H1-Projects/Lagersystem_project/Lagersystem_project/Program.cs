using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

namespace Lagersystem_project
{
    class Program
    {
        public static void Main(string[] args)
        {
            Database db = new Database();
            SqlConnection conn = db.connection();
            conn.Open();
            SwitchCase(conn);
        }

        const ConsoleKey keyInfo1 = ConsoleKey.D1;
        const ConsoleKey keyInfo2 = ConsoleKey.D2;
        const ConsoleKey keyInfo3 = ConsoleKey.D3;
        const ConsoleKey keyInfo4 = ConsoleKey.D4;
        const ConsoleKey keyInfo5 = ConsoleKey.D5;
        const ConsoleKey keyInfo6 = ConsoleKey.Escape;

        public static void SwitchCase(SqlConnection conn)
        {

            while (true)
            {

                Methods_And_Functions.Menu();

                ConsoleKey pressedKey = PressedKey(conn);

                switch (pressedKey)
                {

                    case keyInfo1:
                        Console.WriteLine("Press --> Enter <-- without any word to exit");
                        Console.Write("Enter Product name > ");
                        string inputProduct = Console.ReadLine();
                        if (inputProduct != "")
                        {
                            Console.Write("Enter Product Amount > ");
                            int productAmount = int.Parse(Console.ReadLine());
                            Methods_And_Functions.InsertProduct(inputProduct, productAmount, conn);
                            break;
                        }
                        Console.Clear();
                        break;

                    case keyInfo2:
                        Console.WriteLine("Press --> Enter <-- without any number to exit");
                        Console.Write("Specify what ProductID you want to delete > ");
                        string input2 = Console.ReadLine();
                        if (input2 != "")
                        {
                            int productID = int.Parse(input2);
                            Methods_And_Functions.DeleteProduct(productID, conn);
                        }
                        Console.Clear();
                        break;

                    case keyInfo3:
                        Console.WriteLine("Press --> Enter <-- without any number to exit");
                        Console.Write("What ID do you want to update > ");
                        string input3 = Console.ReadLine();          
                        if (input3 != "")
                        {
                            int updateID = int.Parse(input3);
                            Console.Write("What do you want to update your product to > ");
                            string updateProductName = Console.ReadLine();
                            Console.Write("The amount of the specific product > ");
                            int updateProductAmount = int.Parse(Console.ReadLine());
                            Methods_And_Functions.UpdateProduct(updateID, updateProductName, updateProductAmount, conn);
                            break;
                        }
                        Console.Clear();
                        break;

                    case keyInfo4:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("All products\n");
                        Console.WriteLine("{0,-10} {1,-20} {2,-10}", "ProductID:", "ProductName:", "ProductAmount:");
                        Methods_And_Functions.ShowAllProducts(conn);
                        break;

                    case keyInfo5:
                        Console.WriteLine("");
                        Console.WriteLine("All locations of products\n");
                        Console.WriteLine("{0,-10} {1,-20}", "LocationID:", "ProductID:");
                        Methods_And_Functions.ShowAllLocations(conn);
                        break;

                    case keyInfo6:
                            System.Environment.Exit(0);
                        break;
                }
            }
        }
        static ConsoleKey PressedKey(SqlConnection conn)
        {

            List<ConsoleKey> key_Array = new List<ConsoleKey> { keyInfo1, keyInfo2, keyInfo3, keyInfo4, keyInfo5, keyInfo6 };
            ConsoleKey pressed = Console.ReadKey(true).Key;

            do
            {
                while (!key_Array.Contains(pressed))
                {
                    Console.Clear();
                    Methods_And_Functions.Menu();
                    Console.WriteLine("Choose a vaild key!");
                    pressed = Console.ReadKey(true).Key;
                }
                //ConsoleKey pressed = Console.ReadKey(true).Key;
                if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3 || pressed == keyInfo4 || pressed == keyInfo5)
                    return pressed;
                Console.Clear();
            } while (true);
        }
    }
}

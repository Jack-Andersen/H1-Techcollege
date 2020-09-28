using System;
using System.Data.SqlClient;

namespace Lagersystem_project
{
    class Program
    {
        public static void Main(string[] args)
        {

            Database db = new Database();
            SqlConnection conn = db.connection();
            conn.Open();

            bool start = false;
            const ConsoleKey keyInfo1 = ConsoleKey.D1;
            const ConsoleKey keyInfo2 = ConsoleKey.D2;
            const ConsoleKey keyInfo3 = ConsoleKey.D3;
            const ConsoleKey keyInfo4 = ConsoleKey.D4;
            const ConsoleKey keyInfo5 = ConsoleKey.D5;

            while (true)
            {
                if (start == true)
                {
                    Console.WriteLine();
                }
                start = true;

                Console.WriteLine("Menu:");
                Console.WriteLine("Press 1 Insert product.\n" +
                                  "Press 2 Delete product.\n" +
                                  "Press 3 Update product.\n" +
                                  "Press 4 Show all product.\n" +
                                  "Press 5 Show all locations of products\n");

                ConsoleKey pressedKey = PressedKey();

                switch (pressedKey)
                {
                    case keyInfo1:
                        Console.Write("Enter Product name > ");
                        string inputProduct = Console.ReadLine();
                        Console.Write("Enter Product Amount > ");
                        int productAmount = int.Parse(Console.ReadLine());
                        Methods_And_Functions.InsertProduct(inputProduct, productAmount, conn);
                        break;

                    case keyInfo2:
                        Console.Write("Specify what ProductID you want to delete > ");
                        int productID = int.Parse(Console.ReadLine());
                        Methods_And_Functions.DeleteProduct(productID, conn);
                        break;

                    case keyInfo3:
                        Console.Write("What ID do you want to update > ");
                        int updateID = int.Parse(Console.ReadLine());
                        Console.Write("What do you want to update your product to > ");
                        string updateProductName = Console.ReadLine();
                        Console.Write("The amount of the specific product > ");
                        int updateProductAmount = int.Parse(Console.ReadLine());
                        Methods_And_Functions.UpdateProduct(updateID, updateProductName, updateProductAmount, conn);
                        break;

                    case keyInfo4:
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

                }            
            }

            ConsoleKey PressedKey()
            {
                do
                {
                    while (!Console.KeyAvailable) ;
                    ConsoleKey pressed = Console.ReadKey(true).Key;
                    if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3 || pressed == keyInfo4 || pressed == keyInfo5)
                        return pressed;
                    Console.Clear();
                } while (true);
            }
        }    
    }
}

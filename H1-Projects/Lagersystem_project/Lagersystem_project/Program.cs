using System;
using System.Data.SqlClient;
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
                        Console.WriteLine("Press --> Enter <-- without any word to leave");
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
                        Console.WriteLine("Put the value as --> 0 <-- if you want to exit");
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
                        Console.WriteLine("Put the value as --> 0 <-- if you want to exit");
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
        }
        static ConsoleKey PressedKey(SqlConnection conn)
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

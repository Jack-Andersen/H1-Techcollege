using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace School_H2
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
        const ConsoleKey keyInfo3 = ConsoleKey.Escape;

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
                        Console.Write("Enter Student First_Name > ");
                        string FirstName = Console.ReadLine();
                        if (FirstName != "")
                        {
                            Console.Write("Enter Student Last_Name > ");
                            string LastName = Console.ReadLine();
                            Console.Write("Enter Student Age > ");
                            int Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student Class_Id > ");
                            int ClassId = int.Parse(Console.ReadLine());
                            Methods_And_Functions.InsertStudentUnprotected(FirstName, LastName, Age, ClassId, conn);
                            break;
                        }
                        Console.Clear();
                        break;

                    case keyInfo2:
                        Console.WriteLine("Press --> Enter <-- without any word to exit");
                        Console.Write("Enter Student First_Name > ");
                        string protectedFirstName = Console.ReadLine();
                        if (protectedFirstName != "")
                        {
                            Console.Write("Enter Student Last_Name > ");
                            string LastName = Console.ReadLine();
                            Console.Write("Enter Student Age > ");
                            int Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student Class_Id > ");
                            int ClassId = int.Parse(Console.ReadLine());
                            Methods_And_Functions.InsertStudentUnprotected(protectedFirstName, LastName, Age, ClassId, conn);
                            break;
                        }
                        Console.Clear();
                        break;

                    case keyInfo3:
                        System.Environment.Exit(0);
                        break;
                }
            }

            static ConsoleKey PressedKey(SqlConnection conn)
            {

                List<ConsoleKey> key_Array = new List<ConsoleKey> { keyInfo1, keyInfo2, keyInfo3};
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
                    if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3)
                        return pressed;
                    Console.Clear();
                } while (true);
            }
        }
    }
}

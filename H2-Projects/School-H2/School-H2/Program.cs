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
                        Console.Write("Enter Student First_Name > ");
                        string Unprotected_FirstName = Console.ReadLine();
                        if (Unprotected_FirstName != "")
                        {
                            Console.Write("Enter Student Last_Name > ");
                            string LastName = Console.ReadLine();
                            Console.Write("Enter Student Age > ");
                            int Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student Class_Id > ");
                            int ClassId = int.Parse(Console.ReadLine());
                            Methods_And_Functions.InsertStudentUnprotected(Unprotected_FirstName, LastName, Age, ClassId, conn);
                            break;
                        }
                        Console.Clear();
                        break;

                    case keyInfo2:
                        Console.WriteLine("Press --> Enter <-- without any word to exit");
                        Console.Write("Enter Student First_Name > ");
                        string ProtectedFirstName = Console.ReadLine();
                        if (ProtectedFirstName != "")
                        {
                            Console.Write("Enter Student Last_Name > ");
                            string LastName = Console.ReadLine();
                            Console.Write("Enter Student Age > ");
                            int Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student Class_Id > ");
                            int ClassId = int.Parse(Console.ReadLine());
                            Methods_And_Functions.InsertStudentProtected(ProtectedFirstName, LastName, Age, ClassId);
                            break;
                        }
                        Console.Clear();
                        break;

                    case keyInfo3:
                        Console.WriteLine("Press --> Enter <-- without any word to exit");
                        Console.Write("Specify what StudentID you want to delete > ");
                        string InputId = Console.ReadLine();
                        if (InputId != "")
                        {
                            int StudentId = int.Parse(InputId);
                            Methods_And_Functions.DeleteStudent(StudentId, conn);
                            break;
                        }
                        Console.Clear();
                        break;

                    case keyInfo4:
                        Console.WriteLine("Press --> Enter <-- without any word to exit");
                        Console.Write("What ID do you want to update > ");
                        string UpdateStudent = Console.ReadLine();
                        if (UpdateStudent != "")
                        {
                            int UpdateStudentId = int.Parse(UpdateStudent);
                            Console.Write("Enter Student First_Name > ");
                            string First_Name = Console.ReadLine();
                            Console.Write("Enter Student Last_Name > ");
                            string Last_Name = Console.ReadLine();
                            Console.Write("Enter Student Age > ");
                            int Age = int.Parse(Console.ReadLine());
                            Console.Write("Enter Student Class_Id > ");
                            int Class_Id = int.Parse(Console.ReadLine());
                            Methods_And_Functions.UpdateStudent(UpdateStudentId, First_Name, Last_Name, Age, Class_Id, conn);
                            break;
                        }
                        Console.Clear();
                        break;

                    case keyInfo5:
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("All Students\n");
                        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", "StudentID:", "First_Name:", "Last_Name:", "Age:", "Class_ID:");
                        Methods_And_Functions.ShowAllStudents(conn);
                        break;

                    case keyInfo6:
                        System.Environment.Exit(0);
                        break;
                }
            }

            static ConsoleKey PressedKey(SqlConnection conn)
            {

                List<ConsoleKey> key_Array = new List<ConsoleKey> { keyInfo1, keyInfo2, keyInfo3, keyInfo4, keyInfo5, keyInfo6};
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
                    if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3 || pressed == keyInfo4 || pressed == keyInfo5 || pressed == keyInfo6)
                        return pressed;
                    Console.Clear();
                } while (true);
            }
        }
    }
}

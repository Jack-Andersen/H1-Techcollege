using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace School_H2
{
    class Methods_And_Functions
    {
        public static void Menu()
        {
            Console.WriteLine("Menu\n" +
                              "Press 1 Insert UnProtectedStudent.\n" +
                              "Press 2 Insert ProtectedStudent.\n" +
                              "Press Esc to exit the Program.\n");
        }
        public static string InsertStudentUnprotected(string First_Name, string Last_Name, int Age, int Class_Id, SqlConnection conn)
        {
            {
                string SQL = (@" 
                INSERT INTO Students (First_Name, Last_Name, Age, Class_Id)
                VALUES ('{0}', '{1}', {2}, {3})");
                string formatted = string.Format(SQL, First_Name, Last_Name, Age, Class_Id);
                SqlCommand command = new SqlCommand(formatted, conn);
                Console.WriteLine(formatted);
                int result = command.ExecuteNonQuery();

                return result + " rows affected.\n";

                //sqlinjection', 1,2); CREATE TABLE Sqlinjection (Id int);--

            }
        }
        public static void InsertStudentProtected(string First_Name, string Last_Name, int Age, int Class_Id)
        {
            SqlConnection conn = Database.openConnection(); // Åbner forbindelse til databasen

            // Initialiserer en ny instans af SqlClient build-in funktion fra System.Data.SqlClient;
            using SqlCommand command = new SqlCommand(@"
            INSERT INTO Students (First_Name, Last_Name, Age, Class_Id)
            VALUES(@First_Name, @Last_Name, @Age, @Class_Id)", conn);

            {

                command.Parameters.Add("@First_Name", SqlDbType.NVarChar, 32).Value = First_Name;
                command.Parameters.Add("@Last_Name", SqlDbType.NVarChar, 32).Value = Last_Name;
                command.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
                command.Parameters.Add("@Class_Id", SqlDbType.Int).Value = Class_Id;

                command.ExecuteNonQuery();
                conn.Close(); // Lukker forbindelsen til databasen query er kørt.

                // sqlinjection', '1',2,3); UPDATE Students SET [name]='Ayaya' WHERE id=3;--

            }
        }
    }
}

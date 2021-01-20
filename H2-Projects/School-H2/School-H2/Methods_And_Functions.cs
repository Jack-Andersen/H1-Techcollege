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
                              "Press 3 Delete Student.\n" +
                              "Press 4 Update Student.\n" +
                              "press 5 ShowAll Students.\n" +
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

        public static void DeleteStudent(int StudentID, SqlConnection conn)
        {
            {
                string SQL = (@"
                DELETE FROM Students WHERE Id = {0}");
                string formatted = string.Format(SQL, StudentID);
                Console.WriteLine(formatted);
                ExecuteQuery(conn, formatted);
            }
        }

        public static void UpdateStudent(int StudentID, string First_Name, string Last_Name, int Age, int Class_Id, SqlConnection conn)
        {
            string SQL = (@"
            UPDATE Students SET First_Name = '{0}', Last_Name = '{1}', Age = {2}, Class_Id = {3}
            WHERE StudentID = {4}");
            string formatted = string.Format(SQL, First_Name, Last_Name, Age, Class_Id, StudentID);
            Console.WriteLine(formatted);
            ExecuteQuery(conn, formatted);
        }

        public static void ShowAllStudents(SqlConnection conn)
        {

            string SQL = (@"
            SELECT * FROM Students");
            SqlCommand command = new SqlCommand(SQL, conn);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15} {4,-15}", sdr[0], sdr[1], sdr[2], sdr[3], sdr[4]);
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

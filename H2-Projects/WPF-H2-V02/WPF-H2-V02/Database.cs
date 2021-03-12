using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using WPF_H2_V02;

class Database
{

    #region Database_Connection...
    static SqlConnection connection;

    public static bool db_connection(string username, string password)
    {

        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "JACK-ANDERSEN-J";
        builder.InitialCatalog = "School-H2";
        builder.UserID = username;
        builder.Password = password;

        connection = new SqlConnection(builder.ToString());
        try
        {
            connection.Open();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
    #endregion

    #region Insert_Student...
    public static void InsertStudent(Student studentBuffer)
    {

        // Initialiserer en ny instans af SqlClient build-in funktion fra System.Data.SqlClient;
        using SqlCommand command = new SqlCommand(@"
            INSERT INTO Students (First_Name, Last_Name, Age, Class_Id)
            VALUES(@First_Name, @Last_Name, @Age, @Class_Id)", connection);

        {

            command.Parameters.AddWithValue("@First_Name", studentBuffer.First_Name);
            command.Parameters.AddWithValue("@Last_Name", studentBuffer.Last_Name);
            command.Parameters.AddWithValue("@Age", studentBuffer.Age);
            command.Parameters.AddWithValue("@Class_Id", studentBuffer.ClassId);


            command.ExecuteNonQuery();

        }
    }
    #endregion

    #region Insert_Teacher...
    public static void InsertTeacher(Teacher teacherBuffer)
    {

        // Initialiserer en ny instans af SqlClient build-in funktion fra System.Data.SqlClient;
        using SqlCommand command = new SqlCommand(@"
            INSERT INTO Teacher (First_Name, Last_Name, Age, Mail, Phone_Nr, Teacher_Class_Id)
            VALUES(@First_Name, @Last_Name, @Age, @Mail, @Phone_Nr, @Teacher_Class_Id)", connection);

        {

            command.Parameters.AddWithValue("@First_Name", teacherBuffer.First_Name);
            command.Parameters.AddWithValue("@Last_Name", teacherBuffer.Last_Name);
            command.Parameters.AddWithValue("@Age", teacherBuffer.Age);
            command.Parameters.AddWithValue("@Mail", teacherBuffer.Mail);
            command.Parameters.AddWithValue("@Phone_Nr", teacherBuffer.Phone_Nr);
            command.Parameters.AddWithValue("@Teacher_Class_Id", teacherBuffer.ClassId);
            

            command.ExecuteNonQuery();

        }
    }
    #endregion

    #region DataGrid_Students...
    public static List<Student> FillDataGridStudents()
    {

        List<Student> studentsList = new List<Student>();

        string SQL = (@"SELECT Students.Id, First_Name, Last_Name, Age, Class_Room.Name FROM Students
                      INNER JOIN Class_Room On Students.Class_Id = Class_Room.Id");

        SqlCommand command = new SqlCommand(SQL, connection);
        using SqlDataReader reader = command.ExecuteReader();
        {
            while (reader.Read())
            {
                Student student = new Student();
                student.Id = reader.GetInt32(0);
                student.First_Name = reader.GetString(1);
                student.Last_Name = reader.GetString(2);
                student.Age = (int)reader.GetDecimal(3);
                student.ClassName = reader.GetString(4);

                studentsList.Add(student);
            }
            reader.Close();
            return studentsList;
        }
    }
    #endregion

    #region DataGrid_Teachers...
    public static List<Teacher> FillDataGridTeachers()
    {

        List<Teacher> teacherList = new List<Teacher>();

        string SQL = (@"SELECT Teacher.Id, First_Name, Last_Name, Age, Mail, Phone_Nr, Class_Room.Name FROM Teacher
                      INNER JOIN Class_Room On Teacher.Teacher_Class_Id = Class_Room.Id");

        SqlCommand command = new SqlCommand(SQL, connection);
        using SqlDataReader reader = command.ExecuteReader();
        {
            while (reader.Read())
            {
                Teacher teacher = new Teacher();
                teacher.Id = reader.GetInt32(0);
                teacher.First_Name = reader.GetString(1);
                teacher.Last_Name = reader.GetString(2);
                teacher.Age = (int)reader.GetDecimal(3);
                teacher.Mail = reader.GetString(4);
                teacher.Phone_Nr = (int)reader.GetDecimal(5);
                teacher.ClassName = reader.GetString(6);

                teacherList.Add(teacher);
            }
            reader.Close();
            return teacherList;
        }
    }
    #endregion

    #region Fill_ClassIdComboBox...
    public static Dictionary<int, string> Fill_ClassIdComboBox()
    {
        string SQL = (@"SELECT Id, Name FROM Class_Room");

        SqlCommand command = new SqlCommand(SQL, connection);
        using SqlDataReader reader = command.ExecuteReader();
        Dictionary<int, string> classname = new Dictionary<int, string>();
        while (reader.Read())
        {
            classname.Add(reader.GetInt32(0), reader.GetString(1));
        }
        reader.Close();
        return classname;
    }
    #endregion

}
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPF_H2_V02
{
    public partial class AddStudentPage : UserControl
    {

        public static Student studentBuffer { get; set; } = new Student();

        public AddStudentPage()
        {
            InitializeComponent();
            DataContext = studentBuffer;
            Application.Current.Exit += ProgramSaveStudent;

            Dictionary<int, string> className = Database.Fill_ClassIdComboBox();
            ClassId.ItemsSource = className;
        }

        private void ProgramSaveStudent(object sender, ExitEventArgs e)
        {
            Database.InsertStudent(studentBuffer);
        }

        private void Button_Click_Student(object sender, RoutedEventArgs e)
        {
            Database.InsertStudent(studentBuffer);
        }

        
    }
}

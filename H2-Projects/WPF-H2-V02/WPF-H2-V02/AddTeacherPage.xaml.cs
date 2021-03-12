using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WPF_H2_V02
{
    public partial class AddTeacherPage : UserControl
    {

        public static Teacher teacherBuffer { get; set; } = new Teacher();

        public AddTeacherPage()
        {
            InitializeComponent();
            DataContext = teacherBuffer;

            Dictionary<int, string> className = Database.Fill_ClassIdComboBox();
            TeacherClassId.ItemsSource = className;
        }

        private void Button_Click_Teacher(object sender, RoutedEventArgs e)
        {
            Database.InsertTeacher(teacherBuffer);
        }
    }
}

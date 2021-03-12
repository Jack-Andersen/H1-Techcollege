using System.Windows;
using System.Windows.Controls;

namespace WPF_H2_V02
{

    public partial class Menu : UserControl
    {

        MainWindow window;

        public Menu(MainWindow window)
        {
            InitializeComponent();

            this.window = window;

        }

        private void Add_Student_Btn_Click(object sender, RoutedEventArgs e)
        {
            window.AddStudent().Navigate(new AddStudentPage());
        }

        private void Add_Teacher_Btn_Click(object sender, RoutedEventArgs e)
        {
            window.AddTeacher().Navigate(new AddTeacherPage());
        }

        private void See_Students_Btn_Click(object sender, RoutedEventArgs e)
        {
            window.SeeStudents().Navigate(new SeeStudentsPage());
        }

        private void See_Teachers_Btn_Click(object sender, RoutedEventArgs e)
        {
            window.SeeTeachers().Navigate(new SeeTeachersPage());
        }
    }
}

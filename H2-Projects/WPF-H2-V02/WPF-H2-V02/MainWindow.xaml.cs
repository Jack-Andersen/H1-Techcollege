using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows;

namespace WPF_H2_V02
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            Application.Current.Exit += Exit;
            InitializeComponent();

            contentArea.Navigate(new LoginPage(this));
        }

        private void Exit(object sender, ExitEventArgs e)
        {
            MessageBox.Show("You're progress has been saved");
        }

        public void LogedIn()
        {
            contentArea.Navigate(new Menu(this));
        }

        public ContentArea AddStudent()
        {
            return contentArea;
        }

        public ContentArea AddTeacher()
        {
            return contentArea;
        }

        public ContentArea SeeStudents()
        {
            return contentArea;
        }

        public ContentArea SeeTeachers()
        {
            return contentArea;
        }
    }
}

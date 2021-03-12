using System.Windows;
using System.Windows.Controls;

namespace WPF_H2_V02
{
    public partial class LoginPage : UserControl
    {

        MainWindow window;

        public LoginPage(MainWindow window)
        {
            InitializeComponent();

            this.window = window;

        }
        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {

            if (Database.db_connection(txt_UserName.Text, txt_Password.Password))
            {
                txtStatus.Text = "Succes";
                window.LogedIn();
            }
            else
            {
                txtStatus.Text = "Access denied";
            }
        }
    }
}

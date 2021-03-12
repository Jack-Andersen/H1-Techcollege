using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_H2
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
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
                txtStatus.Text = "Fuck mig";
            }
        }
    }
}

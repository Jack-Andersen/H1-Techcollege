using System.Windows;
using System.Windows.Controls;

namespace BankV2.Bank
{
    public partial class ForgotUserLoginPage : UserControl
    {
        MainWindow window;
        public static int Id { get; set; }

        public ForgotUserLoginPage(MainWindow window)
        {
            InitializeComponent();

            this.window = window;
        }

        private void ConfirmPassword_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Return)
            {
                if (Database.GetMail(Mail.ToString()))
                {
                    MessageBox.Show("Invaild Mail");
                }
                else
                {
                    Id = Database.UserIdMail(Mail.Text);
                    passwordMatch();
                    Database.Password(NewPassword.Password, Id);
                }
            }
        }

        private void Back_Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            window.Return().Navigate(new LoginPage(window));
        }

        private bool passwordMatch()
        {
            if (NewPassword.Password != ConfirmPassword.Password)
            {
                MessageBox.Show("Passwords do not match");
                return false;
            }
            else
                return true;
        }
    }
}

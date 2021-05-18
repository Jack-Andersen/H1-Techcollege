using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace BankV2
{
    public partial class LoginPage : UserControl
    {

        readonly MainWindow window;

        public static string name = "...";
        public static int Id { get; set; }
        public static int BalanceId { get; set; }

        public LoginPage(MainWindow window)
        {
            InitializeComponent();

            this.window = window;
        }

        //Password Textbox
        private void PasswordBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Return)
            {
                if (Database.LoginToUser(UserName.Text, Password.Password))
                {
                    Id = Database.UserId(UserName.Text, Password.Password);
                    BalanceId = NewUserPage.userBuffer.Bank_Account.Id = Database.GetBalanceId(Id);
                    NewUserPage.userBuffer.Bank_Account.Balance = Database.GetBalance(BalanceId);

                    if (Database.IdTotal(Id) > 50)
                    {

                        Thread.Sleep(2000);
                        Database.DeleteTable("[Transaction]", LoginPage.Id);
                        Database.DeleteTable("TransactionBalance", LoginPage.Id);

                        //Database.TruncateTable("[Transaction]");
                        //Database.TruncateTable("TransactionBalance");
                    }

                    UpdateName();
                    window.LogedIn();
                }
                else
                {
                    name = "...";
                    MessageBox.Show("Login failed");
                }
            }
        }

        //Updates the Display Name
        public void UpdateName()
        {
            name = UserName.Text;
        }

        //NewUser_Btn
        private void NewUser_Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            window.NewUserPage();
        }

        //Forgot UserName/Password_Btn
        private void Forgot_UserName_Password_Click(object sender, RoutedEventArgs e)
        {
            window.ForgotUserNameAndPassword();
        }

        //Back_Btn
        private void Back_Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            window.Return().Navigate(new MenuPage(window));
        }
    }
}

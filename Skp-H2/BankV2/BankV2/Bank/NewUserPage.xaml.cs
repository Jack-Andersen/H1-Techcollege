using System.Windows;
using System.Windows.Controls;

namespace BankV2
{
    public partial class NewUserPage : UserControl
    {

        readonly MainWindow window;
        public static User userBuffer { get; set; } = new User();

        public NewUserPage(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
            DataContext = userBuffer;
        }

        //NewUser
        private void Password_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Return)
            {
                try
                {
                    Database.NewUser(userBuffer);
                    MessageBox.Show("User was created!");
                    window.LogInPage();
                }
                catch
                {
                    MessageBox.Show("Pls input vaild information");
                }
            }
        }

        //Back_Btn
        private void Back_Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            window.Return().Navigate(new LoginPage(window));
        }
    }
}

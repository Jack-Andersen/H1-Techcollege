using System.Windows;
using System.Windows.Controls;

namespace BankV2
{
    public partial class AboutMePage : UserControl
    {
        
        MainWindow window;
        
        public static User userBuffer { get; set; } = new User();
        public static string password { get; set; }

        public AboutMePage(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
            DataContext = userBuffer;

            //shows the info of the user
            Database.AboutMeInfo(LoginPage.Id);
            Password.Password = password;
        }

        //AboutMe if info gets changed
        private void AboutMe_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Return)
            {
                try
                {
                    Database.AboutMeUpdate(userBuffer, Password.Password, LoginPage.Id);
                    LoginPage.name = UserName.Text;
                    MessageBox.Show("Info Was changed!");
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
            window.Return().Navigate(new MenuPage(window));
        }
    }
}

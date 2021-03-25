using System.Windows.Controls;

namespace BankV2
{
    public partial class MenuPage : UserControl
    {

        MainWindow window;

        public MenuPage(MainWindow window)
        {
            InitializeComponent();

            this.window = window;

        }

        private void Login_Btn_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            window.LogIn().Navigate(new LoginPage(window));
        }
    }
}

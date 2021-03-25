using System.Collections.Generic;
using System.Windows.Controls;

namespace BankV2
{
    public partial class LoginPage : UserControl
    {

        MainWindow window;

        public LoginPage(MainWindow window)
        {
            InitializeComponent();

            this.window = window;
        }

        private void Back_Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            window.Return().Navigate(new MenuPage(window));
        }
    }
}

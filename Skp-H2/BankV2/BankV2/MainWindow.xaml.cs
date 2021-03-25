using System.Windows;

namespace BankV2
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            contentArea.Navigate(new MenuPage(this));

        }

        public void LogedIn()
        {
            contentArea.Navigate(new MenuPage(this));
        }

        public ContentArea LogIn()
        {
            return contentArea;
        }

        public ContentArea NewUser()
        {
            return contentArea;
        }

        public ContentArea Return()
        {
            return contentArea;
        }
    }
}

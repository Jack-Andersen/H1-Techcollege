using BankV2.Shop;
using System.Windows;

namespace BankV2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Database.db_connection();

            contentArea.Navigate(new MenuPage(this));
        }
        
        //Navigate to MenuPage
        public void LogedIn()
        {
            contentArea.Navigate(new MenuPage(this));
        }

        //Navigate to Loginpage
        public void LogInPage()
        {
            contentArea.Navigate(new LoginPage(this));
        }

        //Navigate to NewUserPage
        public void NewUserPage()
        {
            contentArea.Navigate(new NewUserPage(this));
        }

        //Navigate to TransactionOverView
        public void TransactionOverView()
        {
            contentArea.Navigate(new TransactionOverViewPage(this));
        }

        //Navigate to AboutMePage
        public void AboutMePage()
        {
            contentArea.Navigate(new AboutMePage(this));
        }

        public void Shop()
        {
            contentArea.Navigate(new ShopPage(this));
        }

        public void MyShoppingList()
        {
            contentArea.Navigate(new MyShoppingList(this));
        }

        //Navigate to specific ContentArea
        public ContentArea Return()
        {
            return contentArea;
        }
    }
}

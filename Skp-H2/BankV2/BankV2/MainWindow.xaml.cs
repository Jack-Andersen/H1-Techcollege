using BankV2.Bank;
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

        public void TransferMoneyPage()
        {
            contentArea.Navigate(new TransferMoneyPage(this));
        }

        //Navigate to NewUserPage
        public void NewUserPage()
        {
            contentArea.Navigate(new NewUserPage(this));
        }

        //Navigate to ForgotUserLoginPage
        public void ForgotUserNameAndPassword()
        {
            contentArea.Navigate(new ForgotUserLoginPage(this));
        }

        //Navigate to TransactionOverViewPage
        public void TransactionOverView()
        {
            contentArea.Navigate(new TransactionOverViewPage(this));
        }

        //Navigate to AboutMePage
        public void AboutMePage()
        {
            contentArea.Navigate(new AboutMePage(this));
        }

        //Navigate to ShopPage
        public void Shop()
        {
            contentArea.Navigate(new ShopPage(this));
        }

        //Navigate to MyShoppingListPage
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

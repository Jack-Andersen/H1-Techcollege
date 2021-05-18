using System.Collections.Generic;
using System.Windows.Controls;

namespace BankV2
{
    public partial class TransactionOverViewPage : UserControl
    {

        readonly MainWindow window;

        public TransactionOverViewPage(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
            List<Transaction> listPreviousTransactions = Database.GetListTransactions(LoginPage.Id);
            TransactionGrid.ItemsSource = listPreviousTransactions;

            //Balance Display
            if (Balance.Content.ToString() != NewUserPage.userBuffer.Bank_Account.Balance.ToString())
            {
                Balance.Content = decimal.Round(NewUserPage.userBuffer.Bank_Account.Balance, 2).ToString();
            }
        }

        //Back_Btn
        private void Back_Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            window.Return().Navigate(new MenuPage(window));
        }
    }
}

using System;
using System.Windows;
using System.Windows.Controls;

namespace BankV2.Bank
{
    public partial class TransferMoneyPage : UserControl
    {


        readonly MainWindow window;
        public static Transaction transaction { get; set; } = new Transaction();
        public static int receiverId { get; set; }
        public static decimal newBalance { get; set; }

        public TransferMoneyPage(MainWindow window)
        {
            InitializeComponent();

            this.window = window;
        }

        //Send_Btn
        private void Send_Btn_Click(object sender, RoutedEventArgs e)
        {
            decimal receiverBalance = Database.GetReceiverBalance(Convert.ToInt32(PhoneNumber.Text));
            decimal newAmount = Convert.ToDecimal(Amount.Text);

            //calculates the ReceiverBalance
            decimal newReceiverBalance = receiverBalance + newAmount;

            //Checks if you can send the Money
            try
            {
                Database.TransferMoney(newReceiverBalance, Convert.ToInt32(PhoneNumber.Text));
                receiverId = Database.UserIdPhone(Convert.ToInt32(PhoneNumber.Text));

                //Updates the User Balance
                newBalance = NewUserPage.userBuffer.Bank_Account.Withdraw(Convert.ToDecimal(Amount.Text));
                Database.UpdateBalance(newBalance, LoginPage.Id);

                //Code for Transaction and TransactionsBalance
                NewUserPage.userBuffer.Note = "Sended " + Convert.ToDecimal(Amount.Text) + " to ****";
                NewUserPage.userBuffer.Bank_Account.WithdrawInfo(Convert.ToDecimal(Amount.Text), DateTime.Now, NewUserPage.userBuffer.Note);
                Database.NewBalance(newBalance, LoginPage.Id);
                Database.SetListTransactions(Transaction.transactionBuffer, LoginPage.Id);

                //Code for Transaction and TransactionsBalance
                NewUserPage.userBuffer.Note = "Received " + Convert.ToDecimal(Amount.Text) + " from ****";
                NewUserPage.userBuffer.Bank_Account.WithdrawInfo(Convert.ToDecimal(Amount.Text), DateTime.Now, NewUserPage.userBuffer.Note);
                Database.NewBalance(newReceiverBalance, receiverId);
                Database.SetListTransactions(Transaction.transactionBuffer, receiverId);
            }
            catch
            {
                MessageBox.Show("Could not find Phone Number");
            }
        }

        //Back_Btn
        private void Back_Btn_Click(object sender, RoutedEventArgs e)
        {
            window.Return().Navigate(new MenuPage(window));
        }
    }
}

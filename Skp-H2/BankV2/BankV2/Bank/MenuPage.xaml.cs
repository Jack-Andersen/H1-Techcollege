using BankV2.Shop;
using System;
using System.Windows;
using System.Windows.Controls;

namespace BankV2
{
    public partial class MenuPage : UserControl
    {
        readonly MainWindow window;
        private const Visibility visible = Visibility.Visible;
        private const Visibility collapsed = Visibility.Collapsed;     

        public MenuPage(MainWindow window)
        {
            InitializeComponent();

            this.window = window;

            //Name Display
            if (NameDisplay.Content.ToString() != LoginPage.name)
            {
                NameDisplay.Content = LoginPage.name;
            }

            //Balance Display
            if (Balance.Content.ToString() != NewUserPage.userBuffer.Bank_Account.Balance.ToString())
            {
                Balance.Content = decimal.Round(NewUserPage.userBuffer.Bank_Account.Balance, 2).ToString();
            }

            //ComboboxItems
            if (LoginPage.Id != 0)
            {
                Shop_Btn.Visibility = visible;
                TransactionOverView.Visibility = visible;
                AboutMe_Btn.Visibility = visible;
            }
        }

        //Login_Btn
        private void Login_Btn_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            window.LogInPage();
        }

        //TransactionOverView_Btn
        private void TransactionOverView_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            window.TransactionOverView();
        }

        //AboutMePage_Btn
        private void AboutMe_Btn_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            window.AboutMePage();
        }

        //Withdraw_Btn
        private void Withdraw_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginPage.Id != 0)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(WithdrawAndDepositBar.Text, "[^0-9]"))
                {
                    MessageBox.Show("Only enter numbers please.");

                    foreach(char letter in WithdrawAndDepositBar.Text)
                    {
                        WithdrawAndDepositBar.Text = WithdrawAndDepositBar.Text.Remove(WithdrawAndDepositBar.Text.Length - 1);
                    }
                }
                else if (WithdrawAndDepositBar.Text != "")
                {
                    //Code for User Balance
                    decimal newBalance = NewUserPage.userBuffer.Bank_Account.Withdraw(Convert.ToDecimal(WithdrawAndDepositBar.Text));
                    NewUserPage.userBuffer.Bank_Account.Balance = newBalance;
                    Balance.Content = decimal.Round(NewUserPage.userBuffer.Bank_Account.Balance, 2).ToString();
                    Database.UpdateBalance(newBalance, LoginPage.Id);

                    //Code for Transaction and TransactionsBalance
                    NewUserPage.userBuffer.Note = "Withdrew " + Convert.ToDecimal(WithdrawAndDepositBar.Text) + " from the bank";
                    NewUserPage.userBuffer.Bank_Account.MakeWithdrawal(Convert.ToDecimal(WithdrawAndDepositBar.Text), DateTime.Now, NewUserPage.userBuffer.Note);
                    Database.NewBalance(newBalance, LoginPage.Id);
                    Database.SetListTransactions(Transaction.transactionBuffer, LoginPage.Id);
                }              
            }
        }

        //Deposit_Btn
        private void Deposit_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginPage.Id != 0)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(WithdrawAndDepositBar.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");

                    foreach (char letter in WithdrawAndDepositBar.Text)
                    {
                        WithdrawAndDepositBar.Text = WithdrawAndDepositBar.Text.Remove(WithdrawAndDepositBar.Text.Length - 1);
                    }
                }
                else if (WithdrawAndDepositBar.Text != "")
                {
                    //Code for User Balance
                    decimal newBalance = NewUserPage.userBuffer.Bank_Account.Deposit(Convert.ToDecimal(WithdrawAndDepositBar.Text));
                    NewUserPage.userBuffer.Bank_Account.Balance = newBalance;
                    Balance.Content = decimal.Round(NewUserPage.userBuffer.Bank_Account.Balance, 2).ToString();
                    Database.UpdateBalance(newBalance, LoginPage.Id);

                    //Code for Transaction and TransactionsBalance
                    NewUserPage.userBuffer.Note = "Deposited " + Convert.ToDecimal(WithdrawAndDepositBar.Text) + " to the bank" ;
                    NewUserPage.userBuffer.Bank_Account.MakeDeposit(Convert.ToDecimal(WithdrawAndDepositBar.Text), DateTime.Now, NewUserPage.userBuffer.Note);
                    Database.NewBalance(newBalance, LoginPage.Id);
                    Database.SetListTransactions(Transaction.transactionBuffer, LoginPage.Id);
                }
            }
        }

        //Logout_btn
        private void Logout_Btn_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            LoginPage.Id = 0;
            LoginPage.name = "...";
            NameDisplay.Content = LoginPage.name;
            NewUserPage.userBuffer.Bank_Account.Balance = 0;
            Balance.Content = NewUserPage.userBuffer.Bank_Account.Balance;
            Shop_Btn.Visibility = collapsed;
            TransactionOverView.Visibility = collapsed;
            AboutMe_Btn.Visibility = collapsed;
        }

        private void Shop_Btn_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            window.Shop();
        }
    }
}

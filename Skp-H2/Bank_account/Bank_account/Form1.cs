using System;
using System.Windows.Forms;

namespace Bank_account
{
    public partial class Bank_account_form : Form
    {

        Bank_account account = new Bank_account("Jack", 3000);

        public Bank_account_form()
        {
            InitializeComponent();

            Balance_Click(this, null);

        }

        private void Balance_Click(object sender, EventArgs e)
        {
           double bankBalance = account.Getbalance;
           Balance.Text = bankBalance.ToString();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            double withdrawAmount = double.Parse(WithdrawAmountAndDeposit.Text);
            Balance.Text = account.Withdraw(withdrawAmount).ToString();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawAmountAndDeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            
        }
    }
}

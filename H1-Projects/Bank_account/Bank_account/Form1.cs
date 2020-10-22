using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_account
{
    public partial class Bank_account_form : Form
    {

        Bank_account Jack = new Bank_account(3000);

        public Bank_account_form()
        {
            InitializeComponent();

            Balance_Click(this, null);

        }

        private void Balance_Click(object sender, EventArgs e)
        {
           double bankBalance = Jack.Getbalance;
           Balance.Text = bankBalance.ToString();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            double withdrawAmount = double.Parse(WithdrawAmountAndDeposit);
            Balance.Text = Jack.Withdraw(withdrawAmount);
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

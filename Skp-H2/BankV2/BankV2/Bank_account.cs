using System;
using System.Collections.Generic;

namespace Bank_account
{
    public class BankAccount
    {

        public string Number { get; }
        public string Owner { get; set; }
        public double Balance { get; set; }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, double balance)
        {
            this.Owner = name;
            this.Balance = balance;

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public double Withdraw(double withdrawAmount)
        {
            if (Balance <= 0 || Balance - withdrawAmount < 0)
            {
                throw new ArgumentException("You don't have enough money");
            }
            else
            {
                Balance -= withdrawAmount;
                return Balance;
            }
        }

        public double Deposit(double depositAmount)
        {
            Balance += depositAmount;
            return Balance;
        }

        public void Print()
        {
            Balance.ToString();
        }

        public double Getbalance { get => Balance; }
    }
}
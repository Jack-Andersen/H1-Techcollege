using BankV2.Shop;
using System;
using System.Collections.Generic;
using System.Windows;

namespace BankV2
{
    public class BankAccount
    {

        public int Id { get; set; }

        public decimal Balance { get; set; }

        //Money you can take out
        public decimal Withdraw(decimal withdrawAmount)
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

        //Money you can put in
        public decimal Deposit(decimal depositAmount)
        {
            Balance += depositAmount;
            return Balance;
        }

        //Calculates the newBalance
        public void Buy(decimal amount, DateTime date, string note, decimal balance)
        {
            if (balance <= 0 || balance - amount < 0)
            {
                throw new ArgumentException("You don't have enough money");
            }
            else
            {
                decimal newBalance = balance - amount;

                Transaction.TransactionBufferValues(amount, date, note);

                Balance = newBalance;
            }
        }

        //Calculates the newBalance
        public void Sell(decimal amount, DateTime date, string note, decimal balance)
        {
            decimal newBalance = balance + amount;

            Transaction.TransactionBufferValues(amount, date, note);

            Balance = newBalance;
        }

        //Gets info from withdraw
        public void WithdrawInfo(decimal amount, DateTime date, string note)
        {
            Transaction.TransactionBufferValues(amount, date, note);
        }

        //Gets info from Deposit 
        public void DepositInfo(decimal amount, DateTime date, string note)
        {
            Transaction.TransactionBufferValues(amount, date, note);
        }

        //Prints the Balance
        public void Print()
        {
            Balance.ToString();
        }

        // lav en metode som sender - Amount
        // modtager + amount
    }
}
using System;

namespace BankV2
{
    public class Transaction
    {

        // Transaction info storage
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; }

        public static Transaction transactionBuffer { get; set; } = new Transaction();

        // Used to get the Balance to Database from BankAccount balance
        public BankAccount Bank_Account { get; set; } = new BankAccount();

        //TransactionsBuffer Info 
        public static void TransactionBufferValues(decimal amount, DateTime date, string note)
        {
            transactionBuffer.Amount = amount;
            transactionBuffer.Note = note;
            transactionBuffer.Date = date;
        }
    }
}
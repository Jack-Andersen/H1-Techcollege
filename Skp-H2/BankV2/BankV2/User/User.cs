using System;
using System.Collections.Generic;
using System.Text;

namespace BankV2
{
    public class User
    {
        // User info storage
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Mail { get; set; }
        public int? PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Note { get; set; }

        // Used to get the Id and balance to NewUserPage from BankAccount Id, balance
        public BankAccount Bank_Account { get; set; } = new BankAccount();
    }
}

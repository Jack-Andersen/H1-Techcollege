using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Vehicles_heritage.AuctionHouse_AH
{
    abstract class User : ISellerModel, IBuyerModel
    {

        public decimal Balance = 0.00M;

        public User(string firstName,
            string lasteName,
            string address,
            int phoneNumber,
            int zipCode,
            decimal balance)
        {
            this.FirstName = firstName;
            this.LastName = lasteName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.ZipCode = zipCode;
            this.Balance = balance;
        }

        //fields and probertys
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null)
                {
                    throw new Exception($"{nameof(value)}");
                }
                firstName = value;
            }
        }
        private string firstName;

        private string LastName 
        {
            get { return lastName; }
            set
            {
                if (value == null)
                {
                    throw new Exception($"{nameof(value)}");
                }
                lastName = value;
            }
        }
        private string lastName;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string address;        

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                var r = new Regex(@"^\d{8}$");
                if (!r.IsMatch(value.ToString()))
                {
                    throw new Exception("phoneNumber er ikke gyldigt!");
                }
                phoneNumber = value;
            }
        }
        private int phoneNumber;

        public int ZipCode 
        {
            get { return zipCode; }
            set
            {
                var r = new Regex(@"^\d{4}$");
                if (!r.IsMatch(value.ToString()))
                {
                    throw new Exception("zipcode er ikke gyldigt");
                }
                zipCode = value;
            }
        }
        public int zipCode;

        decimal IBuyerModel.Balance 
        {   
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        //Method for better offer
        public string BidNotification()
        {
            //return "A new offer for: " +  + "\nPrize offered = " +  
            throw new NotImplementedException();
        }

        //Returns the User in a string
        public new virtual string ToString()
        {
            return String.Format(" {0}: {1}\n {2}: {3}\n {4}: {5}\n {6}:\n {7}: {8}\n {9}: {10}\n {11}:",
                nameof(this.FirstName),
                this.FirstName,
                nameof(this.LastName),
                this.LastName,
                nameof(this.Address),
                this.Address,
                nameof(this.PhoneNumber),
                this.PhoneNumber,
                nameof(this.ZipCode),
                this.ZipCode,
                nameof(this.Balance),
                this.Balance
                );
        }
    }

    class CorporateUser : User
    {
        public CorporateUser(string firstName,
            string lastName,
            string address,
            int phoneNumber,
            int zipCode,
            decimal balance,
            int cvrNumber,
            int credit) : base (firstName, lastName, address, phoneNumber, zipCode, balance)
        {
            this.CVRNumber = cvrNumber;
            this.Credit = credit;
        }

        //fields and probertys
        public int CVRNumber
        {
            get { return cvrNumber; }
            set
            {
                var r = new Regex(@"^\d{8}$");
                if (!r.IsMatch(value.ToString()))
                {
                    throw new Exception("cvrNumber er ikke gyldigt");
                }
                cvrNumber = value;
            }
        }
        public int cvrNumber;

        public int Credit
        {
            get { return credit; }
            set { credit = value; }
        }
        public int credit;

        //Returns the CorporateUser in a string
        public override string ToString()
        {
            return base.ToString() + String.Format(" {0}: {1}\n {2}: {3}\n ",
                nameof(this.CVRNumber),
                this.CVRNumber,
                nameof(this.Credit),
                this.Credit
                );
        }
    }

    class PrivateUser : User
    {
        public PrivateUser(string firstName,
            string lastName,
            string address,
            int phoneNumber,
            int zipCode,
            decimal balance,
            int cprNumber) : base(firstName, lastName, address, phoneNumber, zipCode, balance)
        {
            this.CPRNumber = cprNumber;
        }

        //fields and probertys
        public int CPRNumber
        {
            get { return cprNumber; }
            set
            {
                var r = new Regex(@"^\d{10}$");
                if (!r.IsMatch(value.ToString()))
                {
                    throw new Exception("cprNumber er ikke gyldigt");
                }
                cprNumber = value;
            }
        }
        public int cprNumber;

        //Returns the PrivateUser in a string
        public override string ToString()
        {
            return base.ToString() + String.Format(" {0}: {1}\n",
                nameof(this.CPRNumber),
                this.CPRNumber
                );
        }
    }
}
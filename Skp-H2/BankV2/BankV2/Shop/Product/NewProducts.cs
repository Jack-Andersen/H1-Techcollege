using System;
using System.Collections.Generic;
using System.Text;

namespace BankV2.Shop.Product
{
    public abstract class NewProducts
    {
        public string Name { get; protected set; }
        public int? Amount { get; protected set; }

        public void CountAmount()
        {
            Amount += 1;
        }
        public virtual string ToString()
        {
            if (Amount == 0)
                return "";
            else
            {          /*Returns the itemAmount and checks if itemName
                       exist and adds an s + " " if there is more than 1 of the same itemType.*/
                return (Amount + " " +
                       (Name == Name || Name == "" ? Name : string.Empty) +
                       (Amount > 1 || Amount == 0 ? "s" : string.Empty) +
                       (Amount > 0 || Amount == 0 ? " " : string.Empty.ToString()));
            }
        }
    }

    class Apple : NewProducts
    {
        public Apple()
        {
            Name = "Apple";
            Amount = 0;
        }
    }

    class Bread : NewProducts
    {

        public Bread()
        {
            Name = "Bread";
            Amount = 0;
        }
    }

    class Donut : NewProducts
    {
        public Donut()
        {
            Name = "Donut";
            Amount = 0;
        }
    }
}

namespace BankV2.Shop
{
    public class Shop
    {

        // Shop info storage
        public int Id { get; set; }
        public int Apple { get; set; }
        public int Bread { get; set; }
        public int Dount { get; set; }
        public decimal Cost { get; set; }
        public int PersonId { get; set; }
        public string Items { get; set; }

        // Used to get the Balance to Database from BankAccount balance
        public BankAccount Bank_Account { get; set; } = new BankAccount();

        //The total cost
        public decimal Total(int apple, int bread, int dount)
        {
            int applePrice = 5;
            int breadPrice = 10;
            int dountPrice = 15;

            Cost = (apple * applePrice ) + (bread * breadPrice ) + (dount * dountPrice);
            return Cost;
        }

    }
}

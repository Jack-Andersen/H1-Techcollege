using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BankV2.Shop
{
    public partial class ShopPage : UserControl
    {
        MainWindow window;

        public static Shop ShopBuffer { get; set; } = new Shop();

        public static int Counter = 0;

        public static string[] itemsInShopStr = new string[] { "Apple", "Bread", "Dount" };
        public static int[] itemsInShopInt = new int[] { 0, 0, 0 };

        public ShopPage(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
            if (LoginPage.Id != 0)
            {
                if (!Database.DeosExists(LoginPage.Id))
                {
                    Database.InsertItem(ShopBuffer, LoginPage.Id);
                }
                else
                    NumberOfItems.Text = Counter.ToString();
            }
        }

        //Apple_Btn
        private void Apple_Click(object sender, RoutedEventArgs e)
        {
            if (LoginPage.Id != 0)
            {
                if (Counter <= 98)
                {
                    Counter++.ToString();
                    ShopBuffer.Apple++;
                    Database.UpdateItem(ShopBuffer, LoginPage.Id);
                    NumberOfItems.Text = Counter.ToString();
                    ArrayCount(itemsInShopStr[0]);
                }
            }
        }

        //Bread_Btn
        private void Bread_Click(object sender, RoutedEventArgs e)
        {
            if (LoginPage.Id != 0)
            {
                if (Counter <= 98)
                {
                    Counter++.ToString();
                    ShopBuffer.Bread++;
                    Database.UpdateItem(ShopBuffer, LoginPage.Id);
                    NumberOfItems.Text = Counter.ToString();
                    ArrayCount(itemsInShopStr[1]);
                }
            }
        }

        //Dount_Btn
        private void Donut_Click(object sender, RoutedEventArgs e)
        {
            if (LoginPage.Id != 0)
            {
                if (Counter <= 98)
                {
                    Counter++.ToString();
                    ShopBuffer.Dount++;
                    Database.UpdateItem(ShopBuffer, LoginPage.Id);
                    NumberOfItems.Text = Counter.ToString();
                    ArrayCount(itemsInShopStr[2]);
                }
            }
        }

        //MyShoppingList_Btn
        private void MyShoppingList_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ShopBuffer.Total(Convert.ToDecimal(ShopBuffer.Apple), Convert.ToDecimal(ShopBuffer.Bread), Convert.ToDecimal(ShopBuffer.Dount));
            Database.UpdateItem(ShopBuffer, LoginPage.Id);
            window.MyShoppingList();
        }

        //Back_Btn
        private void Back_Btn_Click(object sender, RoutedEventArgs e)
        {
            window.Return().Navigate(new MenuPage(window));
        }

        //Checks array for type and increment itemsInShopInt Arrayet med 1
        public void ArrayCount(string type)
        {
            if (type == "Apple")
            {
                itemsInShopInt[0]++;
            }
            else if (type == "Bread")
            {
                itemsInShopInt[1]++;
            }
            else
                itemsInShopInt[2]++;
        }

        //Checks What items doesn't contain anything in array and prints out the outcome
        public static void Total()
        {
            if (itemsInShopInt[1] == 0 && itemsInShopInt[2] == 0)
            {
                ShopBuffer.ItemBought = "Bought " + itemsInShopInt[0] + " " + itemsInShopStr[0];
            }
            else if (itemsInShopInt[0] == 0 && itemsInShopInt[2] == 0)
            {
                ShopBuffer.ItemBought = "Bought " + itemsInShopInt[1] + " " + itemsInShopStr[1];
            }
            else if (itemsInShopInt[0] == 0 && itemsInShopInt[1] == 0)
            {
                ShopBuffer.ItemBought = "Bought " + itemsInShopInt[2] + " " + itemsInShopStr[2];
            }
            else if (itemsInShopInt[2] == 0)
            {
                ShopBuffer.ItemBought = "Bought " + itemsInShopInt[0] + " " + itemsInShopStr[0] + ", " + itemsInShopInt[1] + " " + itemsInShopStr[1];
            }
            else if (itemsInShopInt[1] == 0)
            {
                ShopBuffer.ItemBought = "Bought " + itemsInShopInt[0] + " " + itemsInShopStr[0] + ", " + itemsInShopInt[2] + " " + itemsInShopStr[2];
            }
            else if (itemsInShopInt[0] == 0)
            {
                ShopBuffer.ItemBought = "Bought " + itemsInShopInt[1] + " " + itemsInShopStr[1] + ", " + itemsInShopInt[2] + " " + itemsInShopStr[2];
            }
            else
                ShopBuffer.ItemBought = "Bought " + itemsInShopInt[0] + " " + itemsInShopStr[0] + ", " + itemsInShopInt[1] + " " + itemsInShopStr[1] + ", " + itemsInShopInt[2] + ' ' + itemsInShopStr[2];
        }
    }
}

using BankV2.Shop.Product;
using System.Collections.Generic;
using System.Linq;
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
        public static bool SellItemsBool { get; set; }

        public static List<NewProducts> Item { get; set; } = new List<NewProducts>();

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
            CheckBoxInfo();
        }

        //Apple_Btn
        private void Apple_Click(object sender, RoutedEventArgs e)
        {
            if (LoginPage.Id != 0)
            {
                if (Counter <= 98)
                {
                    int index = 0;

                    //Checks the list to see if the item already exisit if not == null and adds the the item
                    if (Item.FirstOrDefault(a => a.GetType().Name.ToString() == "Apple") == null)
                        Item.Add(new Apple());

                    //finds the index/position where "Name" == item and stops the loop
                    for (int i = 0; i < Item.Count; i++)
                    {
                        index = i;

                        if (Item[i].GetType().Name.ToString() == "Apple")
                        {
                            break;
                        }
                    }

                    //takes the position from index and adds 1 to the amount
                    Item[index].CountAmount();
                    Counter++.ToString();
                    ShopBuffer.Apple++;
                    Database.UpdateItem(ShopBuffer, LoginPage.Id);
                    NumberOfItems.Text = Counter.ToString();
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

                    int index = 0;

                    //Checks the list to see if the item already exisit if not == null and adds the the item
                    if (Item.FirstOrDefault(a => a.GetType().Name.ToString() == "Bread") == null)
                        Item.Add(new Bread());

                    //finds the index/position where "Name" == item and stops the loop
                    for (int i = 0; i < Item.Count; i++)
                    {
                        index = i;

                        if (Item[i].GetType().Name.ToString() == "Bread")
                        {
                            break;
                        }
                    }

                    //takes the position from index and adds 1 to the amount
                    Item[index].CountAmount();
                    Counter++.ToString();
                    ShopBuffer.Bread++;
                    Database.UpdateItem(ShopBuffer, LoginPage.Id);
                    NumberOfItems.Text = Counter.ToString();
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
                    int index = 0;

                    //Checks the list to see if the item already exisit if not == null and adds the the item
                    if (Item.FirstOrDefault(a => a.GetType().Name.ToString() == "Donut") == null)
                        Item.Add(new Donut());

                    //finds the index/position where "Name" == item and stops the loop
                    for (int i = 0; i < Item.Count; i++)
                    {
                        index = i;

                        if (Item[i].GetType().Name.ToString() == "Donut")
                        {
                            break;
                        }
                    }

                    //takes the position from index and adds 1 to the amount
                    Item[index].CountAmount();
                    Counter++.ToString();
                    ShopBuffer.Dount++;
                    Database.UpdateItem(ShopBuffer, LoginPage.Id);
                    NumberOfItems.Text = Counter.ToString();
                }
            }
        }

        //Sell if checked
        private void Sell_Checked(object sender, RoutedEventArgs e)
        {
            SellItemsBool = true;
        }

        //Sell if unchecked
        private void Sell_Unchecked(object sender, RoutedEventArgs e)
        {
            SellItemsBool = false;
        }

        //MyShoppingList_Btn
        private void MyShoppingList_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ShopBuffer.Total(ShopBuffer.Apple, ShopBuffer.Bread, ShopBuffer.Dount);
            Database.UpdateItem(ShopBuffer, LoginPage.Id);
            window.MyShoppingList();
        }

        //Back_Btn
        private void Back_Btn_Click(object sender, RoutedEventArgs e)
        {
            window.Return().Navigate(new MenuPage(window));
        }

        //CheckBox info
        public void CheckBoxInfo()
        {
            if (SellItemsBool == true)
            {
                Sell.IsChecked = true;
            }
            else
                Sell.IsChecked = false;
        }

        //Checks array for type and increment itemsInShopInt Arrayet med 1
        //public void ArrayCount(string type)
        //{
        //    if (type == "Apple")
        //    {
        //        if (itemsInShopInt[0] == null)
        //        {
        //            itemsInShopInt[0] = 0;
        //        }
        //        itemsInShopInt[0]++;
        //    }
        //    else if (type == "Bread")
        //    {
        //        if (itemsInShopInt[1] == null)
        //        {
        //            itemsInShopInt[1] = 0;
        //        }
        //        itemsInShopInt[1]++;
        //    }
        //    else
        //    {
        //        if (itemsInShopInt[2] == null)
        //        {
        //            itemsInShopInt[2] = 0;
        //        }
        //        itemsInShopInt[2]++;
        //    }
        //}

        //Checks What items doesn't contain anything in array and prints out the outcome
        public static void Total()
        {

            if (Item.Count != 0 && SellItemsBool != true)
            {
                ShopBuffer.Items = "Bought ";
            }
            else
                ShopBuffer.Items = "Sold ";

            foreach (NewProducts products in Item)
            {
                ShopBuffer.Items += products.ToString();
            }

        }

        //Item[0].Amount = itemsInShopInt[0];
        //Item[1].Amount = itemsInShopInt[1];
        //Item[2].Amount = itemsInShopInt[2];

        //ShopBuffer.Items = string.Format("Bought " +
        //    Item[0].ToString() + " " +
        //    Item[1].ToString() + " " +
        //    Item[2].ToString());

        //int? appleAmount = itemsInShopInt[0];
        //string appleName = itemsInShopStr[0];
        //int? breadAmount = itemsInShopInt[1];
        //string breadName = itemsInShopStr[1];
        //int? dountAmount = itemsInShopInt[2];
        //string dountName = itemsInShopStr[2];

        //ShopBuffer.Items = string.Format("Bought" +" {0} {1}{2} " +
        //        "{3} {4}{5} " +
        //        "{6} {7}{8}",
        //    appleAmount > 0 || appleAmount == 0 ? appleAmount : null, appleName == "Apple" || appleName == "" ? appleName : string.Empty, appleAmount > 1 || appleAmount == 0 ? "s" : string.Empty,
        //    breadAmount > 0 || breadAmount == 0 ? breadAmount : null, breadName == "Bread" || breadName == "" ? breadName : string.Empty, breadAmount > 1 || breadAmount == 0 ? "s" : string.Empty,
        //    dountAmount > 0 || dountAmount == 0 ? dountAmount : null, dountName == "Dount" || dountName == "" ? dountName : string.Empty, dountAmount > 1 || dountAmount == 0 ? "s" : string.Empty);

        //if (SellItemsBool != true)
        //{
        //    if (itemsInShopInt[1] == 0 && itemsInShopInt[2] == 0)
        //    {
        //        ShopBuffer.Items = Buying + itemsInShopInt[0] + " " + itemsInShopStr[0];
        //        int amount = itemsInShopInt[0];
        //        ShopBuffer.Items = string.Format("Bought {0} " + itemsInShopStr[0] + "{1}", amount, amount > 1 || amount == 0 ? "s" : string.Empty);
        //    }
        //    else if (itemsInShopInt[0] == 0 && itemsInShopInt[2] == 0)
        //    {
        //        ShopBuffer.Items = Buying + itemsInShopInt[1] + " " + itemsInShopStr[1];
        //    }
        //    else if (itemsInShopInt[0] == 0 && itemsInShopInt[1] == 0)
        //    {
        //        ShopBuffer.Items = Buying + itemsInShopInt[2] + " " + itemsInShopStr[2];
        //    }
        //    else if (itemsInShopInt[2] == 0)
        //    {
        //        ShopBuffer.Items = Buying + itemsInShopInt[0] + " " + itemsInShopStr[0] + ", " + itemsInShopInt[1] + " " + itemsInShopStr[1];
        //    }
        //    else if (itemsInShopInt[1] == 0)
        //    {
        //        ShopBuffer.Items = Buying + itemsInShopInt[0] + " " + itemsInShopStr[0] + ", " + itemsInShopInt[2] + " " + itemsInShopStr[2];
        //    }
        //    else if (itemsInShopInt[0] == 0)
        //    {
        //        ShopBuffer.Items = Buying + itemsInShopInt[1] + " " + itemsInShopStr[1] + ", " + itemsInShopInt[2] + " " + itemsInShopStr[2];
        //    }
        //    else
        //        ShopBuffer.Items = Buying + itemsInShopInt[0] + " " + itemsInShopStr[0] + ", " + itemsInShopInt[1] + " " + itemsInShopStr[1] + ", " + itemsInShopInt[2] + ' ' + itemsInShopStr[2];
        //}
        //else
        //{
        //    if (itemsInShopInt[1] == 0 && itemsInShopInt[2] == 0)
        //    {
        //        ShopBuffer.Items = Selling + itemsInShopInt[0] + " " + itemsInShopStr[0];
        //    }
        //    else if (itemsInShopInt[0] == 0 && itemsInShopInt[2] == 0)
        //    {
        //        ShopBuffer.Items = Selling + itemsInShopInt[1] + " " + itemsInShopStr[1];
        //    }
        //    else if (itemsInShopInt[0] == 0 && itemsInShopInt[1] == 0)
        //    {
        //        ShopBuffer.Items = Selling + itemsInShopInt[2] + " " + itemsInShopStr[2];
        //    }
        //    else if (itemsInShopInt[2] == 0)
        //    {
        //        ShopBuffer.Items = Selling + itemsInShopInt[0] + " " + itemsInShopStr[0] + ", " + itemsInShopInt[1] + " " + itemsInShopStr[1];
        //    }
        //    else if (itemsInShopInt[1] == 0)
        //    {
        //        ShopBuffer.Items = Selling + itemsInShopInt[0] + " " + itemsInShopStr[0] + ", " + itemsInShopInt[2] + " " + itemsInShopStr[2];
        //    }
        //    else if (itemsInShopInt[0] == 0)
        //    {
        //        ShopBuffer.Items = Selling + itemsInShopInt[1] + " " + itemsInShopStr[1] + ", " + itemsInShopInt[2] + " " + itemsInShopStr[2];
        //    }
        //    else
        //        ShopBuffer.Items = Selling + itemsInShopInt[0] + " " + itemsInShopStr[0] + ", " + itemsInShopInt[1] + " " + itemsInShopStr[1] + ", " + itemsInShopInt[2] + ' ' + itemsInShopStr[2];
        //}
    }
}

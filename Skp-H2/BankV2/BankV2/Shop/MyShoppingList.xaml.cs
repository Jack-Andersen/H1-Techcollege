using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace BankV2.Shop
{
    public partial class MyShoppingList : UserControl
    {

        MainWindow window;

        public static Inventory InventoryBuffer { get; set; } = new Inventory();

        private const Visibility visible = Visibility.Visible;
        private const Visibility collapsed = Visibility.Collapsed;

        public MyShoppingList(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
            List<Shop> listPreviousTransactions = Database.SelectItem(LoginPage.Id);
            ShoppingGrid.ItemsSource = listPreviousTransactions;
            ShopPage.Total();          
            CheckVisibility();       
        }

        //Buy_Btn
        private void Buy_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ShopPage.ShopBuffer.Apple <= 0 && ShopPage.ShopBuffer.Bread <= 0 && ShopPage.ShopBuffer.Dount <= 0)                       
            {
                MessageBox.Show("You Can't buy nothing!");
            }
            else
            {
                //Code for Transaction and TransactionsBalance           
                NewUserPage.userBuffer.Bank_Account.Buy(ShopPage.ShopBuffer.Cost, DateTime.Now, ShopPage.ShopBuffer.Items, NewUserPage.userBuffer.Bank_Account.Balance);
                Database.NewBalance(NewUserPage.userBuffer.Bank_Account.Balance, LoginPage.Id);
                Database.UpdateBalance(NewUserPage.userBuffer.Bank_Account.Balance, LoginPage.Id);
                Database.SetListTransactions(Transaction.transactionBuffer, LoginPage.Id);

                //Gets the Inventory and inputs the values and updates the values
                Database.SelectInventory(LoginPage.Id);
                List<Inventory> userIventoryValues = InventoryBuffer.InventoryValuesBuying(Convert.ToDecimal(InventoryBuffer.Apple), Convert.ToDecimal(InventoryBuffer.Bread), Convert.ToDecimal(InventoryBuffer.Dount));
                Database.UpdateInventory(userIventoryValues, LoginPage.Id);
            }
            ClearShoppingGrid();
            window.Shop();

        }

        //Sell_Btn
        private void Sell_Btn_Click(object sender, RoutedEventArgs e)
        {
            //Gets the Inventory and inputs the values and updates the values
            Database.SelectInventory(LoginPage.Id);
            if (InventoryBuffer.Apple < 0 || InventoryBuffer.Bread < 0 || InventoryBuffer.Dount < 0
                            || InventoryBuffer.Apple - ShopPage.ShopBuffer.Apple < 0 || InventoryBuffer.Bread - ShopPage.ShopBuffer.Bread < 0 || InventoryBuffer.Dount - ShopPage.ShopBuffer.Dount < 0)
            {
                MessageBox.Show("You don't have enough items!");
            }
            else
            {
                List<Inventory> userIventoryValues = InventoryBuffer.InventoryValuesSelling(Convert.ToDecimal(InventoryBuffer.Apple), Convert.ToDecimal(InventoryBuffer.Bread), Convert.ToDecimal(InventoryBuffer.Dount));
                Database.UpdateInventory(userIventoryValues, LoginPage.Id);

                //Code for Transaction and TransactionsBalance
                NewUserPage.userBuffer.Bank_Account.Sell(ShopPage.ShopBuffer.Cost, DateTime.Now, ShopPage.ShopBuffer.Items, NewUserPage.userBuffer.Bank_Account.Balance);
                Database.NewBalance(NewUserPage.userBuffer.Bank_Account.Balance, LoginPage.Id);
                Database.UpdateBalance(NewUserPage.userBuffer.Bank_Account.Balance, LoginPage.Id);
                Database.SetListTransactions(Transaction.transactionBuffer, LoginPage.Id);
            }
            ClearShoppingGrid();
            window.Shop();
        }

        //Clear ShoppingGrid
        private void Clear_Btn_Click(object sender, RoutedEventArgs e)
        {
            ClearShoppingGrid();

            window.MyShoppingList();
        }

        //Back_Btn
        private void Back_Btn_Click(object sender, RoutedEventArgs e)
        {
            window.Return().Navigate(new ShopPage(window));
        }

        //Check Visibility
        public void CheckVisibility()
        {
            if (ShopPage.SellItemsBool != true)
            {
                Buy_Btn.Visibility = visible;
                BuyBorder.Visibility = visible;
                Sell_Btn.Visibility = collapsed;
                SellBorder.Visibility = collapsed;
            }
            else
            {
                Buy_Btn.Visibility = collapsed;
                BuyBorder.Visibility = collapsed;
                Sell_Btn.Visibility = visible;
                SellBorder.Visibility = visible;
            }
        }

        //Clear ShoppingGrid Method
        public void ClearShoppingGrid()
        {
            ShopPage.Counter = 0;
            ShopPage.ShopBuffer.Apple = 0;
            ShopPage.ShopBuffer.Bread = 0;
            ShopPage.ShopBuffer.Dount = 0;

            Database.UpdateItem(ShopPage.ShopBuffer, LoginPage.Id);

            ShopPage.Item.Clear();
        }
    }
}

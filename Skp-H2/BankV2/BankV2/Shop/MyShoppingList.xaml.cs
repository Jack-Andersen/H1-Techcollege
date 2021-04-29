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

        public MyShoppingList(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
            List<Shop> listPreviousTransactions = Database.SelectItem(LoginPage.Id);
            ShoppingGrid.ItemsSource = listPreviousTransactions;
            ShopPage.Total();
        }

        //Buy_Btn
        private void Buy_Btn_Click(object sender, RoutedEventArgs e)
        {
            //Code for Transaction and TransactionsBalance
            NewUserPage.userBuffer.Bank_Account.Buy(ShopPage.ShopBuffer.Cost, DateTime.Now, ShopPage.ShopBuffer.ItemBought, NewUserPage.userBuffer.Bank_Account.Balance);
            Database.NewBalance(NewUserPage.userBuffer.Bank_Account.Balance, LoginPage.Id);
            Database.UpdateBalance(NewUserPage.userBuffer.Bank_Account.Balance, LoginPage.Id);
            Database.SetListTransactions(Transaction.transactionBuffer, LoginPage.Id);

            //Gets the Inventory and inputs the values and updates the values
            Database.SelectInventory(LoginPage.Id);
            List<Inventory> userIventoryValues = InventoryBuffer.InventoryValues(Convert.ToDecimal(InventoryBuffer.Apple), Convert.ToDecimal(InventoryBuffer.Bread), Convert.ToDecimal(InventoryBuffer.Dount));
            Database.UpdateInventory(userIventoryValues, LoginPage.Id);
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

        //Clear ShoppingGrid Method
        public void ClearShoppingGrid()
        {
            ShopPage.Counter = 0;
            ShopPage.ShopBuffer.Apple = 0;
            ShopPage.ShopBuffer.Bread = 0;
            ShopPage.ShopBuffer.Dount = 0;

            Database.UpdateItem(ShopPage.ShopBuffer, LoginPage.Id);
        }
    }
}

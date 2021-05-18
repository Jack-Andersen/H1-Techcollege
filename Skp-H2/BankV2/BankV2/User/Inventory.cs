using BankV2.Shop;
using System;
using System.Collections.Generic;
using System.Windows;

namespace BankV2
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Apple { get; set; }
        public int Bread { get; set; }
        public int Dount { get; set; }
        public decimal PersonId { get; set; }

        public List<Inventory> InventoryValuesBuying(decimal inventoryApple, decimal inventoryBread, decimal inventoryDount)
        {

            List<Inventory> inventoryList = new List<Inventory>();

            int shopApple = ShopPage.ShopBuffer.Apple;
            int shopBread = ShopPage.ShopBuffer.Bread;
            int shopDount = ShopPage.ShopBuffer.Dount;

            Inventory item = new Inventory();

            item.Apple = ((int)(inventoryApple + shopApple));
            item.Bread = ((int)(inventoryBread + shopBread));
            item.Dount = ((int)(inventoryDount + shopDount));

            inventoryList.Add(item);
            return inventoryList;
        }

        public List<Inventory> InventoryValuesSelling(decimal inventoryApple, decimal inventoryBread, decimal inventoryDount)
        {

            List<Inventory> inventoryList = new List<Inventory>();

            int shopApple = ShopPage.ShopBuffer.Apple;
            int shopBread = ShopPage.ShopBuffer.Bread;
            int shopDount = ShopPage.ShopBuffer.Dount;

            Inventory item = new Inventory();

            item.Apple = ((int)(inventoryApple - shopApple));
            item.Bread = ((int)(inventoryBread - shopBread));
            item.Dount = ((int)(inventoryDount - shopDount));

            inventoryList.Add(item);
            return inventoryList;
        }
    }
}

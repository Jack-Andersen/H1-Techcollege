using BankV2.Shop;
using System.Collections.Generic;

namespace BankV2
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Apple { get; set; }
        public int Bread { get; set; }
        public int Dount { get; set; }
        public decimal PersonId { get; set; }

        public List<Inventory> InventoryValues(decimal inventoryapple, decimal inventorybread, decimal inventorydount)
        {

            List<Inventory> inventoryList = new List<Inventory>();

            int shopApple = ShopPage.ShopBuffer.Apple;
            int shopBread = ShopPage.ShopBuffer.Bread;
            int shopDount = ShopPage.ShopBuffer.Dount;

            Inventory item = new Inventory();

            item.Apple = ((int)(inventoryapple + shopApple));
            item.Bread = ((int)(inventorybread + shopBread));
            item.Dount = ((int)(inventorydount + shopDount));

            inventoryList.Add(item);
            return inventoryList;
        }
    }
}

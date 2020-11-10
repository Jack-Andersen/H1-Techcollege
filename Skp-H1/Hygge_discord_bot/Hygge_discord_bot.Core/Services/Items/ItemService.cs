using Hygge_discord_bot.DAL.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hygge_discord_bot.Core.Services.Items
{

    public interface IItemService
    {
        Task<Item> GetItemByName(string itemName);
    }

    public class ItemService : IItemService
    {
        public async Task<Item> GetItemByName(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}

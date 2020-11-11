using Hygge_discord_bot.DAL;
using Hygge_discord_bot.DAL.Models.Items;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

        private readonly RPGContext _context;

        public ItemService(RPGContext context)
        {
            _context = context;
        }

        public async Task<Item> GetItemByName(string itemName)
        {
            itemName = itemName.ToLower();
            return await _context.Items
                .FirstOrDefaultAsync(x => x.Name.ToLower() == itemName).ConfigureAwait(false);
        }
    }
}

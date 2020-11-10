using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Extensions;
using Hygge_discord_bot.Attributes;
using Hygge_discord_bot.Core.Services.Items;
using Hygge_discord_bot.DAL;
using Hygge_discord_bot.DAL.Models.Items;
using Hygge_discord_bot.Handlers.Dialogue;
using Hygge_discord_bot.Handlers.Dialogue.Steps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Hygge_discord_bot.Commands
{
    public class RPGCommands : BaseCommandModule
    {
        
        private readonly IItemService _ItemService;

        public RPGCommands(IItemService itemService)
        {
            _ItemService = itemService;
        }

        [Command("additem")]
        public async Task AddItem(CommandContext ctx, string name)
        {
            await _context.Items.AddAsync(new Item { Name = name, Description = "Test Description" } ).ConfigureAwait(false);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        [Command("iteminfo")]
        public async Task ItemInfo(CommandContext ctx, string name)
        {
            var item = await _ItemService.GetItemByName(name).ConfigureAwait(false);

            if (item == null)
            {
                await ctx.Channel.SendMessageAsync($" There is no item called {name}");
                return;
            }

        }
    }
}

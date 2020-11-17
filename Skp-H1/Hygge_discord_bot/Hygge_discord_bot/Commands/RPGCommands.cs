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

        [Command("createitem")]
        [RequireRoles(RoleCheckMode.Any, "Admin")]
        public async Task CreateItem(CommandContext ctx)
        {
            var itemDescriptionStep = new TextStep("What is the item about?", null);
            var itemNameStep = new TextStep("What will the item be called?", itemDescriptionStep);

            var item = new Item();

            itemNameStep.OnValidResult += (result) => item.Name = result;
            itemDescriptionStep.OnValidResult += (result) => item.Description = result;

            var userChannel = await ctx.Member.CreateDmChannelAsync().ConfigureAwait(false);

            var inputDialogueHandler = new DialogueHandler(
                ctx.Client,
                userChannel,
                ctx.User,
                itemNameStep
            );

            bool succeeded = await inputDialogueHandler.ProcessDialogue().ConfigureAwait(false);

            if (!succeeded) { return; }

            await _ItemService.CreateNewItemAsync(item).ConfigureAwait(false);

            await ctx.Channel.SendMessageAsync($"item {item.Name} succesfully Created!").ConfigureAwait(false);

        }

        [Command("iteminfo")]
        public async Task ItemInfo(CommandContext ctx)
        {

            var itemNameStep = new TextStep("What item are you looking for?", null);

            string itemName = string.Empty;

            itemNameStep.OnValidResult += (result) => itemName = result;

            var userChannel = await ctx.Member.CreateDmChannelAsync().ConfigureAwait(false);

            var inputDialogueHandler = new DialogueHandler(
                ctx.Client,
                ctx.Channel,
                ctx.User,
                itemNameStep
            );

            bool succeeded = await inputDialogueHandler.ProcessDialogue().ConfigureAwait(false);

            if (!succeeded) { return; }

            var item = await _ItemService.GetItemByName(itemName).ConfigureAwait(false);

            if (item == null)
            {
                await ctx.Channel.SendMessageAsync($" There is no item called {itemName}");
                return;
            }

            await ctx.Channel.SendMessageAsync($"Name: {item.Name}, Description {item.Description} ");

        }
    }
}

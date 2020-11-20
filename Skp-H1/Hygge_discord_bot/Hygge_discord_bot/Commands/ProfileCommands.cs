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
    public class ProfileCommands : BaseCommandModule
    {

        private readonly IItemService _profileService;

        public ProfileCommands(IProfileService profileService)
        {
            _profilesService = ProfileService;
        }

        [Command("profile")]

        public async Task Profile(CommandContext ctx)
        {
            await GetProfileToDisPlayAsync(ctx, ctx.menber.Id);
        }

        [Command("profile")]

        public async Task Profile(CommandContext ctx, DiscordMember member)
        {
            await GetProfileToDisPlayAsync(ctx, member.Id);
        }

        private async Task GetProfileToDisplayAsync(CommandContext ctx, ulong meberId)
        {
            Profile profile = await _profileService.GetOrCreateProfileAsync(meberId, ctx.Guild.Id).ConfigureAwait(false);

            DiscordMember member ctx.Guild.Members[profile.DiscordId];

            var profileEmbed = new DiscordEmbedBuilder
            {
                Title = $"{member.DisplayName}'s Profile",
                ThumnailUrl = member.AvatarUrl
            };

            ProfileEmbed.AddField("xp", profile.xp.ToString());

            await ctx.Channel.SendMessageAsync(embed: profileEmbed).ConfigureAwait(false);
        }

    }
}


using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity.EventHandling;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hygge_discord_bot.Commands
{
    public class RoleCommands : BaseCommandModule
    {
        [Command("Join")]
        public async Task Join(CommandContext ctx)
        {
            var joinEmbed = new DiscordEmbedBuilder
            {
                Title = "Would you like to join?",
                ImageUrl = ctx.Client.CurrentUser.AvatarUrl,
                Color = DiscordColor.Green
            };

            var joinMessage = await ctx.Channel.SendMessageAsync(embed: joinEmbed).ConfigureAwait(false);

            var thumbsupEmoji = DiscordEmoji.FromName(ctx.Client, ":+1:");
            var thumbsDownEmoji = DiscordEmoji.FromName(ctx.Client, ":-1:");

            await joinMessage.CreateReactionAsync(thumbsupEmoji).ConfigureAwait(false);
            await joinMessage.CreateReactionAsync(thumbsDownEmoji).ConfigureAwait(false);

            var interacivity = ctx.Client.GetInteractivity();

            var reacionResult = await interacivity.WaitForReactionAsync(
            x => x.Message == joinMessage &&
            x.User == ctx.User &&
            (x.Emoji == thumbsupEmoji || x.Emoji == thumbsDownEmoji)).ConfigureAwait(false);

            if (reacionResult.Result.Emoji == thumbsupEmoji)
            {
                var role = ctx.Guild.GetRole(768415405001146400);
                await ctx.Member.GrantRoleAsync(role).ConfigureAwait(false);
            }
            else if (reacionResult.Result.Emoji == thumbsDownEmoji)
            {
                var role = ctx.Guild.GetRole(768415405001146400);
                await ctx.Member.RevokeRoleAsync(role).ConfigureAwait(false);
            }
            //else
            //{
            await joinMessage.DeleteAsync().ConfigureAwait(false);
            //}

            
        }
    }
}

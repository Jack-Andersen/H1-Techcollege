using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using Hygge_discord_bot.Core.Services.Profiles;
using Hygge_discord_bot.Core.ViewModels;
using Hygge_discord_bot.DAL.Models.Profiles;
using System.Linq;
using System.Threading.Tasks;

namespace Hygge_discord_bot.Commands
{
    public class ProfileCommands : BaseCommandModule
    {

        private readonly IProfileService _profileService;
        private readonly IExperienceService _experienceService;

        public ProfileCommands(IProfileService profileService, IExperienceService experienceService)
        {
            _profileService = profileService;
            _experienceService = experienceService;
        }

        [Command("profile")]

        public async Task Profile(CommandContext ctx)
        {
            await GetProfileToDisplayAsync(ctx, ctx.Member.Id);
        }

        [Command("profile")]

        public async Task Profile(CommandContext ctx, DiscordMember member)
        {
            await GetProfileToDisplayAsync(ctx, member.Id);
        }

        private async Task GetProfileToDisplayAsync(CommandContext ctx, ulong memberId)
        {
            Profile profile = await _profileService.GetOrCreateProfileAsync(memberId, ctx.Guild.Id).ConfigureAwait(false);

            DiscordMember member = ctx.Guild.Members[profile.DiscordID];

            var profileEmbed = new DiscordEmbedBuilder
            {
                Title = $"{member.DisplayName}'s Profile",
                ImageUrl = member.AvatarUrl
            };

            profileEmbed.AddField("Level", profile.Xp.ToString());
            profileEmbed.AddField("xp", profile.Xp.ToString());
            profileEmbed.AddField("Gold", profile.Xp.ToString());
            if (profile.Items.Count > 0)
            {
                profileEmbed.AddField("Items", string.Join(",", profile.Items.Select(x => x.Item.Name)));
            }

            await ctx.Channel.SendMessageAsync(embed: profileEmbed).ConfigureAwait(false);

            GrantXpViewModel viewModel = await _experienceService.GrantXpAsync(memberId, ctx.Guild.Id, 100).ConfigureAwait(false);

            if (!viewModel.LevelledUp) { return; }

            var levelUpEmbed = new DiscordEmbedBuilder
            {
                Title = $"{member.DisplayName} Is Now Level {viewModel.Profile.Level}",
                ImageUrl = member.AvatarUrl
            };

            await ctx.Channel.SendMessageAsync(embed: levelUpEmbed).ConfigureAwait(false);
            
        }
    }
}


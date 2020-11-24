using Hygge_discord_bot.DAL;
using Hygge_discord_bot.DAL.Models.Profiles;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hygge_discord_bot.Core.Services.Profiles
{

    public interface IProfileService
    {
        Task<Profile> GetOrCreateProfileAsync(ulong discordId, ulong guildId);
    }

    public class Profileservice : IProfileService
    {
        private readonly DbContextOptions<RPGContext> _options;

        public Profileservice(DbContextOptions<RPGContext> options)
        {
            _options = options;

            //using var context = new RPGContext(_options);

            //var profiles = context.Profiles.ToList();
            //profiles.ForEach(x => x.Gold = 100);
            //context.Profiles.UpdateRange(profiles);
            //context.SaveChanges();

        }

        public async Task<Profile> GetOrCreateProfileAsync(ulong discordId, ulong guildId)
        {

            using var context = new RPGContext(_options);

            var profile = await context.Profiles
                .Where(x => x.GuildID == guildId)
                .Include(x => x.Items)
                .Include(x => x.Items).ThenInclude(x => x.Item)
                .FirstOrDefaultAsync(x => x.DiscordID == discordId).ConfigureAwait(false);

            if (profile != null) { return profile; }

            profile = new Profile
            {
                DiscordID = discordId,
                GuildID = guildId,
                Gold = 100
            };

            context.Add(profile);

            await context.SaveChangesAsync().ConfigureAwait(false);

            return profile;

        }
    }
}

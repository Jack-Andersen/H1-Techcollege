using Hygge_discord_bot.DAL;
using Hygge_discord_bot.DAL.Models.Profiles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hygge_discord_bot.Core.Services.Profiles
{
    class ProfileService
    {
        public interface IProfileService
        {
            Task<Profile> GetOrCreateProfileAsync(ulong discordId, ulong guildId);
        }

        public class Profileservice : IProfileService
        {
            private readonly RPGContext _context;

            public Profileservice(RPGContext context)
            {
                _context = context;
            }

            public async Task<Profile> GetOrCreateProfileAsync(ulong discordId, ulong guildId)
            {
                var profile = await _context.Profiles
                    .Where(x => x.GuildID == guildId)
                    .FirstOrDefaultAsync(x => x.DiscordID == discordId).ConfigureAwait(false);

                if (profile != null) { return profile; }

                profile = new Profile
                {
                    DiscordID = discordId,
                    GuildID = guildId
                };

                _context.Add(profile);

                await _context.SaveChangesAsync().ConfigureAwait(false);

                return profile;

            }
        }
    }
}

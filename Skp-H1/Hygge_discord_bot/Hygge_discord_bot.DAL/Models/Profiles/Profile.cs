using Hygge_discord_bot.DAL.Models.Items;
using System.Collections.Generic;

namespace Hygge_discord_bot.DAL.Models.Profiles
{
    public class Profile : Entity
    {
        public ulong DiscordID { get; set; }

        public ulong GuildID { get; set; }

        public int Gold { get; set; }

        public int Xp { get; set; }

        public int Level => Xp / 100;

        public List<ProfileItem> Items { get; set; } = new List<ProfileItem>();
    }
}

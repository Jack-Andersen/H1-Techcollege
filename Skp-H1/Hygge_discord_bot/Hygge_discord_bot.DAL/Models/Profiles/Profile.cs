namespace Hygge_discord_bot.DAL.Models.Profiles
{
    public class Profile : Entity
    {
        public ulong DiscordID { get; set; }

        public ulong GuildID { get; set; }

        public int xp { get; set; }
    }
}

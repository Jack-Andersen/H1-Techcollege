using Hygge_discord_bot.DAL.Models.Items;
using Hygge_discord_bot.DAL.Models.Profiles;
using Microsoft.EntityFrameworkCore;

namespace Hygge_discord_bot.DAL
{
    public class RPGContext : DbContext
    {
        public RPGContext(DbContextOptions<RPGContext> options) : base(options) { }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<ProfileItem> ProfileItems { get; set; }
    }
}

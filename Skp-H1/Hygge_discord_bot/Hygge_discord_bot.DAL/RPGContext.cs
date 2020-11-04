using Hygge_discord_bot.DAL.Models.Items;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hygge_discord_bot.DAL
{
    public class RPGContext : DbContext
    {
        public RPGContext(DbContextOptions<RPGContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}

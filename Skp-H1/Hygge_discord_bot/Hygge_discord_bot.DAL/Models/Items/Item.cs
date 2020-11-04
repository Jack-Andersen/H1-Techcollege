using System;
using System.Collections.Generic;
using System.Text;

namespace Hygge_discord_bot.DAL.Models.Items
{
    public class Item : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}

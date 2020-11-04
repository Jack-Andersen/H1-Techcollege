using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hygge_discord_bot.DAL
{
    public abstract class Entity
    {
            [Key]

            public int Id { get; set; }

    }
}

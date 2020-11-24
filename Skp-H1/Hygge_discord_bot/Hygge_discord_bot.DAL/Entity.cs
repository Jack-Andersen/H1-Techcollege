using System.ComponentModel.DataAnnotations;

namespace Hygge_discord_bot.DAL
{
    public abstract class Entity
    {
            [Key]

            public int Id { get; set; }

    }
}

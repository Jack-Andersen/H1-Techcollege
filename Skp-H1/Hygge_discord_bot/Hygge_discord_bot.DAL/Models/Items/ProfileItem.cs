using Hygge_discord_bot.DAL.Models.Profiles;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hygge_discord_bot.DAL.Models.Items
{
    public class ProfileItem : Entity
    {
        public int ProfileID { get; set; }
        [ForeignKey("ProfileID")]

        public Profile Profile { get; set; }

        public int ItemID { get; set; }
        [ForeignKey("ItemID")]

        public Item Item { get; set; }

    }
}

using DSharpPlus;
using DSharpPlus.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hygge_discord_bot.Handlers.Dialogue.Steps
{
    public interface IDialogueStep
    {
        Action<DiscordMessage> OnMessageAdded { get; set; }
        IDialogueStep NextStep { get; }
        Task<bool> ProcessStep(DiscordClient Client,
                               DiscordChannel channel,
                               DiscordUser user);
    }
}

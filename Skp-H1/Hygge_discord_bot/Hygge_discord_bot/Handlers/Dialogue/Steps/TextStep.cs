using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.Interactivity;
using DSharpPlus.Interactivity.Extensions;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Hygge_discord_bot.Handlers.Dialogue.Steps
{
    public class TextStep : DialogueStepBase
    {
        private readonly IDialogueStep _nextStep;
        private readonly int? _minLength;
        private readonly int? _maxLength;

        public TextStep(
            string content,
            IDialogueStep nextStep,
            int? minLength = null,
            int? maxLength = null) : base(content)
        {
            _nextStep = nextStep;
            _minLength = minLength;
            _maxLength = maxLength;
        }

        public Action<string> OnValidResult { get; set; } = delegate { };

        public override IDialogueStep NextStep => _nextStep;

        public override async Task<bool> ProcessStep(DiscordClient client, DiscordChannel channel, DiscordUser user)
        {

            var embedBuilder = new DiscordEmbedBuilder
            {
                Title = $"Please Respond Below",
                Description = $"{user.Mention}, {_content}",
            };

            embedBuilder.AddField("To stop the Dialogue", "Use the ?cancel command");

            if (_minLength.HasValue)
            {
                embedBuilder.AddField("Min Length ", $"{_minLength.Value} charaters");

            }
            if (_minLength.HasValue)
            {
                embedBuilder.AddField("max Length ", $"{_minLength.Value} charaters");

            }

            var interactivity = client.GetInteractivity();

            while (true)
            {
                var embed = await channel.SendMessageAsync(embed: embedBuilder).ConfigureAwait(false);

                OnMessageAdded(embed);

                var messageResult = await interactivity.WaitForMessageAsync(
                        x => x.ChannelId == channel.Id && x.Author.Id == user.Id).ConfigureAwait(false);

                OnMessageAdded(messageResult.Result);

                if (messageResult.Result.Content.Equals("?cancel", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }

                if(_minLength.HasValue)
                {
                    if (messageResult.Result.Content.Length < _minLength.Value)
                    {
                        await TryAgain(channel, $"your input is {_minLength.Value - messageResult.Result.Content.Length} characters too short").ConfigureAwait(false);
                        continue;
                    }
                }

                if (_minLength.HasValue)
                {
                    if (messageResult.Result.Content.Length > _maxLength.Value)
                    {
                        await TryAgain(channel, $"your input is {_maxLength.Value - messageResult.Result.Content.Length} characters too short").ConfigureAwait(false);
                        continue;
                    }
                }

                OnValidResult(messageResult.Result.Content);

                return false;

            }
        }
    }
}

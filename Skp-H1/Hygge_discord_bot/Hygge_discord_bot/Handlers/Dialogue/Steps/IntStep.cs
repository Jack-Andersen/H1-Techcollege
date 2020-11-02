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
    public class IntStep : DialogueStepBase
    {
        private readonly IDialogueStep _nextStep;
        private readonly int? _minValue;
        private readonly int? _maxValue;

        public IntStep(
            string content,
            IDialogueStep nextStep,
            int? minValue = null,
            int? maxValue = null) : base(content)
        {
            _nextStep = nextStep;
            _minValue = minValue;
            _maxValue = maxValue;
        }

        public Action<int> OnValidResult { get; set; } = delegate { };

        public override IDialogueStep NextStep => _nextStep;

        public override async Task<bool> ProcessStep(DiscordClient client, DiscordChannel channel, DiscordUser user)
        {

            var embedBuilder = new DiscordEmbedBuilder
            {
                Title = $"Please Respond Below",
                Description = $"{user.Mention}, {_content}",
            };

            embedBuilder.AddField("To stop the Dialogue", "Use the ?cancel command");

            if (_minValue.HasValue)
            {
                embedBuilder.AddField("Min Value ", $"{_minValue.Value}");

            }
            if (_minValue.HasValue)
            {
                embedBuilder.AddField("max Value ", $"{_minValue.Value}");

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

                if (!int.TryParse(messageResult.Result.Content, out int inputValue))
                {
                    await TryAgain(channel, $"your input is not an integer").ConfigureAwait(false);
                    continue;
                }

                if(_minValue.HasValue)
                {
                    if (inputValue < _minValue.Value)
                    {
                        await TryAgain(channel, $"your input value {inputValue} is smaller than: {_minValue}").ConfigureAwait(false);
                        continue;
                    }
                }

                if (_minValue.HasValue)
                {
                    if (messageResult.Result.Content.Length > _maxValue.Value)
                    {
                        await TryAgain(channel, $"your input value {inputValue} is larger than {_maxValue} ").ConfigureAwait(false);
                        continue;
                    }
                }

                OnValidResult(inputValue);

                return false;

            }
        }
    }
}

using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Hygge_discord_bot.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class RequireCategorieAttribute : CheckBaseAttribute
    {
        public IReadOnlyList<string> CategoryNames { get; }

        public ChannelCheckMode CheckMode { get; }

        public RequireCategorieAttribute(ChannelCheckMode checkMode, params string[] channelNames)
        {

            CheckMode = CheckMode;
            CategoryNames = new ReadOnlyCollection<string>(channelNames);
        }


        public override Task<bool> ExecuteCheckAsync(CommandContext ctx, bool help)
        {
            if (ctx.Guild == null || ctx.Member == null)
            {
                return Task.FromResult(false);
            }

            bool contains = CategoryNames.Contains(ctx.Channel.Parent.Name, StringComparer.OrdinalIgnoreCase);

            return CheckMode switch
            {
                ChannelCheckMode.Any => Task.FromResult(contains),
                ChannelCheckMode.None => Task.FromResult(contains),


            _ => Task.FromResult(false),
            };
        }
    }
}


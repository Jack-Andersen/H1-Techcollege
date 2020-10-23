using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Hygge_discord_bot.Attributes
{
    public enum ChannelCheckMode
    {
       Any = 0,
       None = 1,
       MineOrParentAny = 2
    }
}

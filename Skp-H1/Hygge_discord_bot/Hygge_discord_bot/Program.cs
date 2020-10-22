using System;

namespace Hygge_discord_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot Bot = new Bot();
            Bot.Runasync().GetAwaiter().GetResult();
        }
    }
}

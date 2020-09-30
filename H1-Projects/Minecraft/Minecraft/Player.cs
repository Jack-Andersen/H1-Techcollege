using System;
using System.Collections.Generic;
using System.Text;

namespace Minecraft
{
    public class Player
    {
        int x = 0;
        int y = 0;
        int hp = 100;

        public string Hostile()
        {
            return "Unknown";
        }

        public int Speed()
        {
            return 100;
        }

        public int Strength()
        {
            return 50;
        }
    }
}

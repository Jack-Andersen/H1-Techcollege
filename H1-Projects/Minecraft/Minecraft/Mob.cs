using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Minecraft
{
    abstract class Mobs
    {

        public int x = 0;
        public int y = 0;
        public int hp = 100;

        public abstract bool Hostile();
        public abstract int Speed();
        public abstract int Strength();

    }

    class Michael : Mobs
    {

        public override bool Hostile()
        {
            hp = 200;
            return true;
        }

        public override int Speed()
        {
            return -1;
        }

        public override int Strength()
        {
            return -100;
        }
    }

    class Pigman : Mobs
    {
        public override bool Hostile()
        {
            return true;
        }

        public override int Speed()
        {
            return 100;
        }

        public override int Strength()
        {
            return 25;
        }
    }

    class Enderman : Mobs
    {
        public override bool Hostile()
        {
            return true;
        }

        public override int Speed()
        {
            return 100;
        }

        public override int Strength()
        {
            return 25;
        }
    }

    class Bunny : Mobs
    {
        public override bool Hostile()
        {
            return false;
        }

        public override int Speed()
        {
            return 100;
        }

        public override int Strength()
        {
            return 0;
        }
    }

    class Chicken : Mobs
    {
        public override bool Hostile()
        {
            return false;
        }

        public override int Speed()
        {
            return 100;
        }

        public override int Strength()
        {
            return 0;
        }
    }

    class BabyChicken : Chicken
    {
        public string Annoying_Level()
        {
            return "100%";
        }
    }

    class Horse : Mobs
    {
        public override bool Hostile()
        {
            return false;
        }

        public override int Speed()
        {
            return 100;
        }

        public override int Strength()
        {
            return 0;
        }
    }
}


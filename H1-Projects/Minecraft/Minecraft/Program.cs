using System;

namespace Minecraft
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player = new Player();           
            Console.WriteLine("Player\n" + "Hostile: " + player.Hostile() + "\nSpeed: " + player.Speed() + "\nStrength: " + player.Strength() + "\n");

            Michael Michael = new Michael();
            Console.WriteLine("Michael\n" + "Hostile: " + Michael.Hostile() + "\nSpeed: " + Michael.Speed() + "\nStrength: " + Michael.Strength() + "\n");

            Pigman pigman = new Pigman();
            Console.WriteLine("Pigman\n" + "Hostile: " + pigman.Hostile() + "\nSpeed: " + pigman.Speed() + "\nStrength: " + pigman.Strength() + "\n");

            Enderman enderman = new Enderman();
            Console.WriteLine("Enderman\n" + "Hostile: " + enderman.Hostile() + "\nSpeed: " + enderman.Speed() + "\nStrength: " + enderman.Strength() + "\n");

            Bunny bunny = new Bunny();
            Console.WriteLine("Bunny\n" + "Hostile: " + bunny.Hostile() + "\nSpeed: " + bunny.Speed() + "\nStrength: " + bunny.Strength() + "\n");

            Chicken chicken = new Chicken();
            Console.WriteLine("Chicken\n" + "Hostile: " + chicken.Hostile() + "\nSpeed: " + chicken.Speed() + "\nStrength: " + chicken.Strength() + "\n");

            BabyChicken babyChicken = new BabyChicken();
            Console.WriteLine("BabyChicken\n" + "Hostile: " + babyChicken.Hostile() + "\nSpeed: " + babyChicken.Speed() + "\nStrength: " + babyChicken.Strength() + "\nAnnoying level: " + babyChicken.Annoying_Level() + "\n");

            Horse horse = new Horse();
            Console.WriteLine("Horse\n" + "Hostile: " + horse.Hostile() + "\nSpeed: " + horse.Speed() + "\nStrength: " + horse.Strength() + "\n");
        }
    }
}

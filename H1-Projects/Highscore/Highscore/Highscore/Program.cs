using System;
using System.Collections.Generic;
using System.Linq;

namespace Highscore
{
    class Program
    {

        static Highscore EnterHighscore()
        {

            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your score");
            int score = int.Parse(Console.ReadLine());

            Highscore hejscore = new Highscore();
            hejscore.Name = name;
            hejscore.Score = score;
            return hejscore;

        }

        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Highscore!");

            List<Highscore> highscoreList = new List<Highscore>(); 
            HighscoreIO.ReadFromFile(highscoreList);
            foreach (Highscore item in highscoreList)
            {
                string formattet = string.Format("{0} {1}", item.Name, item.Score);                            
                count++;
                if (count <= 5)
                {
                    Console.WriteLine(formattet);
                }
            }

            for (int i = 0; i < 3; i++)
            {            

              Highscore benjaminTheWise = EnterHighscore();
              highscoreList.Add(benjaminTheWise);
              Console.WriteLine("Highscore" + benjaminTheWise.Name);

            }

            HighscoreIO.WriteToFile(highscoreList);

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Highscore
{
    class HighscoreIO
    {
        public static void WriteToFile(List<Highscore> highscoreList)
        {
            File.Delete("highscore.txt");

            foreach (Highscore item in highscoreList)
            {
                string formattet = String.Format("{0} = {1}\n", item.Name, item.Score);
                File.AppendAllText("highscore.txt", formattet);
            }
        }

        public static void ReadFromFile(List<Highscore> highscoreList)
        {
            if (File.Exists("Highscore.txt") == false)
            {
                return;
            }

            string highscoretxt = File.ReadAllText("highscore.txt");
            highscoretxt = highscoretxt.Trim();
            string[] lines = highscoretxt.Split("\n");

            foreach (string item in lines)
            {
                if (item == "")
                {
                    continue;
                }

                string[] newLines = item.Split("=");
                Highscore h = new Highscore();
                h.Name = newLines[0];
                h.Score = int.Parse(newLines[1]);
                highscoreList.Add(h);
                highscoreList.Sort(new Highscore());

            }
        }
    }
}

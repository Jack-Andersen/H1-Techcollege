using System;
using System.Timers;

namespace Reaction_time_game_PN
{
    class Program2
    {

        private static System.Timers.Timer aTimer;


        static void Main(string[] args)
        {

            bool restart = true;

            do
            {

                Console.Clear();

                Console.WriteLine("Press ENTER to start the game");
                Console.WriteLine("When you see a O press ENTER");

                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.WriteLine(" \n Michael is a retard");
                }

                Random randomNum = new Random();

                int num = randomNum.Next(1, 10);

                bool disable = false;
                System.Threading.Thread.Sleep(num * 1000);
                Console.WriteLine("O");

                disable = true;
                SetTimer();

                DateTime startTime = DateTime.Now;
                Console.WriteLine("The application started at {0:HH:mm:ss:fff}", startTime);
                if (disable == true)
                {
                   Console.ReadKey();
                }

                DateTime endTime = DateTime.Now;
                aTimer.Stop();
                aTimer.Dispose();
                Console.Clear();
                Console.WriteLine("Your starting time was {0:HH:mm:ss:fff}", startTime);
                Console.WriteLine("Your end time was {0:HH:mm:ss.fff}", endTime);
                TimeSpan duration = startTime - endTime;
                Console.WriteLine("Your time in total was " + duration);
                Console.WriteLine("Type *e* to exit or if you wanna restart press ENTER to restart");
                string input = Console.ReadLine().ToLower();
                if (input == "e")
                {
                    restart = false;
                }

            }

            while (restart != false);  

            static void SetTimer()
            {
                aTimer = new System.Timers.Timer(10);
                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = true;
                aTimer.Enabled = true;
            }

            static void OnTimedEvent(object source, ElapsedEventArgs e)
            {
                Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
            }
        }
    }
}

using Guessing_game;
using System;
using System.Timers;

namespace GuessANumber
{
    class Program
    {

        private static Random _random = new Random();

        private static ConsoleColor GetRandomConsoleColor()
        {
            var consoleColors = Enum.GetValues(typeof(ConsoleColor));
            return (ConsoleColor)consoleColors.GetValue(_random.Next(consoleColors.Length));
        }

        static void Main(string[] args)
        {

            while (true) // Continue the game untill the user does want to anymore...
            {

                Console.Clear();

                Console.ForegroundColor = GetRandomConsoleColor();

                TimerClass.SetTimer();
                DateTime startTid = DateTime.Now;
                Console.WriteLine("HURRY! Game Started at {0:HH:mm:ss.fff}", startTid);
                Console.WriteLine();

                Random random = new Random();
                int guess = 0;
                string welcome = "Guess a number between 1 and 100";
                int num = random.Next(1, 100);
                Console.WriteLine(welcome);

                int i = 0;

                while (guess != num)
                {
                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());

                        if (guess > num)
                        {
                            Console.WriteLine("Too High " + guess);
                        }
                        else
                        {
                            Console.WriteLine("Too Low " + guess);
                        }
                    }

                    catch
                    {
                        Console.WriteLine("Guess must be a number");
                        i--;
                    }

                    i++;
                }
                Console.Clear();
                Console.WriteLine("Congrats, it took you " + i + " tries");
                Console.ReadLine();
                DateTime slutTid = DateTime.Now;
                Console.WriteLine("Fast Enough? Game Started at {0:HH:mm:ss.fff}", startTid);
                TimeSpan duration = slutTid - startTid;
                Console.WriteLine("Woah your fast! Time from start to end " + duration);

                while (true) // Continue asking until a correct answer is given.
                {
                    Console.Write("Do you want to play again [Yes/No]?\n");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes")
                        break; // Exit the inner while-loop and continue in the outer while loop.
                    if (answer == "no")
                        return; // Exit the Main-method.
                }
            }
        }
    }
}

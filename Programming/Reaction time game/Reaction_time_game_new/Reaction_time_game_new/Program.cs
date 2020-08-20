using System;
using System.Collections.Generic;
using System.Timers;

namespace Reaction_time_game_PN
{
    class Program2
    {

        static void Main(string[] args)
        {
            Game game = new Game();
            game.Menu();
        }

        public class Game
        {
            private const ConsoleKey gameStart = ConsoleKey.Enter;

            public void Menu()
            {              
                const ConsoleKey singlePlayer = ConsoleKey.Enter;
                const ConsoleKey multiPlayer = ConsoleKey.D2;
                const ConsoleKey exitKey = ConsoleKey.Escape;

                while (true)
                {
                    Console.WriteLine("Press ENTER for singleplayer. Press 2 for multiplayer. Press Esc to exit");

                    ConsoleKey pressedKey = PressedKey();

                    switch (pressedKey)
                    {

                        case singlePlayer:
                            SinglePlayerRun();
                            break;

                        case multiPlayer:
                            MultiPlayerRun();
                            break;

                        case exitKey:
                            Environment.Exit(0);
                            break;
                    }
                }

                ConsoleKey PressedKey()
                {
                    do
                    {
                        while (!Console.KeyAvailable) ;
                        ConsoleKey pressed = Console.ReadKey(true).Key;
                        if (pressed == singlePlayer || pressed == multiPlayer || pressed == exitKey)
                            return pressed;
                        Console.Clear();
                    } while (true);
                }
            }



            private void SinglePlayerRun()
            {
                Console.Clear();
                SingleplayerKeys();
                Console.WriteLine("Press ENTER to start the game \nWhen you see a 0 Press ENTER");
                SinglePlayerGameLoop();
            }

            private void SingleplayerKeys()
            {
                player1 = ConsoleKey.Enter;
            }

            private void SinglePlayerGameLoop()
            {
                bool start = false;

                do
                {
                    if (Console.ReadKey(true).Key == gameStart)
                    {

                        start = true;

                        Random randomNum = new Random();
                        int num = randomNum.Next(1, 10);
                        System.Threading.Thread.Sleep(num * 1000);

                        Console.WriteLine("0");

                        Timer timer = new Timer();
                        timer.Time();

                        while (!Console.KeyAvailable && Console.ReadKey(true).Key != player1) ;
                        double playertimer = timer.EndTime;
                        Console.WriteLine(String.Format("Your time in total was {0} ms. ", playertimer));
                        Console.ReadLine();
                    }

                    Console.Clear();
                } while (!start);
            }

            private void MultiPlayerRun()
            {
                Console.Clear();
                MultiplayerKeys();
                Console.WriteLine("Player 1: press ENTER when you see 0. Player 2: press space when you see 0");
                MultiPlayerGameLoop();
            }

            private ConsoleKey player1;
            private ConsoleKey player2;

            private void MultiplayerKeys()
            {
                player1 = ConsoleKey.Enter;
                player2 = ConsoleKey.Spacebar;
            }

            private void MultiPlayerGameLoop()
            {

                bool start = false;

                do
                {
                    Console.WriteLine("Press ENTER to start the game");

                    if (Console.ReadKey(true).Key == gameStart)
                    {

                        bool player1Pressed = false;
                        bool player2Pressed = false;
                        double player1Timer = 0;
                        double player2Timer = 0;
                        start = true;

                        Random randomNum = new Random();
                        int num = randomNum.Next(1, 10);
                        System.Threading.Thread.Sleep(num * 1000);

                        Console.WriteLine("O");
                       
                        Timer timer = new Timer();
                        timer.Time();

                        do
                        {
                            ConsoleKey pressed = KeyGet();
                            if (pressed == player1 && !player1Pressed)
                            {
                                player1Pressed = true;
                                player1Timer = timer.EndTime;
                            }
                            else if (pressed == player2 && !player2Pressed)
                            {
                                player2Pressed = true;
                                player2Timer = timer.EndTime;
                            }

                        } while (!player1Pressed || player2Pressed);

                        Console.WriteLine(String.Format("player 1 your time in total was {0} ", player1Timer));
                        Console.WriteLine(String.Format("player 2 your time in total was {0} ", player2Timer));
                        Console.WriteLine(String.Format("{0} won", player1Timer < player2Timer ? "player 1" : "player 2"), ConsoleColor.White);
                        Console.ReadLine();
                    }

                    Console.Clear();
                } while (!start);
            }

            private ConsoleKey KeyGet()
            {
                while (!Console.KeyAvailable) ;
                return Console.ReadKey(true).Key;
            }

            public class Timer
            {
                private DateTime startTime;

                public void Time()
                {
                    startTime = DateTime.Now;
                }

                public double EndTime
                {
                    get
                    {
                        if (startTime.Year == 1)
                            throw new TimeZoneNotFoundException("Time has not been called");
                        return (DateTime.Now - startTime).TotalMilliseconds;
                    }
                }
            }
        }
    }
}

//private static System.Timers.Timer aTimer;

//bool restart = true;

//            do
//            {

//                Console.Clear();

//                Console.WriteLine("Press ENTER to start the game");
//                Console.WriteLine("Press 2 for players");
//                Console.WriteLine("When you see a O press ENTER");

//                while (Console.ReadKey().Key != ConsoleKey.Enter)
//                {
//                    Console.WriteLine(" \n Michael is a retard");
//                }

//                Random randomNum = new Random();
//int num = randomNum.Next(1, 10);
//System.Threading.Thread.Sleep(num* 1000);

//                Console.WriteLine("O");

//                SetTimer();

//DateTime startTime = DateTime.Now;
//Console.WriteLine("The application started at {0:HH:mm:ss:fff}", startTime);
//                Console.ReadKey();

//                DateTime endTime = DateTime.Now;
//aTimer.Stop();
//                aTimer.Dispose();
//                Console.Clear();
//                Console.WriteLine("Your starting time was {0:HH:mm:ss:fff}", startTime);
//                Console.WriteLine("Your end time was {0:HH:mm:ss.fff}", endTime);
//                TimeSpan duration = startTime - endTime;
//Console.WriteLine("Your time in total was " + duration);
//                Console.WriteLine("Type *e* to exit or if you wanna restart press ENTER to restart");
//                string input = Console.ReadLine().ToLower();
//                if (input == "e")
//                {
//                    restart = false;
//                }


//            }

//            while (restart != false);

//            static void SetTimer()
//{
//    aTimer = new System.Timers.Timer(10);
//    aTimer.Elapsed += OnTimedEvent;
//    aTimer.AutoReset = true;
//    aTimer.Enabled = true;
//}

//static void OnTimedEvent(object source, ElapsedEventArgs e)
//{
//    Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
//}

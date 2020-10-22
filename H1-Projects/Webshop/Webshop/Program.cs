using System;
using TECHCOOL;

namespace Webshop
{
    class Program
    {
        static void InsertLogMessage(string besked, int type)
        {
            string SQL = @"
            INSERT INTO log (Message, Type, Date)
            VALUES ('{0}', {1}, '{2}')";
            string formattet = string.Format(SQL, besked, type, DateTime.Now);
            Console.WriteLine(formattet);
            SQLet.Execute(formattet);
        }

        static void deleteLogMessage(string ID)
        {
            string SQL = @"
            DELETE FROM log WHERE LogID = '{0}'";
            string formattet = string.Format(SQL, ID);
            Console.WriteLine(formattet);
            SQLet.Execute(formattet);
        }

        static void updateLogMessage(string id, string besked)
        {
            string SQL = @"
            UPDATE log SET Message = '{0}' WHERE LogID = {1}";
            string formattet = string.Format(SQL, besked, id);
            Console.WriteLine(formattet);
            SQLet.Execute(formattet);
        }

        static void showLogMessage(string type)
        {
            string SQL = @"
            SELECT {0} FROM log Where Type = {1}
            ORDER BY Date DESC";
            string formattet = string.Format(SQL, "LogId, Message, Date", type);
            Result result = SQLet.GetResult(formattet);
            foreach (var record in result)
            {
                Console.WriteLine(record["LogID"] + "\t" + record["Message"] + "\t" + record["Date"]);
            }
        }

        static void Main(string[] args)
        {   

            SQLet.ConnectSQLite("Webshop.db");

            const ConsoleKey keyInfo1 = ConsoleKey.D1;
            const ConsoleKey keyInfo2 = ConsoleKey.D2;
            const ConsoleKey keyInfo3 = ConsoleKey.D3;  

            while (true)
            {
                showLogMessage("1"); 

                Console.WriteLine("Press 1 :InsertLogMessage. Press 2 :DeleteLogMessage. Press 3 :UpdateLogMessage");

                ConsoleKey pressedKey = PressedKey();

                switch (pressedKey)
                {
                    case keyInfo1:   
                        Console.Write("Enter log message > ");
                        string input = Console.ReadLine();
                        InsertLogMessage(input, 1);
                        break;

                    case keyInfo2:
                        Console.Write("Specify what ID you want to delete > ");
                        string inputdelete = Console.ReadLine();
                        deleteLogMessage(inputdelete);
                        break;

                    case keyInfo3:
                        Console.Write("What ID do you want to update > ");
                        string inputUpdate = Console.ReadLine();
                        Console.Write("What do you want to update your message to > ");
                        string inputMessage = Console.ReadLine();
                        updateLogMessage(inputUpdate, inputMessage);
                        break;
                }
            }

            ConsoleKey PressedKey()
            {
                do
                {
                    while (!Console.KeyAvailable) ;
                    ConsoleKey pressed = Console.ReadKey(true).Key;
                    if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3)
                        return pressed;
                    Console.Clear();
                } while (true);
            }
        }
    }
}

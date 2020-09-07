using System;
using TECHCOOL;

namespace Noodle_chat
{
    class Program
    {

        static void InsertMessage(string MessagesText, int MessagesUserID)
        {
            string SQL = @"
            INSERT INTO Messages_for_chat (MessagesText, MessagesUserID, MessagesDate)
            VALUES ('{0}', {1}, '{2}')";
            string formattet = string.Format(SQL, MessagesText, MessagesUserID, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(formattet);
            SQLet.Execute(formattet);
        }

        static void DeleteMessage(string ID)
        {
            string SQL = @"
            DELETE FROM Messages_for_chat WHERE MessagesID = '{0}'";
            string formattet = string.Format(SQL, ID);
            Console.WriteLine(formattet);
            SQLet.Execute(formattet);
        }

        static void UpdateMessage(string ID, string MessagesText)
        {
            string SQL = @"
            UPDATE Messages_for_chat SET MessagesText = '{0}' WHERE MessagesID = {1}";
            string formattet = string.Format(SQL, MessagesText, ID);
            Console.WriteLine(formattet);
            SQLet.Execute(formattet);
        }

        static void ShowMessage(int MessagesUserID)
        {
            string SQL = @"
            SELECT * FROM Messages_for_chat Where MessagesUserID = {0}
            ORDER BY MessagesID";
            string formattet = string.Format(SQL, MessagesUserID);
            Result result = SQLet.GetResult(formattet);
            if (result.Count == 0)
            {
                Console.Write("No Messages by user ID {MessagesUserID}");
            }
            else
            {
                Console.WriteLine("Messages by user ID {MessagesUserID}");
                foreach (var record in result)
                {
                    Console.WriteLine(record["MessagesID"] + "\t" + record["MessagesText"] + "\t" + record["MessagesUserID"] + "\t" + record["MessagesDate"]);
                }
            }

            Console.WriteLine("\n");

        }

        static void ShowAllMessages()
        {
            string SQL = @"
            SELECT * FROM Messages_for_chat
            ORDER BY MessagesID";
            string formattet = string.Format(SQL);
            Result result = SQLet.GetResult(formattet);
            foreach (var record in result)
            {
                Console.WriteLine(record["MessagesID"] + "\t" + record["MessagesText"] + "\t" + record["MessagesUserID"] + "\t" + record["MessagesDate"]);
            }
        }

        static void Main(string[] args)
        {

            SQLet.ConnectSqlServer("Noodle_chat", "JACK-ANDERSEN-J");

            bool start = false;
            const ConsoleKey keyInfo1 = ConsoleKey.D1;
            const ConsoleKey keyInfo2 = ConsoleKey.D2;
            const ConsoleKey keyInfo3 = ConsoleKey.D3;
            const ConsoleKey keyInfo4 = ConsoleKey.D4;

            while (true)
            {
                if (start == true)
                {
                    Console.WriteLine();               
                }
                start = true;

                Console.WriteLine("All messages");
                ShowAllMessages();

                Console.WriteLine("\n");

                Console.WriteLine("Press 1 InsertMessage.\nPress 2 DeleteMessage.\nPress 3 UpdateMessage.\nPress 4 ShowMessage from user.\n");

                ConsoleKey pressedKey = PressedKey();

                switch (pressedKey)
                {
                    case keyInfo1:
                        Console.Write("Enter log message > ");
                        string input = Console.ReadLine();
                        InsertMessage(input, 1);
                        break;

                    case keyInfo2:
                        Console.Write("Specify what ID you want to delete > ");
                        string inputdelete = Console.ReadLine();
                        DeleteMessage(inputdelete);
                        break;

                    case keyInfo3:
                        Console.Write("What ID do you want to update > ");
                        string inputUpdate = Console.ReadLine();
                        Console.Write("What do you want to update your message to > ");
                        string inputMessage = Console.ReadLine();
                        UpdateMessage(inputUpdate, inputMessage);
                        break;

                    case keyInfo4:
                        Console.Write("Show message from user > ");
                        int aInputID = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        ShowMessage(aInputID);
                        break;
                }
            }

            ConsoleKey PressedKey()
            {
                do
                {
                    while (!Console.KeyAvailable) ;
                    ConsoleKey pressed = Console.ReadKey(true).Key;
                    if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3 || pressed == keyInfo4)
                        return pressed;
                    Console.Clear();
                } while (true);
            }
        }

        //SQLet.Execute(@"INSERT INTO Messages_for_chat (MessagesText, MessagesUserID, MessagesDate) 
        //VALUES ('Test Tekst', 1, '07-09-2020')");
    }
}


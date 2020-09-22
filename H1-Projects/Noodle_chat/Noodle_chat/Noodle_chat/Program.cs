using System;
using System.Collections.Generic;
using System.Dynamic;
using TECHCOOL;

namespace Noodle_chat
{
    class Program
    {

        static void DeleteUser(string ID)
        {
            string SQL = @"
            DELETE FROM UserID_for_chat WHERE UserID = '{0}'";
            string formattet = string.Format(SQL, ID);
            Console.WriteLine(formattet);
            SQLet.Execute(formattet);
        }

        static void UpdateUser(string ID, string UserName)
        {
            string SQL = @"
            UPDATE UserID_for_chat SET UserName = '{0}' WHERE UserID = {1}";
            string formattet = string.Format(SQL, UserName, ID);
            Console.WriteLine(formattet);
            SQLet.Execute(formattet);
        }

        static void ShowAllUsers()
        {
            string SQL = @"
            SELECT * FROM UserID_for_chat
            ORDER BY UserID";
            string formattet = string.Format(SQL);
            Result result = SQLet.GetResult(formattet);
            foreach (var record in result)
            {
                Console.WriteLine(record["UserID"] + "\t" + record["UserName"]);
            }
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
            left join UserID_for_chat on Messages_for_chat.MessagesUserID = UserID_for_chat.UserID
            ORDER BY MessagesID";
            string formattet = string.Format(SQL);
            Result result = SQLet.GetResult(formattet);
            foreach (var record in result)
            {
                Console.WriteLine(record["MessagesID"] + "\t" + record["MessagesText"] + "\t" + record["UserName"] + "\t" + record["MessagesDate"]);
            }
        }

        static void Main(string[] args)
        {
            //string host = "http://172.18.10.10:8080/";
            //string host = "http://192.168.1.101:8080/";
            string host = "http://localhost:8080/";
            if (args.Length > 0)
            {
                 host = args[0];
            }
            SQLet.ConnectSqlServer("Noodle_chat", "JACK-ANDERSEN-J");
            RequestHandler requestHandler = new RequestHandler(host);
            requestHandler.start();
            Console.ReadLine();
        }

        static void Main_(string[] args)
        {
            
            SQLet.ConnectSqlServer("Noodle_chat", "JACK-ANDERSEN-J", "SA", "Muskel-Mads");
            List<Message> Beskeder = Database.GetMessages();
            Console.WriteLine(Beskeder.Count);
            string beskedHTML = HTMLGenerator.GenerateMessages(Beskeder);
            Console.WriteLine(beskedHTML);
            List<User> User = Database.GetUsers();
            string userHTML = HTMLGenerator.GenerateUser(User);
            Console.WriteLine(userHTML);
            string Index = HTMLGenerator.generateIndex(Beskeder, User, 0);
            Console.WriteLine(Index);
            System.IO.File.WriteAllText("C:/Users/Elder/Documents/GitHub/Jack_Andersen/H1-Projects/Noodle_chat/Noodle_chat/Noodle_chat/HTLM/test.html", Index);

            bool start = false;
            const ConsoleKey keyInfo1 = ConsoleKey.D1;
            const ConsoleKey keyInfo2 = ConsoleKey.D2;
            const ConsoleKey keyInfo3 = ConsoleKey.D3;
            const ConsoleKey keyInfo4 = ConsoleKey.D4;
            const ConsoleKey keyInfo5 = ConsoleKey.D5;
            const ConsoleKey keyInfo6 = ConsoleKey.D6;
            const ConsoleKey keyInfo7 = ConsoleKey.D7;
            const ConsoleKey keyInfo8 = ConsoleKey.D8;

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

                Console.WriteLine("Users:");
                Console.WriteLine("Press 1 Insert user.\n" +
                                  "Press 2 Delete user.\n" +
                                  "Press 3 Update user.\n" +
                                  "Press 4 Show all users.\n\n");
                Console.WriteLine("Messages:");
                Console.WriteLine("Press 5 Insert message.\n" +
                                  "Press 6 Delete message.\n" +
                                  "Press 7 Update message.\n" +
                                  "Press 8 Show message from user.\n");

                ConsoleKey pressedKey = PressedKey();

                switch (pressedKey)
                {
                    case keyInfo1:
                        Console.Write("Enter user name > ");
                        string inputUser = Console.ReadLine();
                        Database.InsertUser(inputUser);
                        break;

                    case keyInfo2:
                        Console.Write("Specify what user you want to delete > ");
                        string deleteUser = Console.ReadLine();
                        DeleteUser(deleteUser);
                        break;

                    case keyInfo3:
                        Console.Write("What ID do you want to update > ");
                        string updateUser = Console.ReadLine();
                        Console.Write("What do you want to update your name to > ");
                        string updateUserName = Console.ReadLine();
                        UpdateUser(updateUser, updateUserName);
                        break;

                    case keyInfo4:                
                        ShowAllUsers();
                        break;

                    case keyInfo5:
                        Console.Write("Enter message > ");
                        string input = Console.ReadLine();
                        Console.Write("Enter ID for user > ");
                        int MessagesUserID = int.Parse(Console.ReadLine());
                        Database.InsertMessage(input, MessagesUserID);
                        break;

                    case keyInfo6:
                        Console.Write("Specify what ID you want to delete > ");
                        string inputdelete = Console.ReadLine();
                        DeleteMessage(inputdelete);
                        break;

                    case keyInfo7:
                        Console.Write("What ID do you want to update > ");
                        string inputUpdate = Console.ReadLine();
                        Console.Write("What do you want to update your message to > ");
                        string inputMessage = Console.ReadLine();
                        UpdateMessage(inputUpdate, inputMessage);
                        break;

                    case keyInfo8:
                        Console.Write("Show message from userID > ");
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
                    if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3 || pressed == keyInfo4 || pressed == keyInfo5 || pressed == keyInfo6 || pressed == keyInfo7 || pressed == keyInfo8)
                        return pressed;
                    Console.Clear();
                } while (true);
            }
        }

        //SQLet.Execute(@"INSERT INTO Messages_for_chat (MessagesText, MessagesUserID, MessagesDate) 
        //VALUES ('Test Tekst', 1, '07-09-2020')");
    }
}


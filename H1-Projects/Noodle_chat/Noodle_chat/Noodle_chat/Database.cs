using System;
using System.Collections.Generic;
using System.Text;
using TECHCOOL;

namespace Noodle_chat
{
    class Database
    {
        public static void SetupSQLServer()
        {
            try
            {
                SQLet.Execute(@" CREATE TABLE UserID_for_chat(
                UserID int primary key IDENTITY(1,1) NOT NULL,
                UserName nvarchar(32) NOT NULL
                ");

                // FK_user_message = imptementere referenceintegritet.

                SQLet.Execute(@" CREATE TABLE Messages_for_chat(
                MessagesID int primary key IDENTITY(1,1) NOT NULL,
                MessagesDate datetime NOT NULL DEFAULT GETDATE(),
                MessagesText text NOT NULL, 
                MessagesUserID int CONSTRAINT FK_user_message FOREIGN KEY (MessagesUserID)
                REFERENCES UserID_for_chat
                ON DELETE Cascade
                ON UPDATE Cascade
                ");
            }
            catch(Microsoft.Data.SqlClient.SqlException)
            {

            }
        }

        public static List<Message> GetMessages()
        {
            List<Message> messages = new List<Message>();
            Result result = SQLet.GetResult("SELECT MessagesID, MessagesUserID, MessagesText, MessagesDate FROM Messages_for_chat");
            int number = 0;
            foreach (var row in result)
            {
                // parser teksten MessagesUserID om til et tal.
                int.TryParse(row["MessagesUserID"], out number); 

                //opretter en instans af MessagesText.
                Message msg = new Message(row["MessagesText"], number); 

                //Sætter datoen på instansen til samme dato som fra databasen.
                msg.MessagesDate = DateTime.Parse(row["MessagesDate"]);

                //parser teksten fra MessagesID om til et tal og lægger det i number.
                int.TryParse(row["MessagesID"], out number);
                msg.MessagesID = number;// putter tallet fra number over i MassagesID på instans

                //Tilføj msg til listen.
                messages.Add(msg); 

            }

            return messages;

        }


        public static List<User> GetUsers()
        {
            List<User> user = new List<User>();
            Result result = SQLet.GetResult("SELECT UserID, UserName FROM UserID_for_chat");
            int number = 0;
            foreach (var row in result)
            {
                // parser teksten MessagesUserID om til et tal.
                int.TryParse(row["UserID"], out number);

                //opretter en instans af MessagesText.
                User loginUser = new User ( number, row["UserName"]);

                //Tilføj msg til listen.
                user.Add(loginUser);
            }

            return user;

        }
    }
}

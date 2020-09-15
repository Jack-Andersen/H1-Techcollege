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

                SQLet.Execute(@"CREATE VIEW Noodle_Info AS
                    SELECT MessagesID, MessagesUserID, MessagesText, MessagesDate, UserName FROM Messages_for_chat
                    INNER JOIN UserID_for_chat
                    ON Messages_for_chat.MessagesUserID = UserID_for_chat.UserID"); //New
            }
            catch(Microsoft.Data.SqlClient.SqlException)
            {

            }
        }     

        public static List<Message> GetMessages()
        {
            List<Message> messages = new List<Message>();
            Result result = SQLet.GetResult(@"SELECT * FROM Noodle_Info"); //New
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

                //sæt propertien User til en bruger instans
                int.TryParse(row["MessagesID"], out number);
                msg.User = new User(number ,row["UserName"]); //New

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

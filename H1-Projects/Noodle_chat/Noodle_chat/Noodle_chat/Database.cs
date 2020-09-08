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
    }
}

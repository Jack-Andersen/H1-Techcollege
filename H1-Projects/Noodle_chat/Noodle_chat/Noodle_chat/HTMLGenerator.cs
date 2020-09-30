using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Noodle_chat
{
    class HTMLGenerator
    {

        public static string generateIndex(List<Message> messages, List<User> user, int userID)
        {

            string html;

            try
            {
                html = System.IO.File.ReadAllText("C:/Users/Elder/Documents/GitHub/Jack_Andersen/H1-Projects/Noodle_chat/Noodle_chat/Noodle_chat/HTLM/Chat-browser.html");
            }
            catch (FileNotFoundException e)
            {
                Logger.WriteToFile(e);
                return "<h1> Missing template for chat-browser </h1>";
            }

            html = html.Replace("{{MESSAGEWINDOW}}", HTMLGenerator.GenerateMessages(messages));
            html = html.Replace("{{USERWINDOW}}", HTMLGenerator.GenerateUser(user));
            html = html.Replace("{{USERID}}", userID.ToString());
            return html;
        }

        public static string generateLogin()
        {

            string html;

            try
            {
                html = System.IO.File.ReadAllText("C:/Users/Elder/Documents/GitHub/Jack_Andersen/H1-Projects/Noodle_chat/Noodle_chat/Noodle_chat/HTLM/Login.html");
            }
            catch (FileNotFoundException e)
            {
                Logger.WriteToFile(e);
                return "<h1> Missing template for login </h1>";
            }
            return html;
        }

        public static string GenerateMessages(List<Message> messages)
        {
            string html = "";
            foreach (Message msg in messages)
            {
                string tpl1 = "<p><span class=\"Simon\">{0} </span><span class=\"timestamp\">{1}</span><br><span class=\"message\">{2}</span></p><hr>";
                string formattedDate = msg.MessagesDate.ToString("t");
                html += string.Format(tpl1, msg.Sender.UserName, formattedDate, msg.MessagesText);
            }
            return html;
        }

        public static string GenerateUser(List<User> user)
        {
            string html = "";
            foreach (User loginUser in user)
            {
                string link = $"<p><a href=\"#{loginUser.UserID}\">{loginUser.UserName}</a></p><hr>";

                html += link;
            }
            return html;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Noodle_chat
{
    class HTMLGenerator
    {

        public static string generateIndex(List<Message> messages, List<User> user)
        {
            string html = System.IO.File.ReadAllText("C:/Users/Elder/Documents/GitHub/H1-Techcollege/H1-Projects/Noodle_chat/Noodle_chat/Noodle_chat/HTLM/Chat-browser.html");
            html = html.Replace("{{MESSAGEWINDOW}}", HTMLGenerator.GenerateMessages(messages));
            html = html.Replace("{{USERWINDOW}}", HTMLGenerator.GenerateUser(user));
            return html;
        }

        public static string GenerateMessages(List<Message> messages)
        {
            string html = "";
            foreach (Message msg in messages)
            {
                string tpl1 = "<p><span class=\"Simon\">{0} </span><span class=\"timestamp\">{1}</span><br><span class=\"message\">{2}</span></p><hr>";
                string formattedDate = msg.MessagesDate.ToString("t");
                html += string.Format(tpl1, msg.User.UserName, formattedDate, msg.MessagesText); //new
            }
            return html;
        }

        public static string GenerateUser(List<User> user)
        {
            string html = "";
            foreach (User loginUser in user)
            {
                string tpl2 = "<p>{0}</p><hr>";

                html += string.Format(tpl2, loginUser.UserName);
            }
            return html;
        }

    }
}

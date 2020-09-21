using System;
using System.Collections.Generic;
using System.Text;
using TECHCOOL;

namespace Noodle_chat
{
    class RequestHandler
    {

        private string host = "";

        public RequestHandler(string host)
        {
            this.host = host;
        }

        public void start()
        {
            WebLet httplistener = new WebLet(host);
            //httplistener.Route("/Stylesheet.css", requestStylesheet);
            httplistener.Route("^/messages/$", requestMessages);
            httplistener.Route("^/Users/$", requestUsers);
            httplistener.Route("^/$",requestroot);          
            httplistener.Start();
        }

        //brugern request localhost:8080/
        string requestroot(Request r)
        {

            if (r.HttpMethod == "POST")
            {
                RequestData data = r.Data;
                string msg = data.Post["massage"];
                Database.InsertMessage(msg.ToString(), 3);
                
            }

            List<Message> messages = Database.GetMessages();
            List<User> users = Database.GetUsers();
            return HTMLGenerator.generateIndex(messages, users);
        }

        //Brugeren requester localhost 8080/messages/

        string requestMessages(Request r)
        {
            List<Message> messages = Database.GetMessages();
            return HTMLGenerator.GenerateMessages(messages);
        }

        string requestUsers(Request r)
        {
            List<User> user = Database.GetUsers();
            return HTMLGenerator.GenerateUser(user);
        }

        string requestStylesheet(Request reque)
        {
            return System.IO.File.ReadAllText("HTLM/Stylesheet.css");
        }

        //sender indholdet af CSS/JS og andre filer
        string requsetAsset(Request request)
        {
            return "";
        }

    }
}

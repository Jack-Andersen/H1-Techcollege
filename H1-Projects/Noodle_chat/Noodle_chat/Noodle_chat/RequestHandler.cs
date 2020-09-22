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
            httplistener.Route("^/login/$", requestLoginHTML);
            httplistener.Route("^/messages/$", requestMessages);
            httplistener.Route("^/Users/$", requestUsers);
            httplistener.Route("^/$", requestroot);
            httplistener.Start();
        }

        //brugern request localhost:8080/
        string requestroot(Request r)
        {
            User user = null;
            if (r.HttpMethod == "POST") //new
            {
                RequestData data = r.Data;
                if (r.Data.Post.ContainsKey("username"))
                {
                     user = logUserIn(r.Data);

                }
                else if (r.Data.Post.ContainsKey("massage"))
                {
                    int userID = 0;
                    int.TryParse(r.Data.Post["UserID"], out userID);
                    user = Database.GetUser(userID);

                    if (user != null)
                    { 
                    string msg = data.Post["massage"];
                    Database.InsertMessage(msg.ToString(), 3);
                    }
                }
            }
            if (user != null)
            {
                List<Message> messages = Database.GetMessages();
                List<User> users = Database.GetUsers();
                return HTMLGenerator.generateIndex(messages, users, user.UserID);
            }
            return HTMLGenerator.generateLogin(); //new


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

        string requestLoginHTML(Request request) //new
        {
            return HTMLGenerator.generateLogin();
        }

        public User logUserIn(RequestData data) //new
        {
            User user = Database.GetUserByLogin(data.Post["username"]);
            if (user == null)
            {
                Database.InsertUser(data.Post["username"]);
                user = Database.GetUserByLogin(data.Post["username"]);
            }



            return user;

        }
    }
}

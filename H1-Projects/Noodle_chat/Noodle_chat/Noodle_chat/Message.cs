using System;
using System.Collections.Generic;
using System.Text;

namespace Noodle_chat
{
    class Message
    {

        public int MessagesID { get; set; }
        public int MessagesUserID { get; set; }
        public string MessagesText { get; set; }
        public DateTime MessagesDate { get; set; }
        public User Sender { get; set; }
        public User Recipient { get; set; }

        //Constructor
        public Message(string text, int userID)
        {
            MessagesUserID = userID;        
            MessagesText = text;
            MessagesDate = DateTime.Now;
        }
    }
}

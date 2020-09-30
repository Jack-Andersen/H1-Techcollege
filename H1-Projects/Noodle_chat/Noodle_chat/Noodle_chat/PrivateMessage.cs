using System;
using System.Collections.Generic;
using System.Text;

namespace Noodle_chat
{
    class PrivateMessage : Message
    {

        public int RecipientID { get; set; }

        public PrivateMessage(string text, int userID, int recipient) : base(text, userID)
        {
            RecipientID = recipient;
        }
    }
}

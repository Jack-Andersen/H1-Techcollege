using System;
using System.Collections.Generic;
using System.Text;

namespace Noodle_chat
{
    class User
    {

        public int UserID { get; set; }
        public string UserName { get; set; }

        public User(int userid, string userName)
        {
            UserID = userid;
            UserName = userName;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JerslevKroMVC.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Mail { get; set; }
        public int? PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
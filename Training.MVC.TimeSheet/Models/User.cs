using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.MVC.TimeSheet.Models
{
    public class User
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Account Account;
    }
}
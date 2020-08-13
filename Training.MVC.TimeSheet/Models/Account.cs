using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.MVC.TimeSheet.Models
{
    public class Account
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
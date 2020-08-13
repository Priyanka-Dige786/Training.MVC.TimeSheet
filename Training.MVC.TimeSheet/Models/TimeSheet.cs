using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.MVC.TimeSheet.Models
{
    public class TimeSheet
    {
        public Guid Id { get; }
        public string ProjectName { get; set; }
        public int Hour { get; set; }
        public string Description { get; set; }
        public User User;
    }
}
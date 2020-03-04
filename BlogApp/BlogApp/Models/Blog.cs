using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class Blog
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string content { get; set; }
        public DateTime date { get; set; }
        public bool isConfirmation { get; set; }
        public bool isHomePage { get; set; }

        //foreignkey
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
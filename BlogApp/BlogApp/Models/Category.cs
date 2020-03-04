using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }

        //foreignkey
        public List<Blog> Blogs { get; set; }
    }
}
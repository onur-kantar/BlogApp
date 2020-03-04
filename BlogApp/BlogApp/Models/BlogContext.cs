using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogContext:DbContext
    {

        public BlogContext() : base("BlogDb")
        {
            //Başlatıcımızı çalıştırıyoruz
            Database.SetInitializer(new BlogInitializer());
        }

        //Veri tabanı gibi düşün. Veri tabanına tabloları ekleyelim
        public DbSet<Blog> blogs { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
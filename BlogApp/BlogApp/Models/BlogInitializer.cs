using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        //Veri Tabanı başlatıldığında gerçekleşecek olaylar (DropCreateDatabaseIfModelChanges)

        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { categoryName ="C#"},
                new Category() { categoryName ="ASP.Net"},
                new Category() { categoryName ="Entity Framework"},
                new Category() { categoryName ="Linq"},
                new Category() { categoryName ="Unity"},

            };

            foreach (var category in categories)
            {
                context.categories.Add(category);
            }
            context.SaveChanges();

            List<Blog> blogs = new List<Blog>()
            {
                new Blog(){ title="C# Hakkında", description="C# Hakkında İleri Düzey Bilgiler", date=DateTime.Now.AddDays(-10), content="C# programa dili en güzel dirdir.", isHomePage=true, isConfirmation=true, image="1.jpg", CategoryId=1},
                new Blog(){ title="ASP.Net Hakkında", description="ASP.Net Hakkında İleri Düzey Bilgiler", date=DateTime.Now.AddDays(-5), content="ASP.Net programa dili en güzel dirdir.", isHomePage=true, isConfirmation=true, image="2.jpg", CategoryId=2},
                new Blog(){ title="Entity Framework Hakkında", description="Entity Framework Hakkında İleri Düzey Bilgiler", date=DateTime.Now.AddDays(-3), content="Entity Framework programa dili en güzel dirdir.", isHomePage=true, isConfirmation=true, image="3.jpg", CategoryId=3},
                new Blog(){ title="Linq Hakkında", description="Linq Hakkında İleri Düzey Bilgiler", date=DateTime.Now.AddDays(-2), content="Linq programa dili en güzel dirdir.", isHomePage=true, isConfirmation=true, image="4.jpg", CategoryId=4},
                new Blog(){ title="Unity Hakkında", description="Unity Hakkında İleri Düzey Bilgiler", date=DateTime.Now.AddDays(-1), content="Unity programa dili en güzel dirdir.", isHomePage=true, isConfirmation=true, image="5.jpg", CategoryId=5},

            };

            foreach (var blog in blogs)
            {
                context.blogs.Add(blog);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
using BlogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private BlogContext blogContext = new BlogContext();
        public ActionResult Index()
        {
            return View(blogContext.blogs.ToList());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSite_Sultan.Models;

namespace BlogSite_Sultan.Controllers
{
    public class HomeController : Controller
    {
        Entities db = new Entities();

        public ActionResult Index()
        {
            var recentP = db.Posts.ToList();
            var category = db.Categories.ToList();

            ViewBag.recentPost = recentP;
            ViewBag.categories = category;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page created by Md Tipu SUltan.";
            ViewBag.source = "This is Sultan";

            return View();
        }
        public ActionResult Sultan()
        {
            ViewBag.myself = "Be good and stay Honest";

            return View();
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PluralsightExample.Models;

namespace PluralsightExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";
            var info = new AboutModel();
            info.Name = "Oasis Aqualounge";
            info.Location = "Downtown Toronto";

            return View(info);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
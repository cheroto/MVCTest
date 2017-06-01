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
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            ViewBag.Message = string.Format("{0}::{1} {2}", controller, action, id);

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

        public ActionResult Redirect()
        {
            return RedirectPermanent("http://www.google.com");
        }

        public ActionResult GoToAction()
        {
            return RedirectToAction("Contact", "Home");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PluralsightExample.Models;

namespace PluralsightExample.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult TestAction(string id)
        {
            //var model = new AboutModel();
            //model.Name = id;
            //return Content(model);
            string model = id;
            return View((object)model);
        }
    }
}
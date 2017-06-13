using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PluralsightExample.Models;

namespace PluralsightExample.Controllers
{
    [HandleError]
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult TestAction(string filterTerm)
        {
            var _db = new WebstoreDB();
            var model = _db.Products.ToList().OrderBy(p => p.ProductName).Where(p => filterTerm == null || p.CategoryID == int.Parse(filterTerm));
            

            return View(model);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PluralsightExample.Models;

namespace PluralsightExample.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            var model =
                from r in _reviews
                orderby r.Author
                select r;

            return View(model);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reviews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reviews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reviews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<BookReview> _reviews = new List<BookReview>
        {
            new BookReview
            {
                ID = 0,
                Name = "Name of the Wind",
                Category = "Fantasy",
                Author = "Patrick Rothfuss",
                Size = "Medium",
                Rating = 10
            },
            new BookReview
            {
                ID = 1,
                Name = "Brave New World",
                Category = "Distopic Fantasy",
                Author = "Adolf Huxley",
                Size = "Small",
                Rating = 8
            },
            new BookReview
            {
                ID = 2,
                Name = "Mystic River",
                Category = "Crime",
                Author = "Dennis Lehane",
                Size = "Medium",
                Rating = 9
            }
        };
    }
}

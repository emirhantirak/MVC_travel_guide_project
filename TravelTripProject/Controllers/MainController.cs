using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Controllers;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Blogs.Take(8).ToList();
            return View(values);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var value = db.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(value);

        }
        public PartialViewResult Partial2()
        {
            var value = db.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial3()
        {
            var value = db.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial4()
        {
            var value = db.Blogs.Take(3).ToList();
            return PartialView(value);

        }
        public PartialViewResult Partial5()
        {
            var value = db.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(value);
        }
    }
}
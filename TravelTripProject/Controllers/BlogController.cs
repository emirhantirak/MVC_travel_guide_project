using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context db = new Context();
        BlogComment bc = new BlogComment();
        public ActionResult Index()
        {
            //var values =  db.Blogs.ToList();
            bc.Value1 =  db.Blogs.ToList();
            bc.Value3 = db.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(bc);
        }
        public ActionResult BlogDetail(int id)
        {

            //var findBlog = c.Blogs.Where(x=> x.ID == id).ToList();
            bc.Value1 = db.Blogs.Where(x => x.ID == id).ToList();
            bc.Value2 = db.Comments.Where(x => x.BlogID == id).ToList();
            return View(bc);
        }

        [HttpGet]
        public PartialViewResult MakeComment(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult MakeComment(Comment c)
        {
            db.Comments.Add(c);
            db.SaveChanges();
            return PartialView();
        }
    }
}
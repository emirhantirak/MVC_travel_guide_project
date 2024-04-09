using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Entities;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context db = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var values = db.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog p)
        {
            db.Blogs.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var blg = db.Blogs.Find(id);
            db.Blogs.Remove(blg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetBlog(int id)
        {
            var bl = db.Blogs.Find(id);
            return View("GetBlog", bl);
        }
        public ActionResult UpdateBlog(Blog b)
        {
            var bl = db.Blogs.Find(b.ID);
            bl.Definition = b.Definition;
            bl.Title = b.Title;
            bl.BlogImage = b.BlogImage;
            bl.Date = b.Date;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var cmnt = db.Comments.ToList();
            return View(cmnt);
        }
        public ActionResult DeleteComment(int id)
        {
            var b = db.Comments.Find(id);
            db.Comments.Remove(b);
            db.SaveChanges();
            return RedirectToAction("CommentList");

        }
        public ActionResult GetComment(int id)
        {
            var cmmnt = db.Comments.Find(id);
            return View("GetComment", cmmnt);
        }
        public ActionResult UpdateComment(Comment b)
        {
            var comment = db.Comments.Find(b.ID);
            comment.Username = b.Username;
            comment.Mail = b.Mail;
            comment.Commnt = b.Commnt;
            db.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}
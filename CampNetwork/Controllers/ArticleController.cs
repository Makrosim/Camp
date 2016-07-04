using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CampNetwork.Models;

namespace CampNetwork.Controllers
{
    public class ArticleController : Controller
    {
        CampContext db = new CampContext();

        [HttpGet]
        public ActionResult Index(int id)
        {
            ViewBag.CampPlaceID = id;

            return View();
        }

        [HttpGet]
        public RedirectResult Delete(int id)
        {
            var currart = db.Articles.Find(1);
            var list = new List<Comment>();
            foreach (var a in currart.Comments)
            {
                list.Add(a);
            }
            foreach (var a in list)
            {
                db.Comments.Remove(a);
            }
            db.Articles.Remove(currart);
            db.SaveChanges();

            return Redirect("/Home/Index");
        }

        [HttpPost]
        public RedirectResult Index(Article art)
        {
            art.CreationDate = DateTime.Now;
            db.Articles.Add(art);
            db.SaveChanges();
            art.CampPlace = db.CampPlaces.Find(art.CampPlaceID);
            db.SaveChanges();

            return Redirect("/Home/Index");
        }
    }
}
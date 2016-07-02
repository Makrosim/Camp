using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CampNetwork.Models;
using System.Data.Entity;

namespace CampNetwork.Controllers
{
    public class UserController : Controller
    {
        CampContext db = new CampContext();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.User = db.Users.Find(1);
            return View();
        }

        [HttpPost]
        public ActionResult Index(User us)
        {
            db.Entry(us).State = EntityState.Modified;
            db.SaveChanges();
            ViewBag.User = us;

            return View();
        }
    }
}
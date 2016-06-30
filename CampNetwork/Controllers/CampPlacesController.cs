using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CampNetwork.Models;

namespace CampNetwork.Controllers
{
    public class CampPlacesController : Controller
    {
        CampContext db = new CampContext();
        // GET: CampPlaces
        public ActionResult Index()
        {
            User currUser = db.Users.Find(1);
            ViewBag.CP = currUser.CampPlaces.ToList();

            return View();
        }

        [HttpGet]
        public ActionResult AddCampPlace()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            db.CampPlaces.Remove(db.CampPlaces.Find(id));
            db.SaveChanges();

            return View("Index");
        }

        [HttpPost]
        public ActionResult AddCampPlace(CampPlace place)
        {
            place.User = db.Users.Find(1);
            db.CampPlaces.Add(place);
            db.SaveChanges();
            ViewBag.CP = db.Users.Find(1).CampPlaces.ToList();

            return View("Index");
        }
    }
}
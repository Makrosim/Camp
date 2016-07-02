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

        [HttpGet]
        public ActionResult Index()
        {
            User currUser = db.Users.Find(1);
            var cps = currUser.CampPlaces.ToList();
            ViewBag.CP = cps;

            var points = new List<string>();

            foreach (var cp in cps)
            {
                points.Add(cp.LocationX + " " + cp.LocationY + " " + cp.Name);
            }

            ViewBag.Points = points;

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
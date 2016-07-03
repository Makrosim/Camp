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
        public ActionResult Update(int id)
        {
            ViewBag.CP = db.CampPlaces.Find(id);

            return View();
        }

        [HttpPost]
        public RedirectResult Update(CampPlace cp)
        {
            db.Entry(cp).State = EntityState.Modified;
            db.SaveChanges();

            return Redirect("/CampPlaces/Index");
        }

        [HttpGet]
        public ActionResult CreateCampPlace()
        {
            return View();
        }

        [HttpPost]
        public RedirectResult CreateCampPlace(CampPlace place)
        {
            place.User = db.Users.Find(1);
            db.CampPlaces.Add(place);
            db.SaveChanges();
            ViewBag.CP = db.Users.Find(1).CampPlaces.ToList();

            return Redirect("/CampPlaces/Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            db.CampPlaces.Remove(db.CampPlaces.Find(id));
            db.SaveChanges();

            return View("Index");
        }
    }
}
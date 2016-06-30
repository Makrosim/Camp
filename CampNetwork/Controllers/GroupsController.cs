using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CampNetwork.Models;

namespace CampNetwork.Controllers
{
    public class GroupsController : Controller
    {
        CampContext db = new CampContext();
        // GET: Groups
        public ActionResult Groups()
        {
            ViewBag.Groups = db.Groups.ToList();
            return View();
        }

        [HttpGet]
        public ActionResult CreateGroup()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Open(int Id)
        {
            var group = db.Groups.Find(Id);
            ViewBag.Group = group;
            ViewBag.GroupArticles = group.Articles.ToList();
            return View();
        }

        [HttpPost]
        public RedirectResult Open(int grId, int ArtId)
        {
            Group gr = db.Groups.Find(grId);
            gr.Articles.Add(db.Articles.Find(ArtId));
            db.SaveChanges();
            return Redirect($"/Groups/Open/{grId}");
        }

        [HttpPost]
        public RedirectResult CreateGroup(Group gr)
        {
            User currUser = db.Users.Find(1);
            gr.Creator = currUser;
            gr.Members.Add(currUser);
            db.Groups.Add(gr);
            db.SaveChanges();
            return Redirect("Groups/Groups");
        }
    }
}
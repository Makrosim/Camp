using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CampNetwork.Models;
using System.Data.Entity;
using System.IO;

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
        public ActionResult Index(User us, HttpPostedFileBase image)
        {
            db.Entry(us).State = EntityState.Modified;
            db.SaveChanges();

            byte[] imageData = null;

            using (var binaryReader = new BinaryReader(image.InputStream))
            {
                imageData = binaryReader.ReadBytes(image.ContentLength);
            }

            var att = new Attachment
            {
                Type = "Image",
                Bytes = imageData
            };

            db.Attachments.Add(att);

            us = db.Users.Find(1);
            us.Attachment.Add(att);
            db.SaveChanges();

            ViewBag.User = us;

            return View();
        }
    }
}
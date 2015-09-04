using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Coopreport.Models;

namespace Coopreport.Controllers
{
    public class ProfileController : Controller
    {
        private CoopreportContext db = new CoopreportContext();

        // GET: Profile/Create
        public ActionResult Create()
        {
            ViewBag.UserID = db.User.Where(x => x.Username == User.Identity.Name).FirstOrDefault().UserID;
           // ViewBag.UserID = 1;
           ViewBag.user = User.Identity.Name;
            return View();
        }

        // POST: Profile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,Username,FirstName,LastName,Email,PhoneNo,Course")] Profile profile)
        {
            if (ModelState.IsValid)
            {
                db.Profile.Add(profile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

           // ViewBag.UserID = new SelectList(db.User, "UserID", "Username", profile.UserID);
            return View(profile);
        }

    }
}

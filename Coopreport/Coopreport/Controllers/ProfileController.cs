using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coopreport.Models;
using System.Data.Entity;

namespace Coopreport.Controllers
{
    [Authorize(Roles="Student")]
    public class ProfileController : Controller
    {
        private CoopreportContext db_context = new CoopreportContext();
        // GET: Profile
        public ActionResult Index()
        {
            var p = db_context.Profile.ToList();
            if (p.Count == 0)
            {
                return RedirectToAction("Create", "Profile");
            }
            return View(p);
        }

        public ActionResult Create()
        {
            ViewBag.name = User.Identity.Name;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Profile profile)
        {
            if (ModelState.IsValid)
            {
                db_context.Profile.Add(profile);
                db_context.SaveChanges();
                return RedirectToAction("Index", "Profile");
            }
            return View();
        }
    }
}
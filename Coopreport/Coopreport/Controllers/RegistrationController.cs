using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coopreport.Models;

namespace Coopreport.Controllers
{
    public class RegistrationController : Controller
    {
        private CoopreportContext db = new CoopreportContext();
        // GET: Registration
        public ActionResult Index()
        {
            return View(db.Registrations.ToList());
        }

        public ActionResult Create(Registration registration)
        {
            if (ModelState.IsValid)
            {
                db.Registrations.Add(registration);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registration);
        }
    }
}
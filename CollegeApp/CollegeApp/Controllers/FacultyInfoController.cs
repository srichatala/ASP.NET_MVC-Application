using CollegeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeApp.Controllers
{
    public class FacultyInfoController : Controller
    {
        CollegeContext db = new CollegeContext();
        // GET: FacultyInfo
        public ActionResult Index()
        {
            return View(db.Faculties.ToList());
        }
        [HttpGet]
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Faculty faculty) {
            if (ModelState.IsValid) {
                db.Faculties.Add(faculty);
                db.SaveChanges();
                return Redirect("Index");
            }
            return View(faculty);
        }
    }
}
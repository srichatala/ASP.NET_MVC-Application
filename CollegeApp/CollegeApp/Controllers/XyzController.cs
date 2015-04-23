using CollegeApp.Models;
using CollegeApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeApp.Controllers
{
    public class XyzController : Controller
    {
        private CollegeContext db = new CollegeContext();
        // GET: Xyz
        public ActionResult Index()
        {
            var students = db.Studetns.ToList();
            var courses = db.Courses.ToList();
            var enrollments = db.Enrollments.ToList();

            Course_Student totalinfo = new Course_Student();
            totalinfo.Courses = courses;
            totalinfo.Students = students;
            totalinfo.Enrollments = enrollments;
            return View(totalinfo);
        }
    }
}
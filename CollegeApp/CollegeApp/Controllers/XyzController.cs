using CollegeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeApp.Controllers
{
    public class XyzController : Controller
    {
       
        // GET: Xyz
        public ActionResult Index()
        {
            Student Stu1 = new Student();
            Stu1.Name = "Sinivas";
            Stu1.Address = "Milton";
            Stu1.PhoneNo = "647-786-6026";
            Student Stu2 = new Student();
            Stu2.Name = "Venkat";
            Stu2.Address = "Toronto";
            Stu2.PhoneNo = "647-786-0000";
             Student Stu3 = new Student();
            Stu3.Name = "Balaram";
            Stu3.Address = "Ongole";
            Stu3.PhoneNo = "647-786-0007";
            return View(Stu3);
        }
    }
}
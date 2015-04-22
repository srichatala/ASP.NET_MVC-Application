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

        // GET: Xyz
        public ActionResult Index()
        {
            Course ObjCourse = new Course();
            ObjCourse.CourseName = "Java";
            ObjCourse.TotalGrade = 80;
            //Send model data to view by using this controller
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

            //list objects append to another object

            List<Student> AllStu = new List<Student>();
            AllStu.Add(Stu1);
            AllStu.Add(Stu2);
            AllStu.Add(Stu3);

            Course_Student objCourse_Student = new Course_Student();
            objCourse_Student.Courses = ObjCourse;
            objCourse_Student.Students = AllStu;
            return View(objCourse_Student);
        }
    }
}
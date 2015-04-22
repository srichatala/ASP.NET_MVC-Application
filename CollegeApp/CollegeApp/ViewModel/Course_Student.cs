using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollegeApp.Models;

namespace CollegeApp.ViewModel
{
    public class Course_Student
    {
        public Course Courses { get; set; }
        public List<Student> Students { get; set; }
    }
}
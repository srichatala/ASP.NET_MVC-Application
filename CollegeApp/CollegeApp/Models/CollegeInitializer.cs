using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CollegeApp.Models;

namespace CollegeApp.Models
{
    public class CollegeInitializer : DropCreateDatabaseIfModelChanges<CollegeContext>
    {
        protected override void Seed(CollegeContext context)
        {
            var students = new List<Student>
            {
                new Student{
                    Name="Sri",
                    Address="Milton",
                    PhoneNo="6477866026"
                },
                new Student{
                    Name="Venkat",
                    Address="Toronto",
                    PhoneNo="6477862323"
                }
            };
            foreach (var item in students) {
                context.Studetns.Add(item);
            }
            context.SaveChanges();
        }
    }
}
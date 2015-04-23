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

            var courses = new List<Course>{
                new Course{
                    CourseName="Java",
                    TotalGrade= 8
                },
                 new Course{
                    CourseName="C#.Net",
                    TotalGrade= 8
                }
            };
            foreach (var item in courses) {
                context.Courses.Add(item);
            }
            context.SaveChanges();

            var enrollments = new List<Enrollment>{
                new Enrollment{
                    StudentId=1,
                    CourseId=1,
                    Grade=4
                }, new Enrollment{
                    StudentId=2,
                    CourseId=2,
                    Grade=5
                }
            };
            foreach (var item in enrollments) {
                context.Enrollments.Add(item);
            }
            context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CollegeApp.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CollegeApp.Models
{
    public class CollegeContext : DbContext
    {
        public DbSet<Student> Studetns { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<CollegeApp.Models.Faculty> Faculties { get; set; }
    }
}
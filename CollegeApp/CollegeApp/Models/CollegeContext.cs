using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CollegeApp.Models;

namespace CollegeApp.Models
{
    public class CollegeContext : DbContext
    {
        public DbSet<Student> Studetns { get; set; }
    }
}
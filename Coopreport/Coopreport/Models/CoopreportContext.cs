using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Coopreport.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Coopreport.Models
{
    public class CoopreportContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Report> Report { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
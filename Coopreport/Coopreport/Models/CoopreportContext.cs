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
        public DbSet<Profile> Profile { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Profile>()
           .HasKey(e => e.UserID);

            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<User>()
                        .HasOptional(s => s.Profile) // Mark StudentAddress is optional for Student
                        .WithRequired(ad => ad.User); // Create inverse relationship
            base.OnModelCreating(modelBuilder);
        }
    }
}
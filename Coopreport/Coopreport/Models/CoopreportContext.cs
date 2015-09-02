using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Coopreport.Models
{
    public class CoopreportContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Profile> Profile { get; set; }
    }
}
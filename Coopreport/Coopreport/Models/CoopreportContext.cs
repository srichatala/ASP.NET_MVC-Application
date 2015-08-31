﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Coopreport.Models
{
    public class CoopreportContext : DbContext
    {
        public DbSet<Registration> Registrations { get; set; }

        public System.Data.Entity.DbSet<Coopreport.Models.Advisor> Advisor { get; set; }

        public System.Data.Entity.DbSet<Coopreport.Models.EmpEvaForm> EmpEvaForm { get; set; }

    }
}
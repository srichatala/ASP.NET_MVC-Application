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

        public DbSet<Advisor> Advisor { get; set; }

        public DbSet<EmpEvaForm> EmpEvaForm { get; set; }

    }
}
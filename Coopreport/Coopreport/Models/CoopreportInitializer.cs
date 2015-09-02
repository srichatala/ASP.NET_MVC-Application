using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Coopreport.Models
{
    public class CoopreportInitializer :DropCreateDatabaseIfModelChanges<CoopreportContext>
    {
      
    }
}
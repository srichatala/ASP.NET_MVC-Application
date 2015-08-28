using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Coopreport.Models
{
    public class CoopreportInitializer : DropCreateDatabaseIfModelChanges<CoopreportContext>
    {
        protected override void Seed(CoopreportContext context)
        {
            var registration = new List<Registration>
            {
                new Registration{
                    StudentID = "300718283",
                    SFName = "Srinivas",
                    SLName="Chatala",
                    SProgram = "Software Engineering Technologies",
                    SEmail = "sri2vas@gmail.com",
                    Password= "srinivas"
                }
            };
            foreach (var item in registration)
            {
                context.Registrations.Add(item);
            }
            context.SaveChanges();
        }
    }
}
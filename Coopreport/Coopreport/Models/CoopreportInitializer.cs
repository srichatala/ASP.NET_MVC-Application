using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Coopreport.Models
{
    public class CoopreportInitializer :DropCreateDatabaseIfModelChanges<CoopreportContext>
    {
        protected override void Seed(CoopreportContext context)
        {
            //var User = new List<User>{
            //    new User{
            //        Username="300718283",
            //        Password="srinivas",
            //        Role="Student"
            //    }
            //};
            //foreach (var item in User)
            //{
            //    context.User.Add(item);
            //}
            //context.SaveChanges();

            //var profile = new List<Profile>{
            //    new Profile{
            //        Username="300718283",
            //        FirstName="Sri",
            //        LastName="Chatala",
            //        Email="sri2vas@gmail.com",
            //        PhoneNo="6477866026",
            //        Course="SET"
            //    }
            //};
            //foreach (var item in profile)
            //{
            //    context.Profile.Add(item);
            //}
            //context.SaveChanges();
        }
    }
}
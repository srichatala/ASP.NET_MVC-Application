namespace Coopreport.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Coopreport.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<Coopreport.Models.CoopreportContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Coopreport.Models.CoopreportContext context)
        {
            var User = new List<User>{
                new User{
                    Username="300718283",
                    Password="srinivas",
                    Role="Student"
                }
            };
            foreach (var item in User)
            {
                context.User.Add(item);
            }
            context.SaveChanges();

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

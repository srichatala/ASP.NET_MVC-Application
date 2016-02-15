using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coopreport;
using Coopreport.Controllers;
using Coopreport.Models;

namespace Coopreport.Tests.Controllers
{
    [TestClass]
    public class StudentController
    {
        [TestMethod]
        public void GetUsers() {

            var testUsers = GetTestUsers();

            var controller = new UserController(testUsers);

            var result = controller.GetUsers() as System.Collections.Generic.List<User>;
            Assert.AreEqual(testUsers.Count, result.Count);


        }
        private List<User> GetTestUsers()
        {
            var testUsers = new List<User>();
            testUsers.Add(new User { UserID = 1, Username = "Demo1", Password = "password", Role = "Student", FirstName = "Raj", LastName = "John", Email = "sri2vas@gmail.com", PhoneNo = "64778666026", Course = "Software engineer" });
            testUsers.Add(new User { UserID = 1, Username = "Demo2", Password = "password", Role = "Student", FirstName = "Raj", LastName = "John", Email = "sri2vas@gmail.com", PhoneNo = "64778666026", Course = "Software engineer" });

            return testUsers;
        }
    }

}

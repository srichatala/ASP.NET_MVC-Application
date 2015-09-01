using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coopreport.Models;

namespace Coopreport.Controllers
{
    public class UserController : Controller
    {
        private CoopreportContext db_context = new CoopreportContext();
        // GET: User
        public ActionResult Index()
        {
            return View(db_context.User.ToList());
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            return View();
        }
    }
}
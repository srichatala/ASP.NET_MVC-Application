using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coopreport.Models;
using System.Web.Security;

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
            var login = db_context.User.Where(x => x.Username == user.Username && x.Password == user.Password).Count();
            if (login != 0)
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Msg = "Invalid User Credentials";
                return View();
            }

        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                db_context.User.Add(user);
                db_context.SaveChanges();
                return Redirect("Login");
            }
            return View();
        }
    }
}
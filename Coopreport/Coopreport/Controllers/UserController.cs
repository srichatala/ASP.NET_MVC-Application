using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coopreport.Models;
using System.Web.Security;
using System.Net;
using System.Data.Entity;

namespace Coopreport.Controllers
{
    public class UserController : Controller
    {
        private CoopreportContext db_context = new CoopreportContext();
        // GET: User
        [Authorize(Roles = "Student")]
        public ActionResult Index()
        {
            var userid = db_context.User.Where(x => x.Username == User.Identity.Name).FirstOrDefault().UserID;
            User user = db_context.User.Find(userid);
            if (user == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(user);
        }
        [HttpPost]
        [Authorize(Roles="Student")]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                db_context.Entry(user).State = EntityState.Modified;
                db_context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
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
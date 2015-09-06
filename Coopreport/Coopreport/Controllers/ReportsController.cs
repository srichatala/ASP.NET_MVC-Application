using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coopreport.Models;

namespace Coopreport.Controllers
{
    [Authorize(Roles="Student")]
    public class ReportController : Controller
    {
        private CoopreportContext db_context = new CoopreportContext();
        // GET: Reports
        public ActionResult Index()
        {
            var reports = db_context.Report.ToList();
            if (reports == null) {
                ViewBag.msg = "So far, no reports submitted";
            }
            return View(reports);
        }
    }
}
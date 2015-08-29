using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Coopreport.Models;

namespace Coopreport.Controllers
{
    public class AdvisorsController : Controller
    {
        private CoopreportContext db = new CoopreportContext();

        // GET: Advisors
        public async Task<ActionResult> Index()
        {
            return View(await db.Advisor.ToListAsync());
        }

        // GET: Advisors/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advisor advisor = await db.Advisor.FindAsync(id);
            if (advisor == null)
            {
                return HttpNotFound();
            }
            return View(advisor);
        }

        // GET: Advisors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Advisors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AdvisorID,AdvisorName,AEmail,APhone,ACell,AArea,AUsername,APassword")] Advisor advisor)
        {
            if (ModelState.IsValid)
            {
                db.Advisor.Add(advisor);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(advisor);
        }

        // GET: Advisors/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advisor advisor = await db.Advisor.FindAsync(id);
            if (advisor == null)
            {
                return HttpNotFound();
            }
            return View(advisor);
        }

        // POST: Advisors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AdvisorID,AdvisorName,AEmail,APhone,ACell,AArea,AUsername,APassword")] Advisor advisor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advisor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(advisor);
        }

        // GET: Advisors/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advisor advisor = await db.Advisor.FindAsync(id);
            if (advisor == null)
            {
                return HttpNotFound();
            }
            return View(advisor);
        }

        // POST: Advisors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Advisor advisor = await db.Advisor.FindAsync(id);
            db.Advisor.Remove(advisor);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

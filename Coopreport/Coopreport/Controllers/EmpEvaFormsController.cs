using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Coopreport.Models;

namespace Coopreport.Controllers
{
    public class EmpEvaFormsController : Controller
    {
        private CoopreportContext db = new CoopreportContext();

        // GET: EmpEvaForms
        public ActionResult Index()
        {
            return View(db.EmpEvaForm.ToList());
        }

        // GET: EmpEvaForms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpEvaForm empEvaForm = db.EmpEvaForm.Find(id);
            if (empEvaForm == null)
            {
                return HttpNotFound();
            }
            return View(empEvaForm);
        }

        // GET: EmpEvaForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpEvaForms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmpEvaFormId,StudentName,StudentId,Organization,JobTitle,Term,year,InterestInWork,AbilityToLearn,QualityofWork,ProblemSolving,TeamWork,Dependability,ResponseToSupervision,Reflection,Resoursefulness,EthicalBehaviour,AppreciationofDiversity,EnterpreneurialOrientation,WrittenCommunication,OralCommuniation,InterpersonalCommunication,OverallPerformanceRating,SupervisorsComments,SupervisorsRecommendations,NextWorkTerm,OfferNextWorkTerm,OfferStatus,NextWorkTermFrom,NextWorkTermTo,SupervisorsName,SupervisorsTitle,Currentdate,ManagerName,Questionnaires")] EmpEvaForm empEvaForm)
        {
            if (ModelState.IsValid)
            {
                db.EmpEvaForm.Add(empEvaForm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empEvaForm);
        }

        // GET: EmpEvaForms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpEvaForm empEvaForm = db.EmpEvaForm.Find(id);
            if (empEvaForm == null)
            {
                return HttpNotFound();
            }
            return View(empEvaForm);
        }

        // POST: EmpEvaForms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmpEvaFormId,StudentName,StudentId,Organization,JobTitle,Term,year,InterestInWork,AbilityToLearn,QualityofWork,ProblemSolving,TeamWork,Dependability,ResponseToSupervision,Reflection,Resoursefulness,EthicalBehaviour,AppreciationofDiversity,EnterpreneurialOrientation,WrittenCommunication,OralCommuniation,InterpersonalCommunication,OverallPerformanceRating,SupervisorsComments,SupervisorsRecommendations,NextWorkTerm,OfferNextWorkTerm,OfferStatus,NextWorkTermFrom,NextWorkTermTo,SupervisorsName,SupervisorsTitle,Currentdate,ManagerName,Questionnaires")] EmpEvaForm empEvaForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empEvaForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empEvaForm);
        }

        // GET: EmpEvaForms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpEvaForm empEvaForm = db.EmpEvaForm.Find(id);
            if (empEvaForm == null)
            {
                return HttpNotFound();
            }
            return View(empEvaForm);
        }

        // POST: EmpEvaForms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpEvaForm empEvaForm = db.EmpEvaForm.Find(id);
            db.EmpEvaForm.Remove(empEvaForm);
            db.SaveChanges();
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

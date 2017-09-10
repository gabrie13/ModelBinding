using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Staff.Models;

namespace Staff.Controllers
{
    public class ShiftController : Controller
    {
        private StaffDB db = new StaffDB();

        // GET: Shift
        public ActionResult Index()
        {
            var shiftCloses = db.ShiftCloses.Include(s => s.Person);
            return View(shiftCloses.ToList());
        }

        // GET: Shift/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShiftClose shiftClose = db.ShiftCloses.Find(id);
            if (shiftClose == null)
            {
                return HttpNotFound();
            }
            return View(shiftClose);
        }

        // GET: Shift/Create
        public ActionResult Create()
        {
            ViewBag.PersonId = new SelectList(db.People, "PersonId", "FirstName");
            return View();
        }

        // POST: Shift/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShiftCloseId,PersonId,ClosingDate,ShiftNotes")] ShiftClose shiftClose)
        {
            if (ModelState.IsValid)
            {
                db.ShiftCloses.Add(shiftClose);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PersonId = new SelectList(db.People, "PersonId", "FirstName", shiftClose.PersonId);
            return View(shiftClose);
        }

        // GET: Shift/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShiftClose shiftClose = db.ShiftCloses.Find(id);
            if (shiftClose == null)
            {
                return HttpNotFound();
            }
            ViewBag.PersonId = new SelectList(db.People, "PersonId", "FirstName", shiftClose.PersonId);
            return View(shiftClose);
        }

        // POST: Shift/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShiftCloseId,PersonId,ClosingDate,ShiftNotes")] ShiftClose shiftClose)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shiftClose).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PersonId = new SelectList(db.People, "PersonId", "FirstName", shiftClose.PersonId);
            return View(shiftClose);
        }

        // GET: Shift/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShiftClose shiftClose = db.ShiftCloses.Find(id);
            if (shiftClose == null)
            {
                return HttpNotFound();
            }
            return View(shiftClose);
        }

        // POST: Shift/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShiftClose shiftClose = db.ShiftCloses.Find(id);
            db.ShiftCloses.Remove(shiftClose);
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

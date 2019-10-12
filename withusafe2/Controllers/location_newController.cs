using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using withusafe2.Models;

namespace withusafe2.Controllers
{
    public class location_newController : Controller
    {
        private LocationModel db = new LocationModel();

        // GET: location_new
        public ActionResult Index()
        {
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
            return View(db.location_new.ToList());
        }
        public ActionResult Test()
        {
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
            return View(db.location_new.ToList());
        }

        // GET: location_new/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            location_new location_new = db.location_new.Find(id);
            if (location_new == null)
            {
                return HttpNotFound();
            }
            return View(location_new);
        }

        // GET: location_new/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: location_new/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Suburb,Offence_rate,Risklevel,Latitude,Longitude")] location_new location_new)
        {
            if (ModelState.IsValid)
            {
                db.location_new.Add(location_new);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(location_new);
        }

        // GET: location_new/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            location_new location_new = db.location_new.Find(id);
            if (location_new == null)
            {
                return HttpNotFound();
            }
            return View(location_new);
        }

        // POST: location_new/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Suburb,Offence_rate,Risklevel,Latitude,Longitude")] location_new location_new)
        {
            if (ModelState.IsValid)
            {
                db.Entry(location_new).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(location_new);
        }

        // GET: location_new/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            location_new location_new = db.location_new.Find(id);
            if (location_new == null)
            {
                return HttpNotFound();
            }
            return View(location_new);
        }

        // POST: location_new/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            location_new location_new = db.location_new.Find(id);
            db.location_new.Remove(location_new);
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

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
    public class Disease_infectionController : Controller
    {
        private InfectionModel db = new InfectionModel();

        //GET: Disease_infection
        //public ActionResult Index()
        //{
        //    return View(db.Disease_infection.ToList());
        //}

        public ActionResult Index()
        {
            ViewBag.active4 = "active";
            ViewBag.font4 = "font-weight:900;font-style: italic;";
            var test = Request.Form["states[]"];
            if (test == null) { return RedirectToAction("Search_error", "symptoms"); }
            var names = Request.Form["states[]"].Split(',');
            var new_list = new List<Disease_infection>();
            //var test = db.Disease_infection.ToList();
            foreach (var infection in db.Disease_infection)
            {
                var flag = 0;
                foreach (var item in names)
                {
                    if (!infection.Symptoms.Contains(item)) { flag = 1; }
                }
                if (flag == 0)
                {
                    new_list.Add(infection);
                }
            }
            if (new_list.Count() == 0) { return RedirectToAction("Search_warning","symptoms"); }
            ViewBag.input = Request.Form["states[]"].Split(',').Count();
            return View(new_list);
        }

        //public ActionResult Index_warining()
        //{
            
        //    return View(db.Disease_infection.ToList());
        //}


        // GET: Disease_infection/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disease_infection disease_infection = db.Disease_infection.Find(id);
            if (disease_infection == null)
            {
                return HttpNotFound();
            }
            return View(disease_infection);
        }

        // GET: Disease_infection/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Disease_infection/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Disease_name,Other_names,Signs,Medication,Treatment,Infectous_control,Rate,Symptoms")] Disease_infection disease_infection)
        {
            if (ModelState.IsValid)
            {
                db.Disease_infection.Add(disease_infection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(disease_infection);
        }

        // GET: Disease_infection/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disease_infection disease_infection = db.Disease_infection.Find(id);
            if (disease_infection == null)
            {
                return HttpNotFound();
            }
            return View(disease_infection);
        }

        // POST: Disease_infection/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Disease_name,Other_names,Signs,Medication,Treatment,Infectous_control,Rate,Symptoms")] Disease_infection disease_infection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(disease_infection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(disease_infection);
        }

        // GET: Disease_infection/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Disease_infection disease_infection = db.Disease_infection.Find(id);
            if (disease_infection == null)
            {
                return HttpNotFound();
            }
            return View(disease_infection);
        }

        // POST: Disease_infection/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Disease_infection disease_infection = db.Disease_infection.Find(id);
            db.Disease_infection.Remove(disease_infection);
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

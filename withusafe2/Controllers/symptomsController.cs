using Newtonsoft.Json;
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
    public class symptomsController : Controller
    {
        private TruesymptomModel db = new TruesymptomModel();
        private InfectionModel db2 = new InfectionModel();

        // GET: symptoms
        public ActionResult Index()
        {
            return View(db.symptoms.ToList());
        }
        public ActionResult Search()
        {
            ViewBag.active4 = "active";
            ViewBag.font4 = "font-weight:900;font-style: italic;";
            return View(db.symptoms.ToList());
        }

        public ActionResult Search_warning()
        {
            ViewBag.active4 = "active";
            ViewBag.font4 = "font-weight:900;font-style: italic;";
            return View(db.symptoms.ToList());
        }
        public ActionResult Search_error()
        {
            ViewBag.active4 = "active";
            ViewBag.font4 = "font-weight:900;font-style: italic;";
            return View(db.symptoms.ToList());
        }
        //[HttpPost]
        public ActionResult SearchNext()
        {
            var names = Request.Form["states[]"].Split(',');
            var new_list = new List<Disease_infection>();
            var test = db2.Disease_infection.ToList();
            foreach (var infection in db2.Disease_infection)
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
            
            var i = new_list;
            //var aa = "aaa";
            return RedirectToAction("Test","symptoms",new { new_listt = i });
        }

        public ActionResult Test(List<Disease_infection> new_listt)
        {
            var listt = new_listt;
            return View(listt);
        }
        //public ActionResult Test(List<Disease_infection> list)
        //{
        //    var listt = list;
        //    return View(list);
        //}
        // GET: symptoms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            symptom symptom = db.symptoms.Find(id);
            if (symptom == null)
            {
                return HttpNotFound();
            }
            return View(symptom);
        }

        // GET: symptoms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: symptoms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,symptom_name")] symptom symptom)
        {
            if (ModelState.IsValid)
            {
                db.symptoms.Add(symptom);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(symptom);
        }

        // GET: symptoms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            symptom symptom = db.symptoms.Find(id);
            if (symptom == null)
            {
                return HttpNotFound();
            }
            return View(symptom);
        }

        // POST: symptoms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,symptom_name")] symptom symptom)
        {
            if (ModelState.IsValid)
            {
                db.Entry(symptom).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(symptom);
        }

        // GET: symptoms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            symptom symptom = db.symptoms.Find(id);
            if (symptom == null)
            {
                return HttpNotFound();
            }
            return View(symptom);
        }

        // POST: symptoms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            symptom symptom = db.symptoms.Find(id);
            db.symptoms.Remove(symptom);
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

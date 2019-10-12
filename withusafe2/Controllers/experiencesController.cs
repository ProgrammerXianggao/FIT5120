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
    public class experiencesController : Controller
    {
        private ExperienceModel db = new ExperienceModel();
        private ShareModel db2 = new ShareModel();

        // GET: experiences
        public ActionResult Index()
        {

            return View(db.experiences.ToList());
        }

        // GET: experiences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            experience experience = db.experiences.Find(id);
            if (experience == null)
            {
                return HttpNotFound();
            }
            return View(experience);
        }

        // GET: experiences/Create
        public ActionResult Create(string me)
        {
            ViewBag.active1 = "active";
            ViewBag.font1 = "font-style:italic;font-weight:800;";
            ViewBag.message = me;
            ViewBag.experience = db.experiences.ToList();
            List<SelectListItem> mySelectItemList = new List<SelectListItem>();

            mySelectItemList.AddRange(new[]{
            new SelectListItem() {Text = "Psychological Abuse", Value = "Psychological Abuse", Selected = true},
            new SelectListItem() {Text = "Emotional Abuse", Value = "Emotional Abuse", Selected = false},
            new SelectListItem() {Text = "Sexual Abuse", Value = "Sexual Abuse", Selected = false},
            new SelectListItem() {Text = "Physical Abuse", Value = "Physical Abuse", Selected = false},
            new SelectListItem() {Text = "Other", Value = "Other", Selected = false},
            });

            SelectList aSelectList = new SelectList(mySelectItemList);
            ViewBag.list = aSelectList;



            List<SelectListItem> test = new List<SelectListItem>();

            test.AddRange(new[]{
            new SelectListItem() {Text = "0", Value = "0", Selected = true},
            new SelectListItem() {Text = "1", Value = "1", Selected = false},

            });

            SelectList biubiubiu = new SelectList(test);
            ViewBag.visible = biubiubiu;


            List<SelectListItem> testt = new List<SelectListItem>();

            testt.AddRange(new[]{
            new SelectListItem() {Text = "yes", Value = "yes", Selected = true},
            new SelectListItem() {Text = "no", Value = "no", Selected = false},

            });

            SelectList piu = new SelectList(testt);
            ViewBag.yes = piu;
            return View();
        }

        // POST: experiences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Category,Title,Content,Visible,Published")] experience experience)
        {
            ViewBag.active1 = "active";
            ViewBag.font1 = "font-style:italic;font-weight:800;";
            if (ModelState.IsValid)
            {
                if ((experience.Title == null) || (experience.Content == null))
                {
                    var me = "Title and Content can not be empty!";
                    return RedirectToAction("Create",new { me});
                }
                else if (experience.Content.Split(' ').Length < 20) {
                    var me = "Minimum words of Content is 20!";
                    return RedirectToAction("Create",new { me});
                }
                db.experiences.Add(experience);
                db.SaveChanges();
                return RedirectToAction("Share_experienceSafe","Home");
            }
            //Share share = db2.Shares.ToList().Last();
            //var list = share.Share_records.Split('-');



            return View(experience);
        }
        //public ActionResult Create(int id,string Category,string Title, string Content)
        //{
        //    experience experience = new experience();
        //    experience.Id = id;
        //    experience.Category = Category;
        //    experience.Title = Title;
        //    experience.Content = Content;
        //    experience.Visible = "0";

        //    db.experiences.Add(experience);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");


        //}

        // GET: experiences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            experience experience = db.experiences.Find(id);
            if (experience == null)
            {
                return HttpNotFound();
            }
            return View(experience);
        }

        // POST: experiences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Category,Title,Content,Visible")] experience experience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(experience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(experience);
        }

        // GET: experiences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            experience experience = db.experiences.Find(id);
            if (experience == null)
            {
                return HttpNotFound();
            }
            return View(experience);
        }

        // POST: experiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            experience experience = db.experiences.Find(id);
            db.experiences.Remove(experience);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using withusafe2.Models;

namespace withusafe2.Controllers
{
    public class HomeController : Controller
    {
        private withusafeModel db = new withusafeModel();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Survey(quiz2 u)
        {
            //highRisk highRisk = db.h;
            //highRisk.First = 1;
            HighRisk highRisk = db.HighRisks.Find(1);
            if (u.first) { highRisk.First = 1; } else { highRisk.First = 0; }
            if (u.second) { highRisk.Second = 1; } else { highRisk.Second = 0; }
            if (u.third) { highRisk.Third = 1; } else { highRisk.Third = 0; }
            if (u.forth) { highRisk.Fourth = 1; } else { highRisk.Fourth = 0; }
            if (u.fifth) { highRisk.Fifth = 1; } else { highRisk.Fifth = 0; }
            if (u.sixth) { highRisk.Sixth = 1; } else { highRisk.Sixth = 0; }
            db.HighRisks.Add(highRisk);
            db.SaveChanges();
            return RedirectToAction("quizz");
        }

        public ActionResult test()
        {
            var q = Request["method"];
            Age age = db.Ages.Find(1);
            age.Age1 = q;
            db.Ages.Add(age);
            db.SaveChanges();
            return RedirectToAction("quiz");
        }
        public ActionResult quiz()
        {
            ViewBag.Message = "Risk Prevention";

            return View();
        }

        public ActionResult quizz()
        {
            ViewBag.Message = "Risk Prevention";
            return View();
        }
        public ActionResult Report()
        {
            ViewBag.Message = "Report";
            ViewBag.Test = "Test";
            ViewBag.Location = "BarWon";
            ViewBag.AreaRate = "13.2%";
            Gender gender = db.Genders.ToList().Last();
            Age age = db.Ages.ToList().Last();
            decimal assultno = 0;
            decimal totalno = 0;



            if ((gender.genderr != "prefer not to say") && (age.Age1 == "prefer not to say"))
            {
                var genderages = db.GenderAgeSafeties.Where(s => s.Gender == gender.genderr).ToList();
                foreach (var item in genderages)
                {
                    assultno = assultno + item.Assault;
                    totalno = totalno + item.Total;
                }
            }
            else if ((gender.genderr == "prefer not to say") && (age.Age1 == "prefer not to say"))
            {
                var genderages = db.GenderAgeSafeties.ToList();
                foreach (var item in genderages)
                {
                    assultno = assultno + item.Assault;
                    totalno = totalno + item.Total;
                }
            }
            else if ((gender.genderr == "prefer not to say") && (age.Age1 != "prefer not to say"))
            {
                var genderages = db.GenderAgeSafeties.Where(s => s.Age == age.Age1).ToList();
                foreach (var item in genderages)
                {
                    assultno = assultno + item.Assault;
                    totalno = totalno + item.Total;
                }
            }
            else
            {
                var genderages = db.GenderAgeSafeties.Where(s => (s.Gender == gender.genderr) && (s.Age == age.Age1)).ToList();
                foreach (var item in genderages)
                {
                    assultno = assultno + item.Assault;
                    totalno = totalno + item.Total;
                }
            }
            var result = decimal.Round((assultno / totalno) * 100, 2);
            ViewBag.Gender = gender.genderr;
            ViewBag.Age = age.Age1;
            ViewBag.RiskRate = result;
            return View();
        }
        [HttpPost]
        public ActionResult Reportt(quizz q)
        {

            ViewBag.Message = "Risk Prevention";
            Precaution precaution = db.Precautions.Find(1);
            if (q.firstt) { precaution.First = 1; } else { precaution.First = 0; }
            if (q.secondd) { precaution.Second = 1; } else { precaution.Second = 0; }
            if (q.thirdd) { precaution.Third = 1; } else { precaution.Third = 0; }
            if (q.forthh) { precaution.Fourth = 1; } else { precaution.Fourth = 0; }
            if (q.fifthh) { precaution.Fifth = 1; } else { precaution.Fifth = 0; }
            if (q.sixthh) { precaution.Sixth = 1; } else { precaution.Sixth = 0; }
            if (q.seventhh) { precaution.Seventh = 1; } else { precaution.Seventh = 0; }
            if (q.eighthh) { precaution.Eighth = 1; } else { precaution.Eighth = 0; }
            if (q.nighthh) { precaution.Nineth = 1; } else { precaution.Nineth = 0; }
            db.Precautions.Add(precaution);
            db.SaveChanges();
            return RedirectToAction("Report");
            // return RedirectToAction("index");

        }

        public ActionResult Age()
        {
            ViewBag.Message = "Please select your age group ";
            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Your Patient is Located in: ";
            return View();
        }

        public ActionResult Gender()
        {
            ViewBag.Message = "Please select your gender:";
            return View();
        }
        public ActionResult GenderNext()
        {

            ViewBag.Message = "Please select your gender:";
            var q = Request["method"];
            Gender gender = db.Genders.Find(1);
            gender.genderr = q;
            db.Genders.Add(gender);
            db.SaveChanges();
            return RedirectToAction("Age");
        }
    }
}
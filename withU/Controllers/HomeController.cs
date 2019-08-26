using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using withU.Models;

namespace withU.Controllers
{
    public class HomeController : Controller
    {
        private HighRiskmodel db = new HighRiskmodel();
        private PrecautionModel db2 = new PrecautionModel();
        private AgeModel db3 = new AgeModel();
        private GenderModel db4 = new GenderModel();
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

        public ActionResult RiskAssessment()
        {
            ViewBag.Message = "Your Risk Assessment page.";

            return View();
        }
        //public ActionResult RiskAssessment(Models.Calculate model, string command)
        //{
        //    if (command == "add")
        //    {
        //        model.Result = model.A + model.B + model.C + model.D;
        //    }
        //    ViewBag.Message = "Your Risk Assessment page.";

        //    return View(model);
        //}
        public ActionResult Survey()
        {
            ViewBag.Message = "Your Risk Assessment page.";

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
            if (u.third ) { highRisk.Third  = 1; } else { highRisk.Third  = 0; }
            if (u.forth ) { highRisk.Fourth  = 1; } else { highRisk.Fourth  = 0; }
            if (u.fifth) { highRisk.Fifth  = 1; } else { highRisk.Fifth  = 0; }
            if (u.sixth ) { highRisk.Sixth  = 1; } else { highRisk.Sixth  = 0; }
            db.HighRisks.Add(highRisk);
            db.SaveChanges();
            return RedirectToAction("quizz");
        }


        public ActionResult test()
        {
            var q = Request["method"];
            Age age = db3.Ages.Find(1);
            age.Age1 = q;
            db3.Ages.Add(age);
            db3.SaveChanges();
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
            return View();
        }
        [HttpPost]
        public ActionResult Report(quizz q)
        {

            ViewBag.Message = "Risk Prevention";
            Precaution precaution = db2.Precautions.Find(1);
            if (q.firstt) { precaution.First = 1; } else { precaution.First = 0; }
            if (q.secondd) { precaution.Second = 1; } else { precaution.Second = 0; }
            if (q.thirdd) { precaution.Third = 1; } else { precaution.Third = 0; }
            if (q.forthh) { precaution .Fourth = 1; } else { precaution.Fourth = 0; }
            if (q.fifthh) { precaution.Fifth = 1; } else { precaution.Fifth = 0; }
            if (q.sixthh) { precaution.Sixth = 1; } else { precaution.Sixth = 0; }
            if (q.seventhh) { precaution.Seventh = 1; } else { precaution.Seventh = 0; }
            if (q.eighthh) { precaution.Eighth = 1; } else { precaution.Eighth = 0; }
            if (q.nighthh) { precaution.Nineth = 1; } else { precaution.Nineth = 0; }
            db2.Precautions.Add(precaution);
            db2.SaveChanges();
            return View();
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
            Gender gender = db4.Genders.Find(1);
            gender.gender1 = q;
            db4.Genders.Add(gender);
            db4.SaveChanges();
            return RedirectToAction("Age");
        }





    }
}
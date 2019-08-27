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
        private PatientLocationIdModel db2 = new PatientLocationIdModel();
        private LocationModel db3 = new LocationModel();
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
            var checkboxones = db.Checkboxones.ToList();
            var checkboxtwos = db.Checkboxtwoes.ToList();
            Gender gender = db.Genders.ToList().Last();
            Age age = db.Ages.ToList().Last();
            Precaution precaution = db.Precautions.ToList().Last();
            HighRisk highRisk = db.HighRisks.ToList().Last();
            PatienLocationId patienLocationId = db2.PatienLocationIds.ToList().Last();
            decimal assultno = 0;
            decimal totalno = 0;
            var locationinfo = db3.Locations.Where(l => l.Id == patienLocationId.PLI).ToList();
            var offenceRate = locationinfo[0].OffenceRate;
            var aveAreaRate = 0.006839;
            ViewBag.Checkone = "";
            if (highRisk.First == 1) { ViewBag.Checkone += checkboxones[0].content + "; "; }
            if (highRisk.Second == 1) { ViewBag.Checkone += checkboxones[1].content + "; "; }
            if (highRisk.Third == 1) { ViewBag.Checkone += checkboxones[2].content + "; "; }
            if (highRisk.Fourth == 1) { ViewBag.Checkone += checkboxones[3].content + "; "; }
            if (highRisk.Fifth == 1) { ViewBag.Checkone += checkboxones[4].content + "; "; }
            if (highRisk.Sixth == 1) { ViewBag.Checkone += checkboxones[5].content + "; "; }
            if (highRisk.Seventh == 1) { ViewBag.Checkone += checkboxones[6].content; }
            ViewBag.Checkone = ViewBag.Checkone.TrimEnd(';');
            ViewBag.Checktwo = "";
            if (precaution.First == 0) { ViewBag.Checktwo += checkboxtwos[0].content += "; "; }
            if (precaution.Second == 0) { ViewBag.Checktwo += checkboxtwos[1].content += "; "; }
            if (precaution.Third == 0) { ViewBag.Checktwo += checkboxtwos[2].content += "; "; }
            if (precaution.Fourth == 0) { ViewBag.Checktwo += checkboxtwos[3].content += "; "; }
            if (precaution.Fifth == 0) { ViewBag.Checktwo += checkboxtwos[4].content += "; "; }
            if (precaution.Sixth == 0) { ViewBag.Checktwo += checkboxtwos[5].content += "; "; }
            if (precaution.Seventh == 0) { ViewBag.Checktwo += checkboxtwos[6].content += "; "; }
            if (precaution.Eighth == 0) { ViewBag.Checktwo += checkboxtwos[7].content += "; "; }
            if (precaution.Nineth == 0) { ViewBag.Checktwo += checkboxtwos[8].content ; }
            ViewBag.Checktwo = ViewBag.Checktwo.TrimEnd(';');

            if ((double)offenceRate > aveAreaRate) { ViewBag.noticification = "The Risk Index of this suburb is higher than average!"; }
            else { ViewBag.noticification = "The Risk Index of this suburb is higher than average!"; }
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
            if ((double)result > 4.18) { ViewBag.notification2 = "The Risk index of your characteristic is higher than average"; }
            else if((double)result < 4.18) { ViewBag.notification2 = "The Risk index of your characteristic is lower than average"; }
            else { ViewBag.notification2 = ""; }
            ViewBag.Message = "Report";
            ViewBag.Test = "Test";
            ViewBag.Gender = gender.genderr;
            if (ViewBag.Gender == "prefer not to say") { ViewBag.Gender ="Your"; }
            ViewBag.Age = age.Age1;
            ViewBag.RiskRate = result;
            ViewBag.Location = locationinfo[0].Suburb;
            ViewBag.AreaRate = (offenceRate * 100).ToString().Substring(0, 3) + '%';
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

        public ActionResult Gender(int? id)
        {
            PatienLocationId patienLocationId = db2.PatienLocationIds.Find(1);
            patienLocationId.PLI = id;
            db2.PatienLocationIds.Add(patienLocationId);
            db2.SaveChanges();
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
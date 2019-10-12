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
        //private LocationModel db3 = new LocationModel();
        private Location_newModel db4 = new Location_newModel();
        private ShareModel db5 = new ShareModel();
        private ExperienceModel db6 = new ExperienceModel();
        public ActionResult Index()
        {
            ViewBag.active = "active";
            @ViewBag.font = "font-weight:900;font-style: italic;";
            return View();
        }
        public ActionResult error()
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
            ViewBag.active3 = "active";
            ViewBag.font3 = "font-weight:900;font-style: italic;";
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Survey(quiz2 u)
        {
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
            //highRisk highRisk = db.h;
            //highRisk.First = 1;
            HighRisk highRisk = db.HighRisks.Find(1);
            if (u.first) { highRisk.First = 1; } else { highRisk.First = 0; }
            if (u.second) { highRisk.Second = 1; } else { highRisk.Second = 0; }
            if (u.third) { highRisk.Third = 1; } else { highRisk.Third = 0; }
            if (u.forth) { highRisk.Fourth = 1; } else { highRisk.Fourth = 0; }
            if (u.fifth) { highRisk.Fifth = 1; } else { highRisk.Fifth = 0; }
            if (u.sixth) { highRisk.Sixth = 1; } else { highRisk.Sixth = 0; }
            if (u.seventh) { highRisk.Seventh = 1; } else { highRisk.Seventh = 0; }
            db.HighRisks.Add(highRisk);
            db.SaveChanges();
            return RedirectToAction("report");
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
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
            ViewBag.Message = "Risk Prevention";
            //return RedirectToAction("Report");
            return View();
        }

        public ActionResult quizz()
        {
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
            ViewBag.Message = "Risk Prevention";
            return View();
        }
        public ActionResult Report()
        {
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
            var checkboxones = db.Checkboxones.ToList();
            var checkboxtwos = db.Checkboxtwoes.ToList();
            Gender gender = db.Genders.ToList().Last();
            Age age = db.Ages.ToList().Last();
            Precaution precaution = db.Precautions.ToList().Last();
            HighRisk highRisk = db.HighRisks.ToList().Last();
            PatienLocationId patienLocationId = db2.PatienLocationIds.ToList().Last();
            var test = patienLocationId.PLI;
             
            decimal assultno = 0;
            decimal totalno = 0;
            //var locationinfo = db3.Locations.Where(l => l.Id == patienLocationId.PLI).ToList();
            var locationinfo = db4.location_new.Where(l => l.Id == patienLocationId.PLI).ToList();
            var offenceRate = locationinfo[0].Offence_rate;
            var offenceID = locationinfo[0].Id;
            ViewBag.Location = locationinfo[0].Suburb;
            var locationRank = locationinfo[0].Risklevel;

            ViewBag.Checkone = "";
            if (highRisk.First == 1) { ViewBag.Checkone += checkboxones[0].content + "; "; }
            if (highRisk.Second == 1) { ViewBag.Checkone += checkboxones[1].content + "; "; }
            if (highRisk.Third == 1) { ViewBag.Checkone += checkboxones[2].content + "; "; }
            if (highRisk.Fourth == 1) { ViewBag.Checkone += checkboxones[3].content + "; "; }
            if (highRisk.Fifth == 1) { ViewBag.Checkone += checkboxones[4].content + "; "; }
            if (highRisk.Sixth == 1) { ViewBag.Checkone += checkboxones[5].content + "; "; }
            if (highRisk.Seventh == 1) { ViewBag.Checkone += checkboxones[6].content + "; "; }


            
            ViewBag.Checkone = "The patient has following high risk behaviours: " + ViewBag.Checkone;

            ViewBag.notification = locationRank;
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
            var result = decimal.Round((assultno / totalno), 2);
            if (result > (decimal)0.009) { ViewBag.RiskRate = "7.7"; ViewBag.Risklevel = "Low"; }
            if (result > (decimal)0.011) { ViewBag.RiskRate = "15.4"; }
            if (result > (decimal)0.02) { ViewBag.RiskRate = "23.1"; }
            if (result > (decimal)0.021) { ViewBag.RiskRate = "30.8"; }
            if (result > (decimal)0.028) { ViewBag.RiskRate = "38.5"; ViewBag.Risklevel = "Medium"; }
            if (result > (decimal)0.0351) { ViewBag.RiskRate = "46.2"; }
            if (result > (decimal)0.0352) { ViewBag.RiskRate = "53.8"; }
            if (result > (decimal)0.047) { ViewBag.RiskRate = "61.5"; }
            if (result > (decimal)0.064) { ViewBag.RiskRate = "69.2"; ViewBag.Risklevel = "High"; }
            if (result > (decimal)0.066) { ViewBag.RiskRate = "76.9"; }
            if (result > (decimal)0.075) { ViewBag.RiskRate = "84.6"; }
            if (result > (decimal)0.113) { ViewBag.RiskRate = "92.3"; }
            

            //if (result > (decimal)0.009) { ViewBag.notification2 = "The Risk index of your characteristic is 7.7"; }
            //if (result > (decimal)0.009) { ViewBag.notification2 = "The Risk index of your characteristic is 7.7"; }
            //if ((double)result > 4.18) { ViewBag.notification2 = "The Risk index of your characteristic is higher than average(4.18)"; }
            //else if((double)result < 4.18) { ViewBag.notification2 = "The Risk index of your characteristic is lower than average(4.18)"; }
            //else { ViewBag.notification2 = ""; }
            ViewBag.Message = "Report";
            ViewBag.Test = "Test";
            ViewBag.Gender = gender.genderr;
            if (ViewBag.Gender == "prefer not to say") { ViewBag.Gender ="People"; }
            if (age.Age1 == "65") { ViewBag.Age = age.Age1 + "+"; }
            else { ViewBag.Age = age.Age1; }
            
            if (ViewBag.Age == "prefer not to say") { ViewBag.Gender = "all"; }
            //ViewBag.RiskRate = result;
            
            ViewBag.AreaRate = (offenceRate * 100).ToString().Substring(0, 5)+"%";
            ViewBag.location_id = patienLocationId.PLI;
            return View(db4.location_new.ToList());
        }
        [HttpPost]
        public ActionResult Reportt(quizz q)
        {
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
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
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
            ViewBag.Message = "Please select your age group ";
            return View();
        }
        public ActionResult RiskControl()
        {
            //ViewBag.Message = "Please select your age group ";
            return View();
        }

        public ActionResult Location()
        {
            ViewBag.Message = "Your Patient is Located in: ";
            return View();
        }

        public ActionResult LocationNext(int? id)
        {
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
            PatienLocationId patienLocationId = db2.PatienLocationIds.Find(1);
            patienLocationId.PLI = id;
            db2.PatienLocationIds.Add(patienLocationId);
            db2.SaveChanges();
            ViewBag.Message = "Please select your gender:";
            return RedirectToAction("Gender");
        }

        public ActionResult Gender()
        {
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
            //PatienLocationId patienLocationId = db2.PatienLocationIds.Find(1);
            //patienLocationId.PLI = id;
            //db2.PatienLocationIds.Add(patienLocationId);
            //db2.SaveChanges();
            ViewBag.Message = "Please select your gender:";
            return View();
        }
        public ActionResult GenderNext()
        {
            ViewBag.active2 = "active";
            ViewBag.font2 = "font-style:italic;font-weight:800;";
            ViewBag.Message = "Please select your gender:";
            var q = Request["method"];
            Gender gender = db.Genders.Find(1);
            gender.genderr = q;
            db.Genders.Add(gender);
            db.SaveChanges();
            return RedirectToAction("Age");
        }
        public ActionResult Indexn()
        {
            ViewBag.Message = "Your Patient is Located in: ";
            return View();
        }
        public ActionResult Help()
        {
            //ViewBag.Message = "Your Patient is Located in: ";
            return View();
        }
        [Authorize]
        public ActionResult Share_experience()
        {
            ViewBag.active1 = "active";
            ViewBag.font1 = "font-style:italic;font-weight:800;";
            ViewBag.experience = db6.experiences.ToList();
            //ViewBag.Message = "Your Patient is Located in: ";
            return View(db4.location_new.ToList());
        }

        public ActionResult Share_next()
        {
            var location = Request.Form["states"];
            var safe = Request.Form["SA"];
            var time = Request.Form["time"];
            //var c = "test";
            Share share = db5.Shares.Find(1);
            share.Share_records = location + "-" + safe + "-" + time;
            db5.Shares.Add(share);
            db5.SaveChanges();
            return RedirectToAction("Create","experiences");

        }
        public ActionResult Share_experienceSafe(/*string location,string time*/)
        {
            Share share = db5.Shares.ToList().Last();
            var list = share.Share_records.Split('-');
            var location = list[0];
            var safe = list[1]; 
            var time = list[2];

            ViewBag.active1 = "active";
            ViewBag.font1 = "font-style:italic;font-weight:800;";

            ViewBag.location = location;

            ViewBag.experience = db6.experiences.ToList();
            var locationinfo = db4.location_new.Where(l => l.Suburb == location).ToList();
            location_new location_New = db4.location_new.Find(locationinfo[0].Id);
            if (time != "longer") {
                if (safe == "safe") { location_New.safe_count = location_New.safe_count + 1; }
                else { location_New.unsafe_count = location_New.unsafe_count + 1; }
            }
            db4.SaveChanges();
            if (locationinfo[0].safe_count + locationinfo[0].unsafe_count == 0) { ViewBag.count = 0; }
            ViewBag.safe = locationinfo[0].safe_count;
            ViewBag.notsafe = locationinfo[0].unsafe_count;
            return View(db4.location_new.ToList());
        }
        //public ActionResult Share_experienceUnsafe(string location,string time)
        //{
        //    ViewBag.active1 = "active";
        //    ViewBag.font1 = "font-style:italic;font-weight:800;";

        //    ViewBag.location = location;
        //    return View(db4.location_new.ToList());
        //}
        public ActionResult Protect()
        {
            return View();
        }
    }
}
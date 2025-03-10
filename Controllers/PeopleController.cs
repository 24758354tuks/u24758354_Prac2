using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u24758354_Prac2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult StudyView()
        {
            List<Models.PersonalModel> people = new List<Models.PersonalModel>();
            people.Add(new Models.PersonalModel { StudentNumber = "u24758354", FirstName = "Nhlanhla", LastName = "Mnisi", Email = "u24758354@tuks.co.za", myLink = "~/HTML/Nhlanhla.html" });
            people.Add(new Models.PersonalModel { StudentNumber = "u24805522", FirstName = "Aluwani", LastName = "Ndlovu", Email = "u24805522@tuks.co.za", myLink = "~/HTML/Aluwani.html" });
            people.Add(new Models.PersonalModel { StudentNumber = "u24758354", FirstName = "Khulekani", LastName = "Mpinga", Email = "u23@tuks.co.za", myLink = "~/HTML/Khulekani.html" });
            people.Add(new Models.PersonalModel { StudentNumber = "u24758354", FirstName = "Montel", LastName = "Radebe", Email = "u24758354@tuks.co.za", myLink = "~/HTML/Montel.html" });
            people.Add(new Models.PersonalModel { StudentNumber = "u24758354", FirstName = "Boitshoko", LastName = "Mphahlele", Email = "u24758354@tuks.co.za", myLink = "~/HTML/Boitshoko.html" });
            return View(people);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Foo()
        {
            return View("about");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5ATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }

        public ActionResult PersonName(string person)
        {
            var person_1 = "Jorge Monge";
            var person_2 = "Marta Monge";
            var person_3 = "Ricardo Monge";
            if (person == "person_1")
            {
                return Content(person_1);
            }
            else if (person == "person_2")
            {
                return Content(person_2);
            }
            return Content(person_3);
        }
    }
}
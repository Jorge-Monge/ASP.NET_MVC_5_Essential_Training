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
        {  ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {   // Properties of the ViewBag object can be defined by us
            //ViewBag.Message = "Your contact page.";
            ViewBag.myMessage = "Having trouble? Send us a message.";
            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO: send message to HQ
            ViewBag.myMessage = "Thanks, we got your message";
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
            // Line below will return the expected serial number
            //return Content(serial);
            // Line below will return a 403 error page
            //return new HttpStatusCodeResult(403, "Vete a la porra");
            // Line below will return a JSON text
            //return Json(new { name = "serial", value = serial }, JsonRequestBehavior.AllowGet);
            // Line below will redirect to another ActionResult or Controller
            return RedirectToAction("Index");
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
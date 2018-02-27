using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestEasyAuth.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            System.Diagnostics.Trace.TraceInformation("HomeController::Index entered in HomeController.cs");
            return View();
        }

        public ActionResult About()
        {
            System.Diagnostics.Trace.TraceInformation("HomeController::About entered in HomeController.cs");
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            System.Diagnostics.Trace.TraceInformation("HomeController::Contact entered in HomeController.cs");
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
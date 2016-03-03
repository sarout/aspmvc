using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About me.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Address, Email & Phone#.";

            return View();
        }
    }
}
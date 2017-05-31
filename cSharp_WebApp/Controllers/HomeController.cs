using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cSharp_WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult XML()
        {
            ViewBag.Message = "test";

            return View();
        }

        public ActionResult JSON()
        {
            ViewBag.Message = "test123";

            return View();
        }
    }
}
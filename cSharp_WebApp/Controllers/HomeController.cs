using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

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
            
            return View();
        }

        public ActionResult JSON()
        {
            int a = 5;
            
            for (int i = 0; i < a; i++)
            {
                ViewBag.Message = "test123";
            }

            return View();
        }
    }
}
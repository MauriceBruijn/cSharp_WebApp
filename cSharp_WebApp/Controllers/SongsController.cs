using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Data;
using cSharp_WebApp.Models;

namespace cSharp_WebApp.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult XML()
        {
            Songs songs = new Songs();
            return View();
        }

        public ActionResult Add(Songs a)
        {
            return View();
        }

        public ActionResult Edit(Songs e)
        {
            return View();
        }

        public ActionResult Delete(Songs d)
        {
            return View();
        }
    }
}
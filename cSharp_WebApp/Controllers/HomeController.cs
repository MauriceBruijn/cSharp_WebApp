using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Data;
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
            DataSet ds = new DataSet("playlist");

            DataTable dtSongs = new DataTable("song");

            DataColumn dcTitle = new DataColumn("title");
            DataColumn dcArtist = new DataColumn("artist");
            DataColumn dcPlaytime = new DataColumn("playtime");
            DataColumn dcRevealed = new DataColumn("revealed");
            DataColumn dcRating = new DataColumn("rating");

            ds.Tables.Add(dtSongs);

            dtSongs.Columns.Add(dcTitle);
            dtSongs.Columns.Add(dcArtist);
            dtSongs.Columns.Add(dcPlaytime);
            dtSongs.Columns.Add(dcRevealed);
            dtSongs.Columns.Add(dcRating);

            ds.ReadXml(Server.MapPath(@"..\App_Data\Songs.xml"));
            Session["xmlDataSet"] = ds;
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
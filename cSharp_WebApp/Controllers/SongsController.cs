﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Data;

namespace cSharp_WebApp.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
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
    }
}
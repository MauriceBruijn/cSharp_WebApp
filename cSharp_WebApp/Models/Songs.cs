using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Data;

namespace cSharp_WebApp.Models
{
    public class Songs
    {
        private DataSet ds;

        public Songs()
        {
            ds = new DataSet("playlist");

            DataTable dtSongs = new DataTable("song");

            DataColumn dcId = new DataColumn("id");
            DataColumn dcTitle = new DataColumn("title");
            DataColumn dcArtist = new DataColumn("artist");
            DataColumn dcPlaytime = new DataColumn("playtime");
            DataColumn dcRelease = new DataColumn("release");
            DataColumn dcRating = new DataColumn("rating");

            ds.Tables.Add(dtSongs);

            dtSongs.Columns.Add(dcId);
            dtSongs.Columns.Add(dcTitle);
            dtSongs.Columns.Add(dcArtist);
            dtSongs.Columns.Add(dcPlaytime);
            dtSongs.Columns.Add(dcRelease);
            dtSongs.Columns.Add(dcRating);

            ds.ReadXml(Server.MapPath("~/App_Data/Songs.xml"));
            Session["xmlDataSet"] = ds;
        }

        public void AddSong()
        {

        }

        public void DeleteSong()
        {

        }

        public void UpdateSong()
        {

        }

        public DataRow GetSong()
        {

        }
    }
}
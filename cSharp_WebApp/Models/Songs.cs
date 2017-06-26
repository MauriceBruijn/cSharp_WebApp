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

            ds.ReadXml(HttpContext.Current.Server.MapPath("~/App_Data/Songs.xml"));
            //HttpContext.Current.Session["xmlDataSet"] = ds;
        }

        public void AddSong(Songs a)
        {

        }

        public void DeleteSong(Songs d)
        {

        }

        public DataRow GetSong(string id)
        {
            DataRow[] drArray = ds.Tables[0].Select("id=" + id);
            return drArray[0];
        }

        public void UpdateSong(string id)
        {
            DataRow dr = GetSong(id);

            dr["title"] = HttpContext.Current.Request.Form["title"];
            dr["artist"] = HttpContext.Current.Request.Form["artist"];
            dr["playtime"] = HttpContext.Current.Request.Form["playtime"];
            dr["release"] = HttpContext.Current.Request.Form["release"];
            dr["rating"] = HttpContext.Current.Request.Form["rating"];

            SaveSongs();
        }

        public void GetSongs(Songs g)
        {
            
        }

        public void SaveSongs()
        {
            ds.WriteXml(HttpContext.Current.Server.MapPath("~/App_Data/Songs.xml"));
        }
    }
}
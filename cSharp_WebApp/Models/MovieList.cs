using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cSharp_WebApp.Models
{
    public class MovieList
    {

        public Movie[] Movies { get; set; }
    }

    public class Movie
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Playtime { get; set; }
        public string Release { get; set; }
    }

    
}
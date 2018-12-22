using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApp.Models
{
    public class Movies
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MovieDirector { get; set; }
        public int MovieReleaseYear { get; set; }
        public Uri MovieTrailerURL { get; set; }
    }
}
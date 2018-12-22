using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MoviesApp.Controllers
{
    public class MoviesController : ApiController
    {
        Movies[] movies = new Movies[]
        {
            new Movies { MovieId = 1, MovieTitle = "As Above, So Below", MovieDirector = "John Erick Dowdle", MovieReleaseYear = 2014, MovieTrailerURL = new Uri("https://www.imdb.com/title/tt2870612/videoplayer/vi1892855065?ref_=tt_ov_vi") },
            new Movies { MovieId = 2, MovieTitle = "Jurassic Park", MovieDirector = "Steven Spielberg", MovieReleaseYear = 1993, MovieTrailerURL = new Uri("https://www.imdb.com/title/tt0107290/videoplayer/vi177055257?ref_=tt_ov_vi") },
            new Movies { MovieId = 3, MovieTitle = "The Hunt for Red October", MovieDirector = "John McTiernan", MovieReleaseYear = 1990, MovieTrailerURL = new Uri("https://www.imdb.com/title/tt0099810/videoplayer/vi1935457049?ref_=tt_ov_vi") },
            new Movies { MovieId = 4, MovieTitle = "The Core", MovieDirector = "Jon Amiel", MovieReleaseYear = 2003, MovieTrailerURL = new Uri("https://www.imdb.com/title/tt0298814/videoplayer/vi210436377?ref_=tt_ov_vi") },
            new Movies { MovieId = 5, MovieTitle = "Independence Day", MovieDirector = "Roland Emmerich", MovieReleaseYear = 1996, MovieTrailerURL = new Uri("https://www.imdb.com/title/tt0116629/videoplayer/vi2181957401?ref_=tt_ov_vi") }
        };

        
        public IEnumerable<Movies> GetAllMovies()
        {
            return movies;
        }

        //[Route("api/movies/{id:int}")]
        //public Movies GetMovieInfo(int id)
        //{
            //return movies;
        //}

        public IHttpActionResult GetMovie(int id)
        {
            var movie = movies.FirstOrDefault((m) => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
    }
}

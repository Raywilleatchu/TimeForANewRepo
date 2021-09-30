using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    [Route("api/Movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        //https://localhost:44360/api/movie/
        [HttpGet]
        public List<Movie> GetAllMovies()
        {
            return DAL.GetMovies();
        }
        //https://localhost:44360/api/movie/category
        [HttpGet("category")]
        public List<Movie> GetMovieByCat(string cat)
        {
            return DAL.GetMoviesByCat(cat);
        }
        //https://localhost:44360/api/movie/categorytypes
        [HttpGet("categorytypes")]
        public List<Category> GetALLCategories()
        {
            return DAL.GetCategories();
        }
        //https://localhost:44360/api/movie/{title}
        [HttpGet("{title}")]
        public Movie GetMovie(string title)
        {
            return DAL.GetMovie(title);
        }

        //https://localhost:44360/api/movie/search/{key}
        [HttpGet("search/{key}")]
        public List<Movie> GetMoviesByKey(string key)
        {
            return DAL.GetMoviesByTitleKey(key);
        }

    }
}

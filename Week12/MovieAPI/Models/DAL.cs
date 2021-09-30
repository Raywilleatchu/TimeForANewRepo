using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class DAL
    {
        public static MySqlConnection DB;


        public static List<Movie> GetMovies()
        {
            return DB.GetAll<Movie>().ToList();
        }


        public static Movie GetMovie(string title)
        {
            var kv = new { title = title };
            string sql = "SELECT * FROM film WHERE title = @title";

            List<Movie> temp = DB.Query<Movie>(sql, kv).ToList();
            if (temp[0] != null)
            {
                Movie movie = temp[0];
                return movie;
            }
            else
            {
                return null;
            }
        }

        public static List<Movie> GetMoviesByCat(string cat)
        {
            var kv = new { id = GetCategoryID(cat) };
            //this sql string joins category id, film id and category name
            string sql = "SELECT film_category.category_id, film.film_id FROM film_category INNER JOIN film ON film_category.film_id = film.film_id INNER Join category on film_category.category_id=category.category_id where film_category.category_id=@id";
            //current issue: json not showing category name
            List<Movie> ids = DB.Query<Movie>(sql, kv).ToList();
            List<Movie> movies = new List<Movie>();
            string name = GetCategoryName(cat);
            foreach (Movie i in ids)
            {
                Movie m = DB.Get<Movie>(i.film_id);
                m.category_id = i.category_id;
                m.name = name;
                movies.Add(m);
            }
            
            return movies;

        }

        public static int GetCategoryID(string cat)
        {
            int id = 0;
            var kv = new { cat = cat };
            string sql = "select * from category where name = @cat";
            List<Category> temp = DB.Query<Category>(sql, kv).ToList();
            id = temp[0].category_id;
            return id;
        }

        public static string GetCategoryName(string cat)
        {
            string name = "";
            var kv = new { cat = cat };
            string sql = "select * from category where name = @cat";
            List<Category> temp = DB.Query<Category>(sql, kv).ToList();
            name = temp[0].name;
            return name;
        }

        public static List<Category> GetCategories()
        {
            return DB.GetAll<Category>().ToList();
        }



        public static List<Movie> GetMoviesByTitleKey(string key)
        {
            List<Movie> movies = GetMovies();
            List<Movie> result = new List<Movie>();
            foreach(Movie m in movies)
            {
                if (m.title.ToLower().Contains(key) || m.title.Contains(key))
                {
                    result.Add(m);
                }
            }

           return result;

        }
    }
}

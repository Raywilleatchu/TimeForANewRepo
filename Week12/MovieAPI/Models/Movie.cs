using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    [Table("film")]
    public class Movie : FilmCategory
    { 
        [Key]    
        public int film_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }


    [Table("film_category")]
    public class FilmCategory : Category
    {
        [Key]
        public int film_id { get; set; }
        public int category_id { get; set; }
    }

    [Table("category")]
    public class Category 
    {
        [Key]
        public int category_id { get; set; }
        public string name { get; set; }
    }



}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace StackOverflow.Models
{
    [Table ("Questions")]
    public class Questions
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public string category { get; set; }
        public string tags { get; set; }
        public int status { get; set; }
        //public IEnumerable posted { get; set; }
    }
}

using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10_3.Models
{
    [Table("coffee")]
    public class Coffee
    {    
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Category { get; set; }


        public override string ToString()
        {
            return $"{ProductID} {Name} {Description} {Price} {Category}";
        }
        
    }
}

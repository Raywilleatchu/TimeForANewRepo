using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10_3Demo.Models
{
    public class CategoryProducts
    {
        public Category cat { get; set; }
        public List<Product> prods { get; set; }
    }
}

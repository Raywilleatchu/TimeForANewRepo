using CoffeeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeApi.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public List<Category> getAllCats()
        {
            return DAL.GetAllCategories();
        }

        [HttpPost]
        public string InsertCat(Category cat)
        {
            DAL.InsertCategory(cat);
            return cat.id;
        }

        [HttpGet("testhello")]
        public string test()
        {
            return "Hello";
        }

        [HttpGet("testhello/there")]
        public string test2()
        {
            return "Hello There";
        }

        [HttpGet("{id}")]
        public Category test3(string id)
        {
            return DAL.GetCategory(id);
        }
    }
}

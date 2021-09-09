using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class CoffeeShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CoffeeShop()
        {
            ViewData["FirstName"] = "Ray";
            ViewData["LastName"] = "Mandingo";
            return View();
        }

        public IActionResult CoffeeForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CoffeeSubmitted(CoffeeClass coffee)
        {
            ViewData["Coffee"] = coffee;
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShop.Models;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace CoffeeShop.Controllers
{
    public class CoffeeShopController : Controller
    {

        public IActionResult CoffeeShop()
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=abc123");
            List<Coffee> drinks = db.GetAll<Coffee>().ToList();
            return View(drinks);
        }



        public IActionResult CoffeeSubmitted(int dr)
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeeshop;Uid=root;Password=abc123");
            Coffee drink = db.Get<Coffee>(dr);
            return View(drink);

            //This doesnt work. When an option in coffee shop is selected, the ProductID num is not being set to the page...
            
            //return Content(drink);
        }

    }
}

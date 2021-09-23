using Lab10_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Lab10_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List <Coffee> coffs = DAL.getAllCoffee();
            return View(coffs);
        }

        public IActionResult CoffeePage(int coffID)
        {
            Coffee coff = DAL.getCoffee(coffID);
            return View(coff);
        }

        public IActionResult Edit(int id)
        {
            Coffee coff = DAL.getCoffee(id);
            return View(coff);
        }

        public IActionResult SaveEdit(Coffee coff)
        {
            DAL.EditCoffee(coff);
            return Redirect($"/Home/CoffeePage?coffID={coff.ProductID}");
        }
        
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult SaveAdd(Coffee coff)
        {
            DAL.addCoffee(coff);
            return Redirect($"/Home/CoffeePage?coffID={coff.ProductID}");
        }

        public IActionResult Delete(int id)
        {
            DAL.delCoffee(id);
            return Redirect("/Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

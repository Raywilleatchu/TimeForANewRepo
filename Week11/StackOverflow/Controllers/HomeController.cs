using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StackOverflow.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace StackOverflow.Controllers
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
            List<Questions> q = DAL.GetQuestions();
            //QandA qq = new QandA(q);
            return View(q);
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult login(string username)
        {
            DAL.CurrentUser = username;
            return Redirect("/");
        }

        public IActionResult logout()
        {
            DAL.CurrentUser = null;
            return Redirect("/");
        }

        //Search Question
        public IActionResult SearchQuestion(string search)
        {
            List<Questions> quests = DAL.SearchQuestion(search);
            return View(quests);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

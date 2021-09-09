using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Controllers
{
    public class ValuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return Content("Welcome to the system");
        }

        public IActionResult AnotherPage()
        {
            ViewData["Name"] = "Fred";
            return View();
        }

        public IActionResult SignupForm()
        {
            return View();
        }

        public IActionResult SubmitForm(string firstname, string lastname, string mypassword)
        {
            return Content($"Thank You {firstname} {lastname} {mypassword}");
        }

    }
}

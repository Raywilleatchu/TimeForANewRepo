using CardsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Xrm.Sdk.Messages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CardsAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public async Task<IActionResult> GenerateDeck()
        {
            string domain = "https://deckofcardsapi.com/";
            string path = "api/deck/new/shuffle/?deck_count=1";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(domain);
            var connection = await client.GetAsync(path);
            Root result = await connection.Content.ReadAsAsync<Root>();
            return View(result);
        }

        public async Task<IActionResult> DrawCards(string id, int count)
        {
            string domain = "https://deckofcardsapi.com/";
            string path = $"api/deck/{id}/draw/?count={count}";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(domain);
            var connection = await client.GetAsync(path);
            Deck result = await connection.Content.ReadAsAsync<Deck>();
            return View(result);
        }

        public IActionResult TakeCards(Deck deck)
        {
            deck.hand = deck.cards;
            deck.showHand = true;
            return Redirect("/Home/DrawCards");
        }


        public IActionResult Index()
        {
            return View();
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

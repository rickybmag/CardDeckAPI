using DeckOfCardsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCardsAPI.Controllers
{
    public class HomeController : Controller
    {
        CardsDAL cd = new CardsDAL();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(Hand hand)
        {
            Hand h = cd.GetCards();            
            return View(h);
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Popularity.Domain;
using Popularity.Domain.Cards;
using Popularity.Models;

namespace Popularity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user1 = new User("peemagee");
            user1.AddPlayedCard(new ArcherCard());
            user1.AddPlayedCard(new KnightCard());
            var user2 = new User("poopsmagoo");
            user2.AddPlayedCard(new AssassinCard());
            user2.AddPlayedCard(new HealerCard());

            var gameEngine = new GameEngine();
            var results = gameEngine.ExecuteMove(user1, user2);
            return View("Index", results);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

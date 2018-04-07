using Microsoft.AspNetCore.Mvc;
using Popularity.Models;
using Popularity.Domain;
using Popularity.Domain.Cards;
using System.Collections.Generic;

namespace Popularity.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            var user1 = new User
            {
                FirstName = "David"
            };
            user1.AddCard(new KnightCard());
            user1.AddCard(new ArcherCard());

            var user2 = new User
            {
                FirstName = "Josh"
            };
            user1.AddCard(new AssassinCard());
            user1.AddCard(new HealerCard());

            var model = new GameModel
            {
                User1 = user1,
                User2 = user2
            };
            return View("Index", model);
        }

        public JsonResult Move(string user1Card, string user2Card)
        {
            return Json(null);
        }
    }
}
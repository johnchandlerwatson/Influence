using Microsoft.AspNetCore.Mvc;
using Popularity.Models;
using Popularity.Domain;
using Popularity.Domain.Cards;
using System.Collections.Generic;

namespace Popularity.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index(string username)
        {
            var user1 = new User(username);
            user1.AddHandCard(new KnightCard());
            user1.AddHandCard(new ArcherCard());

            var user2 = new User("bot");
            user1.AddHandCard(new AssassinCard());
            user1.AddHandCard(new HealerCard());

            var model = new MoveModel
            {
                User1 = user1,
                User2 = user2
            };
            return View("~/Views/Home/Game.cshtml", model);
        }

        public JsonResult Move(string user1Card, string user2Card)
        {
            return Json(null);
        }
    }
}
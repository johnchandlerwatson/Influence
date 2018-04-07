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
            var user = new User(username);
            user.AddHandCard(new KnightCard());
            user.AddHandCard(new ArcherCard());

            var bot = new User("bot");
            bot.AddHandCard(new AssassinCard());
            bot.AddHandCard(new HealerCard());

            var model = new MoveModel
            {
                User = user,
                Enemy = bot
            };
            return View("~/Views/Home/Game.cshtml", model);
        }

        public JsonResult Move(string user1Card, string user2Card)
        {
            return Json(null);
        }
    }
}
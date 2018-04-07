using Microsoft.AspNetCore.Mvc;
using Popularity.Models;
using Popularity.Domain;
using Popularity.Domain.Cards;
using System.Collections.Generic;
using System.Linq;

namespace Popularity.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index(string username)
        {
            var user = new User(username);
            user.AddHandCards(Dealer.GetRandomHand());

            var bot = new User("bot");
            bot.AddHandCards(Dealer.GetRandomHand());

            var model = new MoveModel
            {
                User = user,
                Enemy = bot
            };
            return View("~/Views/Home/Game.cshtml", model);
        }

        public IActionResult Move(string selection)
        {
            var user = new User("username");
            user.AddPlayedCard(Dealer.AllCards.First(x => x.Name == selection));
            user.AddHandCards(Dealer.GetRandomHand());

            var bot = new User("bot");
            bot.AddPlayedCard(Dealer.GetRandomCard());
            bot.AddHandCards(Dealer.GetRandomHand());

            var gameEngine = new GameEngine();
            var results = gameEngine.ExecuteMove(user, bot);

            return View("~/Views/Home/Game.cshtml", results);
        }
    }
}
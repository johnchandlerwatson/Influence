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

        public IActionResult Move(string selection)
        {
            var user = new User("username");
            var cards = new List<Card> { new KnightCard(), new ArcherCard()};
            var selectedCard = cards.First(x => x.Name == selection);
            user.AddHandCards(cards.Where(x => x.Name != selection).ToList());
            user.AddPlayedCard(selectedCard);

            var bot = new User("bot");

            var botCards = new List<Card> { new AssassinCard(), new HealerCard()};
            var botSelection = botCards.First();
            bot.AddHandCards(botCards.Where(x => x.Name != botSelection.Name).ToList());
            bot.AddPlayedCard(botSelection);

            var gameEngine = new GameEngine();
            var results = gameEngine.ExecuteMove(user, bot);

            return View("~/Views/Home/Game.cshtml", results);
        }
    }
}
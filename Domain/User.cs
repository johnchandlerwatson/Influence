using System.Collections.Generic;
using Popularity.Domain.Cards;

namespace Popularity.Domain
{
    public class User 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

        public List<Card> Cards { get; }

        public void AddCard(Card card)
        {
            card.User = this;
            Cards.Add(card);
        }
    }
}

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

        public List<Card> AvailableCards { get; } = new List<Card>();
        public List<Card> Played { get; set; } = new List<Card>();
        public List<Card> Hand { get; set; } = new List<Card>();

        public void AddAvailableCard(Card card)
        {
            card.User = this;
            AvailableCards.Add(card);
        }

        public void AddPlayedCard(Card card)
        {
            card.User = this;
            Played.Add(card);
        }

        public void AddHandCard(Card card)
        {
            card.User = this;
            Hand.Add(card);
        }
    }
}

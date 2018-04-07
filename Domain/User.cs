using System.Collections.Generic;
using Popularity.Domain.Cards;

namespace Popularity.Domain
{
    public class User 
    {
        public User(string username)
        {
            Username = username;
        }
        public string Username { get; }

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

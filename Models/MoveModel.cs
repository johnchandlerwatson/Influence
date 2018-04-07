using System.Collections.Generic;
using Popularity.Domain;
using Popularity.Domain.Cards;

namespace Popularity.Models
{
    public class MoveModel
    {
        public List<Card> User1Deck { get; set; }
        public List<Card> User2Deck { get; set; }
        public List<Card> User1Hand { get; set; }
        public List<Card> User2Hand { get; set; }
        public List<CardAction> Actions { get; set; }
    }
}
using System;
using System.Collections.Generic;
using Popularity.Domain;
using Popularity.Domain.Cards;
using System.Linq;

namespace Popularity.Models
{
    public class MoveModel
    {
        public User User { get; set; }
        public User Enemy { get; set; }
        public List<CardAction> Actions { get; set; } = new List<CardAction>();
        public string MoveSummary => string.Join(Environment.NewLine, Actions.Select(x => x.ActionDescription()));
    }
}
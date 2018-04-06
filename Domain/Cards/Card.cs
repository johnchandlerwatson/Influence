using System.Collections.Generic;

namespace Popularity.Domain.Cards
{
    public abstract class Card
    {
        public Card()
        {
            Health = MaxHealth;
        }
        public abstract string Name { get; }
        public abstract Row Row { get; }
        public abstract Row Targets { get; }
        public abstract Rarity Rarity { get; }
        public abstract int Speed { get; }
        public abstract int Damage { get; }
        public abstract int Healing { get; }
        public abstract int MaxHealth { get; }
        public int Health { get; set; }

        public abstract void ApplyMove(List<Card> enemyCards, List<Card> friendlyCards);

        public bool IsDead => Health < 0;
    }

    public enum Row 
    {
        Front,
        Back,
        Both
    }

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary,
        Mythic,
        Godly
    }
}
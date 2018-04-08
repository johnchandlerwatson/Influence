using System.Collections.Generic;
using System.Linq;

namespace Popularity.Domain.Cards
{
    public class TrollCard : Card
    {
        public override string Name => "Troll";
        public override Row Row => Row.Front;
        public override Row Targets => Row.Front;
        public override Rarity Rarity => Rarity.Common;
        public override int Damage => 6;
        public override int Healing => 0;
        public override int Speed => 1;
        public override int MaxHealth => 15;

        public override void ApplyMove(List<Card> enemyCards, List<Card> friendlyCards, List<CardAction> actions)
        {
            var targetedCards = TargetedCards(enemyCards);

            if (targetedCards.Any())
            {
                foreach (var enemy in targetedCards)
                {
                    enemy.Health = enemy.Health - Damage;
                }
                actions.Add(new CardAction(this, targetedCards, null));
            }
        }
    }
}
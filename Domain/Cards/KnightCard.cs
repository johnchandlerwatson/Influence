using System.Collections.Generic;
using System.Linq;

namespace Popularity.Domain.Cards
{
    public class KnightCard : Card
    {
        public override string Name => "Knight";
        public override Row Row => Row.Front;
        public override Row Targets => Row.Front;
        public override Rarity Rarity => Rarity.Common;
        public override int Damage => 4;
        public override int Healing => 0;
        public override int Speed => 2;
        public override int MaxHealth => 10;

        public override void ApplyMove(List<Card> enemyCards, List<Card> friendlyCards)
        {
            foreach (var enemy in enemyCards)
        }
    }
}
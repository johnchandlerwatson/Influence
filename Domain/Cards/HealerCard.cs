using System.Collections.Generic;
using System.Linq;

namespace Popularity.Domain.Cards
{
    public class HealerCard : Card
    {
        public override string Name => "Healer";
        public override Row Row => Row.Back;
        public override Row Targets => Row.Front;
        public override Rarity Rarity => Rarity.Rare;
        public override int MaxHealth => 3;
        public override int Damage => 1;
        public override int Healing => 3;
        public override int Speed => 3;

        public override void ApplyMove(List<Card> enemyCards, List<Card> friendlyCards)
        {
            foreach (var ally in friendlyCards.Where(x => x.Row == Row.Front))
            {
                var healthAfter = ally.Health + Healing;
                healthAfter = healthAfter > ally.MaxHealth ? ally.MaxHealth : healthAfter;
                ally.Health = healthAfter;
            }
        }
    }
}
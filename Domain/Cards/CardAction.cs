using System.Collections.Generic;
using Popularity.Domain;
using Popularity.Domain.Cards;
using System.Linq;

namespace Popularity.Domain
{
    public class CardAction
    {
        public CardAction(Card actorCard, List<Card> damagedCards, List<Card> healedCards)
        {
            Target = damagedCards.FirstOrDefault().User;
            Actor = actorCard.User;
            DamagedCards = damagedCards;
            HealedCards = healedCards;
            ActorCard = actorCard;
            Damage = actorCard.Damage;
            Healing = actorCard.Healing;
        }
        public User Target { get; }
        public User Actor { get; }
        public List<Card> DamagedCards { get; }
        public List<Card> HealedCards { get; }
        public Card ActorCard { get; }
        public int Damage { get; }
        public int Healing { get; }

        public string ActionDescription()
        {
            var actor = $"{Actor.Username}'s {ActorCard.Name} card";
            var damage = string.Empty;
            if (DamagedCards != null && DamagedCards.Any())
            {
                damage = $"attacked {Target.Username}'s {string.Join(",", DamagedCards.Select(x => x.Name))} card(s) for {ActorCard.Damage} damage";
            }
            var healing = string.Empty;
            if (HealedCards != null && HealedCards.Any())
            {
                healing = $"healed the {string.Join(",", HealedCards.Select(x => x.Name))} card(s) for {ActorCard.Healing} health";
            }

            var hasDamage = !string.IsNullOrEmpty(damage);
            var hasHealing = !string.IsNullOrEmpty(healing);
            if (hasDamage || hasHealing)
            {
                return $"{actor} {(hasDamage ? damage : string.Empty)} {(hasDamage && hasHealing ? "and" : string.Empty)} {(hasHealing ? healing : string.Empty)}"; 
            }
            return string.Empty;
        }
    }
}
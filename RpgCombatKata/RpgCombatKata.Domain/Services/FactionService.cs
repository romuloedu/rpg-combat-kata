using System.Linq;
using RpgCombatKata.Domain.Entities;

namespace RpgCombatKata.Domain.Services
{
    public class FactionService
    {
        public bool IsAllies(Character character1,
            Character character2)
        {
            // Use LINQ to intersect list and verify factions that match.
            return character1.Factions
            .Intersect(character2.Factions)
            .Any();
        }
    }
}
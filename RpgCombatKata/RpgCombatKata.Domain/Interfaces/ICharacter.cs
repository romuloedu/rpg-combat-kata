using System.Collections.Generic;
using RpgCombatKata.Domain.Entities;

namespace RpgCombatKata.Domain.Interfaces
{
    public interface ICharacter
    {
        float HealthPoints { get; }
        bool IsAlive { get; }
        uint Level { get; }
        IReadOnlyCollection<Faction> Factions { get; }

        void SetDamage(float damagePoints);
        void SetHeal(float healthPoints);
        void JoinFaction(Faction faction);
        void LeaveFaction(Faction faction);
    }
}
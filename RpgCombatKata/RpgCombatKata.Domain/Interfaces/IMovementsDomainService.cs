using System;
using RpgCombatKata.Domain.Entities;

namespace RpgCombatKata.Domain.Interfaces
{
    public interface IMovementsDomainService
    {
        void Attack(float damagePoints, IRangedCharacter attacker,
            IRangedCharacter target);

        void Heal(float healthPoints, IRangedCharacter healer,
            IRangedCharacter target);

        float CalculateHitThreshold(ICharacter attacker,
            ICharacter target);

        bool EnemyIsOnRange(IRangedCharacter attacker,
            IRangedCharacter target);

        bool HasAllyFaction(IRangedCharacter attacker,
            IRangedCharacter target);
    }
}

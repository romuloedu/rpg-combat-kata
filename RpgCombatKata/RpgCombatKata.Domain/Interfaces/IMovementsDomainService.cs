using System;
using RpgCombatKata.Domain.Entities;

namespace RpgCombatKata.Domain.Interfaces
{
    public interface IMovementsDomainService
    {
        void Attack(float damagePoints, IRangedCharacter attacker,
            IRangedCharacter target);

        float CalculateHitThreshold(ICharacter attacker,
            ICharacter target);

        bool EnemyIsOnRange(IRangedCharacter attacker,
            IRangedCharacter target);
    }
}

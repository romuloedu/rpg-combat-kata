using System;
using RpgCombatKata.Domain.Entities;

namespace RpgCombatKata.Domain.Interfaces
{
    public interface IMovementsDomainService
    {
        void Attack(float damagePoints, Character attacker,
            Character target);

        float CalculateHitThreshold(Character attacker,
            Character target);
    }
}

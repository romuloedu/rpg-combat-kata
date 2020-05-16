using System;
using RpgCombatKata.Domain.Entities;

namespace RpgCombatKata.Domain.Interfaces
{
    public interface IMovementsDomainService
    {
        void Attack(uint damagePoints, Character attacker,
            Character target);

        void Cure(uint healthPoints, Character healer,
            Character target);
    }
}

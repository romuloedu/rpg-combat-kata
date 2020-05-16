using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Interfaces;

namespace RpgCombatKata.Domain.Services
{
    public class MovementsDomainService : IMovementsDomainService
    {
        /// <summary>
        /// Provokes an attack to a enemy.
        /// </summary>
        /// <param name="damagePoints"></param>
        /// <param name="attacker"></param>
        /// <param name="target"></param>
        public void Attack(uint damagePoints, Character attacker,
            Character target)
        {
            target.SetDamage(damagePoints);
        }

        /// <summary>
        /// Cure the health of a character.
        /// </summary>
        /// <param name="healthPoints"></param>
        /// <param name="healer"></param>
        /// <param name="target"></param>
        public void Cure(uint healthPoints, Character healer,
            Character target)
        {
            target.SetHeal(healthPoints);
        }
    }
}

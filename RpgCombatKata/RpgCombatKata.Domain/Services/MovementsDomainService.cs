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
        public void Attack(float damagePoints, Character attacker,
            Character target)
        {
            if (attacker.Equals(target)) return;

            damagePoints *= CalculateHitThreshold(attacker, target);

            target.SetDamage(damagePoints);
        }

        public float CalculateHitThreshold(Character attacker,
            Character target)
        {
            int differenceLevel = (int)target.Level - (int)attacker.Level;

            if (differenceLevel >= 5)
            {
                return 0.5F;
            }
            else if (differenceLevel <= -5)
            {
                return 1.5F;
            }
            else
            {
                return 1.0F;
            }
        }
    }
}

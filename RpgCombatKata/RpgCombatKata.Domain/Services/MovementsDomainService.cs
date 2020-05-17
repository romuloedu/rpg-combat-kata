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
        public void Attack(float damagePoints, IRangedCharacter attacker,
            IRangedCharacter target)
        {
            if (attacker.Equals(target)
            || !EnemyIsOnRange(attacker, target)) return;

            damagePoints *= CalculateHitThreshold(attacker, target);

            target.SetDamage(damagePoints);
        }

        public float CalculateHitThreshold(ICharacter attacker,
            ICharacter target)
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

        public bool EnemyIsOnRange(IRangedCharacter attacker,
            IRangedCharacter target)
        {
            int differencePosition = (int)(target.Position.X - attacker.Position.X);

            differencePosition = Math.Abs(differencePosition);

            bool isOnRange = attacker.Range >= differencePosition;

            return isOnRange;
        }
    }
}

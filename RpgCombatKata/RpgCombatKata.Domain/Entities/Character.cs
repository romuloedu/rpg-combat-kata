using System;

namespace RpgCombatKata.Domain.Entities
{
    public class Character
    {
        /// <summary>
        /// Character health points.
        /// </summary>
        public float HealthPoints
        {
            get;
            private set;
        }

        /// <summary>
        /// Indicates if the character is alive (true) or dead (false).
        /// </summary>
        public bool IsAlive
        {
            get;
            private set;
        }

        /// <summary>
        /// Indicates the strength level of the character.
        /// </summary>
        public virtual uint Level
        {
            get;
            private set;
        }

        public Character()
        {
            Level = 1;
            IsAlive = true;
            HealthPoints = 1000;
        }

        // Implements the damage hit business logic.
        public void SetDamage(float damagePoints)
        {
            if (damagePoints >= 1000)
            {
                HealthPoints = 0;
                IsAlive = false;
                return;
            }

            HealthPoints -= damagePoints;
        }

        // Implements the cure business logic.
        public void SetHeal(float healthPoints)
        {
            if (!IsAlive) return;

            if ((HealthPoints + healthPoints) > 1000)
            {
                HealthPoints = 1000;
                return;
            }

            HealthPoints += healthPoints;
        }
    }
}

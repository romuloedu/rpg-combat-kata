using System;
using RpgCombatKata.Domain.Interfaces;

namespace RpgCombatKata.Domain.Entities
{
    public class Thing : ILivingThing
    {
        public bool IsDestroyed
        {
            get;
            private set;
        }

        public float HealthPoints
        {
            get;
            private set;
        }

        public Thing(float healthPoints)
        {
            HealthPoints = healthPoints;
        }

        public void SetDamage(float damagePoints)
        {
            if (damagePoints >= HealthPoints)
            {
                HealthPoints = 0;
                IsDestroyed = true;
                return;
            }

            HealthPoints -= damagePoints;
        }
    }
}

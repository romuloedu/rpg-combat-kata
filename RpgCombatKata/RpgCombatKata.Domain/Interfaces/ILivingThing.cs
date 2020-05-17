using RpgCombatKata.Domain.Entities;

namespace RpgCombatKata.Domain.Interfaces
{
    public interface ILivingThing
    {
        float HealthPoints { get; }

        void SetDamage(float damagePoints);
    }
}
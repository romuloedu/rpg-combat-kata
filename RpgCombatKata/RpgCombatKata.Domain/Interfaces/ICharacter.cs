namespace RpgCombatKata.Domain.Interfaces
{
    public interface ICharacter
    {
        float HealthPoints { get; }
        bool IsAlive { get; }
        uint Level { get; }
        void SetDamage(float damagePoints);
        void SetHeal(float healthPoints);
    }
}
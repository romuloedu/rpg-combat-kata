using RpgCombatKata.Domain.Entities;

namespace RpgCombatKata.Domain.Services
{
    public class HealService
    {
        public void Heal(float healthPoints, Character healer,
        Character target)
        {
            FactionService factionService = new FactionService();

            if (!factionService.IsAllies(healer, target)) return;

            target.SetRegeneration(healthPoints);
        }
    }
}
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Interfaces;

namespace RpgCombatKata.Domain.Services
{
    public class AttackService
    {
        public void Attack(float damagePoints, Character attacker,
            ILivingThing target)
        {
            PositionService positionService = new PositionService();
            FactionService factionService = new FactionService();

            if (target is Character enemy)
            {
                if (attacker.Equals(target) ||
                    !positionService.IsInRange(attacker, enemy) ||
                    factionService.IsAllies(attacker, enemy)) return;

                damagePoints *= CalculateThreshold(attacker, enemy);
            }

            target.SetDamage(damagePoints);
        }

        public float CalculateThreshold(Character attacker,
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
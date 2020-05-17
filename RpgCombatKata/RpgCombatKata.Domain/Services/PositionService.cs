using System;
using RpgCombatKata.Domain.Entities;

namespace RpgCombatKata.Domain.Services
{
    public class PositionService
    {
        public bool IsInRange(Character attacker, Character target)
        {
            int differencePosition = (int)(target.Position.X - attacker.Position.X);
            differencePosition = Math.Abs(differencePosition);
            bool isOnRange = attacker.MaxRange >= differencePosition;
            return isOnRange;
        }
    }
}
using RpgCombatKata.Domain.Entities;

namespace RpgCombatKata.Domain.Interfaces
{
    public interface IRangedCharacter : ICharacter
    {
        uint Range { get; }

        MapPosition Position { get; }
    }
}
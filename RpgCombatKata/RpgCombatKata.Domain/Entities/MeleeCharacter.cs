using System;
using RpgCombatKata.Domain.Interfaces;

namespace RpgCombatKata.Domain.Entities
{
    public class MeleeCharacter : Character, IRangedCharacter
    {
        /// <summary>
        ///  The attacke range alcance.
        /// </summary>
        public uint Range
        {
            get { return 2; }
        }

        /// <summary>
        /// Character location on the map.
        /// </summary>
        public MapPosition Position
        {
            get;
            private set;
        }

        public MeleeCharacter()
        {
            Position = new MapPosition();
            Position.X = 0;
        }
    }
}

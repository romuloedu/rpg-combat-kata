using System;
using RpgCombatKata.Domain.Interfaces;

namespace RpgCombatKata.Domain.Entities
{
    public class RangedCharacter : Character, IRangedCharacter
    {
        /// <summary>
        ///  The attacke range alcance.
        /// </summary>
        public uint Range
        {
            get { return 20; }
        }

        /// <summary>
        /// Character location on the map.
        /// </summary>
        public MapPosition Position
        {
            get;
            private set;
        }

        public RangedCharacter()
        {
            Position = new MapPosition();
            Position.X = 0;
        }
    }
}

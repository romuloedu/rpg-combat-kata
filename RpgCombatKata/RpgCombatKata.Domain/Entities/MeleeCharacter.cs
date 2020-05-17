using System;
using RpgCombatKata.Domain.Interfaces;

namespace RpgCombatKata.Domain.Entities
{
    public class MeleeCharacter : Character
    {
        /// <summary>
        ///  The attacke range alcance.
        /// </summary>
        public override uint MaxRange
        {
            get { return 2; }
        }
    }
}

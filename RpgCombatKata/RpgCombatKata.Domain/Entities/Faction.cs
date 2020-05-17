using System;
using RpgCombatKata.Domain.Interfaces;

namespace RpgCombatKata.Domain.Entities
{
    public class Faction
    {
        public int Id
        {
            get;
            private set;
        }

        public Faction(int id)
        {
            Id = id;
        }
    }
}

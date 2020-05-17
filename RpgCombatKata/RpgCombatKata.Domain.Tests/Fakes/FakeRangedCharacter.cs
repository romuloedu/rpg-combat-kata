using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Interfaces;
using Xunit;

namespace RpgCombatKata.Domain.Fakes.Tests
{
    public class FakeRangedCharacter : Character, IRangedCharacter
    {
        internal uint _range = 0;
        internal MapPosition _position = new MapPosition();

        public uint Range
        {
            get { return this._range; }
        }

        public MapPosition Position
        {
            get { return this._position; }
        }
    }
}

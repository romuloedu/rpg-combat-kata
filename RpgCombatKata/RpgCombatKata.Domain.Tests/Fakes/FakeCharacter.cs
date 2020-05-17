using System;
using RpgCombatKata.Domain.Entities;
using Xunit;

namespace RpgCombatKata.Domain.Fakes.Tests
{
    public class FakeCharacter : Character
    {
        internal uint _maxRange = 0;

        public override uint MaxRange
        {
            get { return this._maxRange; }
        }
    }
}

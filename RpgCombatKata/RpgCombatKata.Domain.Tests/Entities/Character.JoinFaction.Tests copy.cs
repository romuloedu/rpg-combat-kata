using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class CharacterTests
    {
        [Fact]
        public void JoinFaction_WhenFactionIsNull_ThrowsAnException()
        {
            FakeCharacter sut = new FakeCharacter();

            Assert.Throws<NullReferenceException>(() => sut.JoinFaction(null));
        }

        [Fact]
        public void JoinFaction_WhenFactionIsNotNull_ReturnListCountAs1()
        {
            FakeCharacter sut = new FakeCharacter();
            Faction faction = new Faction(100);

            sut.JoinFaction(faction);

            Assert.Single(sut.Factions);
        }
    }
}

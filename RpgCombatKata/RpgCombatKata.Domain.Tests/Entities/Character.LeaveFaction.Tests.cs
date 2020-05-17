using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class CharacterTests
    {
        [Fact]
        public void LeaveFaction_WhenFactionIsNull_ThrowsAnException()
        {
            FakeCharacter sut = new FakeCharacter();

            Assert.Throws<NullReferenceException>(() => sut.LeaveFaction(null));
        }

        [Fact]
        public void LeaveFaction_WhenFactionExists_RemoveFactionFromList()
        {
            FakeCharacter sut = new FakeCharacter();
            Faction faction = new Faction(100);

            sut.JoinFaction(faction);
            sut.LeaveFaction(faction);

            Assert.Empty(sut.Factions);
        }

        [Fact]
        public void LeaveFaction_WhenFactionExists_RemoveFactionFromListAndKeepRemaining()
        {
            FakeCharacter sut = new FakeCharacter();
            Faction faction = new Faction(100);
            Faction faction2 = new Faction(999);

            sut.JoinFaction(faction);
            sut.JoinFaction(faction2);
            sut.LeaveFaction(faction);

            Assert.Equal(1, sut.Factions.Count);
        }

        [Fact]
        public void LeaveFaction_WhenFactionNotExists_ReturnFactionList()
        {
            FakeCharacter sut = new FakeCharacter();
            Faction faction = new Faction(100);
            Faction faction2 = new Faction(999);
            Faction faction3 = new Faction(1738);

            sut.JoinFaction(faction);
            sut.JoinFaction(faction2);
            sut.LeaveFaction(faction3);

            Assert.Equal(2, sut.Factions.Count);
        }
    }
}

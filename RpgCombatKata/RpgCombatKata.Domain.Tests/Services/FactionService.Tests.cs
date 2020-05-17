using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public class FactionServiceTests
    {
        [Fact]
        public void IsAllies_WhenCharactersAreAllies_ReturnsTrue()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);
            Faction faction3 = new Faction(3);

            FakeCharacter character = new FakeCharacter();
            character.JoinFaction(faction3);

            FakeCharacter character2 = new FakeCharacter();
            character2.JoinFaction(faction);
            character2.JoinFaction(faction2);
            character2.JoinFaction(faction3);

            FactionService sut = new FactionService();

            bool result = sut.IsAllies(character, character2);

            Assert.True(result);
        }

        [Fact]
        public void IsAllies_WhenCharactersArentAllies_ReturnsFalse()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);

            FakeCharacter character = new FakeCharacter();
            character.JoinFaction(faction);

            FakeCharacter character2 = new FakeCharacter();
            character2.JoinFaction(faction2);

            FactionService sut = new FactionService();

            bool result = sut.IsAllies(character, character2);

            Assert.False(result);
        }
    }
}


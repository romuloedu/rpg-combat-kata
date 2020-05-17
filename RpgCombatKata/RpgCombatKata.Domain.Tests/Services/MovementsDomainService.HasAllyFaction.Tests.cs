using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public partial class MovementsDomainServiceTests
    {
        [Fact]
        public void HasAllyFaction_WhenCharactersAreAllies_ReturnsTrue()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);
            Faction faction3 = new Faction(3);

            FakeRangedCharacter character = new FakeRangedCharacter();
            character.JoinFaction(faction3);

            FakeRangedCharacter character2 = new FakeRangedCharacter();
            character2.JoinFaction(faction);
            character2.JoinFaction(faction2);
            character2.JoinFaction(faction3);

            MovementsDomainService sut = new MovementsDomainService();

            bool result = sut.HasAllyFaction(character, character2);

            Assert.True(result);
        }

        [Fact]
        public void HasAllyFaction_WhenCharactersArentAllies_ReturnsFalse()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);

            FakeRangedCharacter character = new FakeRangedCharacter();
            character.JoinFaction(faction);

            FakeRangedCharacter character2 = new FakeRangedCharacter();
            character2.JoinFaction(faction2);

            MovementsDomainService sut = new MovementsDomainService();

            bool result = sut.HasAllyFaction(character, character2);

            Assert.False(result);
        }
    }
}

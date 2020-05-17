using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class CharacterTests
    {
        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsHealthPointsAs1000()
        {
            FakeCharacter sut = new FakeCharacter();

            Assert.Equal(1000, sut.HealthPoints);
        }

        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsLevelAs1()
        {
            FakeCharacter sut = new FakeCharacter();

            Assert.Equal<uint>(1, sut.Level);
        }

        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsIsAliveAsTrue()
        {
            FakeCharacter sut = new FakeCharacter();

            Assert.True(sut.IsAlive);
        }
    }
}

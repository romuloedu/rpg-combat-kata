using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public class PositionServiceTests
    {
        [Theory]
        [InlineData(5, 10, 8)]
        [InlineData(5, 8, 10)]
        [InlineData(2, 3, 1)]
        public void IsInRange_WhenEnemyDistanceIsSmallerOrEqualRange_ReturnsTrue(
            uint attackerRange, uint attackerPosition,
            uint enemyPosition)
        {
            FakeCharacter attacker = new FakeCharacter();
            attacker._maxRange = attackerRange;
            attacker.Position.X = attackerPosition;

            FakeCharacter enemy = new FakeCharacter();
            enemy.Position.X = enemyPosition;

            PositionService sut = new PositionService();

            bool isOnRange = sut.IsInRange(attacker, enemy);

            Assert.True(isOnRange);
        }

        [Theory]
        [InlineData(2, 0, 3)]
        [InlineData(1, 20, 18)]
        public void IsInRange_WhenEnemyDistanceIsGreaterThanRange_ReturnsFalse(
           uint attackerRange, uint attackerPosition,
           uint enemyPosition)
        {
            FakeCharacter attacker = new FakeCharacter();
            attacker._maxRange = attackerRange;
            attacker.Position.X = attackerPosition;

            FakeCharacter enemy = new FakeCharacter();
            enemy.Position.X = enemyPosition;

            PositionService sut = new PositionService();

            bool isOnRange = sut.IsInRange(attacker, enemy);

            Assert.False(isOnRange);
        }
    }
}


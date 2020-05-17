using System;
using Moq;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using RpgCombatKata.Domain.Interfaces;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public partial class MovementsDomainServiceTests
    {
        [Theory]
        [InlineData(5, 10, 8)]
        [InlineData(5, 8, 10)]
        [InlineData(2, 3, 1)]
        public void EnemyIsOnRange_WhenEnemyDistanceIsSmallerOrEqualRange_ReturnsTrue(
            uint attackerRange, uint attackerPosition,
            uint enemyPosition)
        {
            FakeRangedCharacter attacker = new FakeRangedCharacter();
            attacker._range = attackerRange;
            attacker.Position.X = attackerPosition;

            FakeRangedCharacter enemy = new FakeRangedCharacter();
            enemy.Position.X = enemyPosition;

            MovementsDomainService sut = new MovementsDomainService();

            bool isOnRange = sut.EnemyIsOnRange(attacker, enemy);

            Assert.True(isOnRange);
        }

        [Theory]
        [InlineData(2, 0, 3)]
        [InlineData(1, 20, 18)]
        public void EnemyIsOnRange_WhenEnemyDistanceIsGreaterThanRange_ReturnsFalse(
           uint attackerRange, uint attackerPosition,
           uint enemyPosition)
        {
            FakeRangedCharacter attacker = new FakeRangedCharacter();
            attacker._range = attackerRange;
            attacker.Position.X = attackerPosition;

            FakeRangedCharacter enemy = new FakeRangedCharacter();
            enemy.Position.X = enemyPosition;

            MovementsDomainService sut = new MovementsDomainService();

            bool isOnRange = sut.EnemyIsOnRange(attacker, enemy);

            Assert.False(isOnRange);
        }
    }
}

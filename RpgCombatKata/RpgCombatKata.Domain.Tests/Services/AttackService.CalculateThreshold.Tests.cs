using System;
using Moq;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public partial class AttackServiceTests
    {
        [Fact]
        public void CalculateThresold_WhenEnemyLevelIsGreaterThan5_ReturnsHigherThreshold()
        {
            Mock<Character> attacker = new Mock<Character>();
            attacker.Setup(x => x.Level).Returns(11);

            Mock<Character> enemy = new Mock<Character>();
            enemy.Setup(x => x.Level).Returns(5);

            AttackService sut = new AttackService();

            float threshold = sut.CalculateThreshold(attacker.Object, enemy.Object);

            Assert.Equal(1.5F, threshold);
        }

        [Fact]
        public void CalculateThresold_WhenEnemyLevelIsSmallerThan5_ReturnsLowerThreshold()
        {
            Mock<Character> attacker = new Mock<Character>();
            attacker.Setup(x => x.Level).Returns(3);

            Mock<Character> enemy = new Mock<Character>();
            enemy.Setup(x => x.Level).Returns(8);

            AttackService sut = new AttackService();

            float threshold = sut.CalculateThreshold(attacker.Object, enemy.Object);

            Assert.Equal(0.5F, threshold);
        }

        [Fact]
        public void CalculateThresold_WhenEnemyLevelIsInTheRange_ReturnsNormalThreshold()
        {
            FakeCharacter attacker = new FakeCharacter();
            FakeCharacter enemy = new FakeCharacter();

            AttackService sut = new AttackService();

            float threshold = sut.CalculateThreshold(attacker, enemy);

            Assert.Equal(1F, threshold);
        }
    }
}

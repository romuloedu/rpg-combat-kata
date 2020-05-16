using System;
using Moq;
using RpgCombatKata.Domain.Entities;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public partial class MovementsDomainServiceTests
    {
        [Fact]
        public void CalculateHitThreshold_WhenEnemyLevelIsGreaterThan5_ReturnsHigherThreshold()
        {
            Mock<Character> attacker = new Mock<Character>();
            attacker.Setup(x => x.Level).Returns(11);

            Mock<Character> enemy = new Mock<Character>();
            enemy.Setup(x => x.Level).Returns(5);

            MovementsDomainService sut = new MovementsDomainService();

            float threshold = sut.CalculateHitThreshold(attacker.Object, enemy.Object);

            Assert.Equal(1.5F, threshold);
        }

        [Fact]
        public void CalculateHitThreshold_WhenEnemyLevelIsSmallerThan5_ReturnsLowerThreshold()
        {
            Mock<Character> attacker = new Mock<Character>();
            attacker.Setup(x => x.Level).Returns(3);

            Mock<Character> enemy = new Mock<Character>();
            enemy.Setup(x => x.Level).Returns(8);

            MovementsDomainService sut = new MovementsDomainService();

            float threshold = sut.CalculateHitThreshold(attacker.Object, enemy.Object);

            Assert.Equal(0.5F, threshold);
        }

        [Fact]
        public void CalculateHitThreshold_WhenEnemyLevelIsTheRange_ReturnsNormalThreshold()
        {
            Mock<Character> attacker = new Mock<Character>();
            Mock<Character> enemy = new Mock<Character>();

            MovementsDomainService sut = new MovementsDomainService();

            float threshold = sut.CalculateHitThreshold(attacker.Object, enemy.Object);

            Assert.Equal(1F, threshold);
        }
    }
}

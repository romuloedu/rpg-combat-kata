using System;
using Moq;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Interfaces;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public partial class MovementsDomainServiceTests
    {
        [Fact]
        public void CalculateHitThreshold_WhenEnemyLevelIsGreaterThan5_ReturnsHigherThreshold()
        {
            Mock<ICharacter> attacker = new Mock<ICharacter>();
            attacker.Setup(x => x.Level).Returns(11);

            Mock<ICharacter> enemy = new Mock<ICharacter>();
            enemy.Setup(x => x.Level).Returns(5);

            MovementsDomainService sut = new MovementsDomainService();

            float threshold = sut.CalculateHitThreshold(attacker.Object, enemy.Object);

            Assert.Equal(1.5F, threshold);
        }

        [Fact]
        public void CalculateHitThreshold_WhenEnemyLevelIsSmallerThan5_ReturnsLowerThreshold()
        {
            Mock<ICharacter> attacker = new Mock<ICharacter>();
            attacker.Setup(x => x.Level).Returns(3);

            Mock<ICharacter> enemy = new Mock<ICharacter>();
            enemy.Setup(x => x.Level).Returns(8);

            MovementsDomainService sut = new MovementsDomainService();

            float threshold = sut.CalculateHitThreshold(attacker.Object, enemy.Object);

            Assert.Equal(0.5F, threshold);
        }

        [Fact]
        public void CalculateHitThreshold_WhenEnemyLevelIsInTheRange_ReturnsNormalThreshold()
        {
            Mock<ICharacter> attacker = new Mock<ICharacter>();
            Mock<ICharacter> enemy = new Mock<ICharacter>();

            MovementsDomainService sut = new MovementsDomainService();

            float threshold = sut.CalculateHitThreshold(attacker.Object, enemy.Object);

            Assert.Equal(1F, threshold);
        }
    }
}

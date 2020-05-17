using System;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class ThingTests
    {
        [Theory]
        [InlineData(100F)]
        [InlineData(9999F)]
        [InlineData(123F)]
        public void Constructor_WhenInstanceIsCreated_SetsThePassedHealthPoints(
            float healthPoints)
        {
            Thing sut = new Thing(healthPoints);

            Assert.Equal(healthPoints, sut.HealthPoints);
        }

        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsIsDestroyedAsFalse()
        {
            Thing sut = new Thing(100);

            Assert.False(sut.IsDestroyed);
        }
    }
}

using System;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class ThingTests
    {
        [Fact]
        public void SetDamage_ReturnsSubtractedHealth()
        {
            Thing sut = new Thing(1000);

            sut.SetDamage(100);

            Assert.Equal(900, sut.HealthPoints);
        }

        [Fact]
        public void SetDamage_WhenDamageIsGreaterThanHealth_ReturnsHealthAs0()
        {
            Thing sut = new Thing(1000);

            sut.SetDamage(9999);

            Assert.Equal(0, sut.HealthPoints);
        }

        [Fact]
        public void SetDamage_WhenDamageIsGreaterThanHealth_ReturnsIsDestroyedAsTrue()
        {
            Thing sut = new Thing(1000);

            sut.SetDamage(1100);

            Assert.True(sut.IsDestroyed);
        }
    }
}

using System;
using RpgCombatKata.Domain.Entities;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class CharacterTests
    {
        [Fact]
        public void SetDamage_ReturnsSubtractedHealth()
        {
            Character sut = new Character();

            sut.SetDamage(100);

            Assert.Equal(900, sut.HealthPoints);
        }

        [Fact]
        public void SetDamage_WhenDamageIsGreaterThanHealth_ReturnsHealthAs0()
        {
            Character sut = new Character();

            sut.SetDamage(1100);

            Assert.Equal(0, sut.HealthPoints);
        }

        [Fact]
        public void SetDamage_WhenDamageIsGreaterThanHealth_ReturnsIsAliveAsFalse()
        {
            Character sut = new Character();

            sut.SetDamage(1100);

            Assert.False(sut.IsAlive);
        }
    }
}

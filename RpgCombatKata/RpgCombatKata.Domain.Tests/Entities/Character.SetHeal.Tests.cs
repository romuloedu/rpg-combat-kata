using System;
using RpgCombatKata.Domain.Entities;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class CharacterTests
    {
        [Fact]
        public void SetHeal_ReturnsAddedHealth()
        {
            Character sut = new Character();

            sut.SetDamage(500);
            sut.SetHeal(100);

            Assert.Equal<uint>(600, sut.HealthPoints);
        }

        [Fact]
        public void SetHeal_WhenCharacterIsDead_ReturnsHealthAs0()
        {
            Character sut = new Character();

            sut.SetDamage(1100);
            sut.SetHeal(100);

            Assert.Equal<uint>(0, sut.HealthPoints);
        }

        [Fact]
        public void SetHeal_WhenCurePointsIsGreaterThanHealthPoints_ReturnsHealthAs1000Maximum()
        {
            Character sut = new Character();

            sut.SetHeal(100);

            Assert.Equal<uint>(1000, sut.HealthPoints);
        }
    }
}

using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class CharacterTests
    {
        [Fact]
        public void SetHeal_ReturnsAddedHealth()
        {
            FakeCharacter sut = new FakeCharacter();

            sut.SetDamage(500);
            sut.SetHeal(100);

            Assert.Equal(600, sut.HealthPoints);
        }

        [Fact]
        public void SetHeal_WhenCharacterIsDead_ReturnsHealthAs0()
        {
            FakeCharacter sut = new FakeCharacter();

            sut.SetDamage(1100);
            sut.SetHeal(100);

            Assert.Equal(0, sut.HealthPoints);
        }

        [Fact]
        public void SetHeal_WhenCurePointsIsGreaterThanHealthPoints_ReturnsHealthAs1000Maximum()
        {
            FakeCharacter sut = new FakeCharacter();

            sut.SetHeal(100);

            Assert.Equal(1000, sut.HealthPoints);
        }
    }
}

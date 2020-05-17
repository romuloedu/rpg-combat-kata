using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class CharacterTests
    {
        [Fact]
        public void SetRegeneration_ReturnsAddedHealth()
        {
            FakeCharacter sut = new FakeCharacter();

            sut.SetDamage(500);
            sut.SetRegeneration(100);

            Assert.Equal(600, sut.HealthPoints);
        }

        [Fact]
        public void SetRegeneration_WhenCharacterIsDead_ReturnsHealthAs0()
        {
            FakeCharacter sut = new FakeCharacter();

            sut.SetDamage(1100);
            sut.SetRegeneration(100);

            Assert.Equal(0, sut.HealthPoints);
        }

        [Fact]
        public void SetRegeneration_WhenCurePointsIsGreaterThanHealthPoints_ReturnsHealthAs1000Maximum()
        {
            FakeCharacter sut = new FakeCharacter();

            sut.SetRegeneration(100);

            Assert.Equal(1000, sut.HealthPoints);
        }
    }
}

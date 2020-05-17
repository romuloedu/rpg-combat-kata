using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class CharacterTests
    {
        [Fact]
        public void SetDamage_ReturnsSubtractedHealth()
        {
            FakeCharacter sut = new FakeCharacter();

            sut.SetDamage(100);

            Assert.Equal(900, sut.HealthPoints);
        }

        [Fact]
        public void SetDamage_WhenDamageIsGreaterThanHealth_ReturnsHealthAs0()
        {
            FakeCharacter sut = new FakeCharacter();

            sut.SetDamage(1100);

            Assert.Equal(0, sut.HealthPoints);
        }

        [Fact]
        public void SetDamage_WhenDamageIsGreaterThanHealth_ReturnsIsAliveAsFalse()
        {
            FakeCharacter sut = new FakeCharacter();

            sut.SetDamage(1100);

            Assert.False(sut.IsAlive);
        }
    }
}

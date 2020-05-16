using System;
using RpgCombatKata.Domain.Entities;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public partial class CharacterTests
    {
        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsHealthPointsAs1000()
        {
            Character sut = new Character();

            Assert.Equal<uint>(1000, sut.HealthPoints);
        }

        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsLevelAs1()
        {
            Character sut = new Character();

            Assert.Equal<uint>(1, sut.Level);
        }

        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsIsAliveAsTrue()
        {
            Character sut = new Character();

            Assert.True(sut.IsAlive);
        }
    }
}

using System;
using RpgCombatKata.Domain.Entities;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public partial class MovementsDomainServiceTests
    {
        [Fact]
        public void Cure_WhenCureAnotherCharacter_ReturnsAddedHealth()
        {
            Character me = new Character();
            Character enemy = new Character();

            MovementsDomainService sut = new MovementsDomainService();

            sut.Attack(250, me, enemy);
            sut.Cure(100, me, enemy);

            Assert.Equal<uint>(850, enemy.HealthPoints);
        }
    }
}

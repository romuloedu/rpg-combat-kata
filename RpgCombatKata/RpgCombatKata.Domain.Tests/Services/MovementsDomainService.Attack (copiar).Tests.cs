using System;
using RpgCombatKata.Domain.Entities;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public partial class MovementsDomainServiceTests
    {
        [Fact]
        public void Attack_WhenCauseDamageToAnotherCharacter_ReturnsSubtractedHealth()
        {
            Character me = new Character();
            Character enemy = new Character();

            MovementsDomainService sut = new MovementsDomainService();

            sut.Attack(100, me, enemy);

            Assert.Equal<uint>(900, enemy.HealthPoints);
        }
    }
}

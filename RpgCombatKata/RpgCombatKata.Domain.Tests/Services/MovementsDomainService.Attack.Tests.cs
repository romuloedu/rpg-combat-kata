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

            Assert.Equal(900, enemy.HealthPoints);
        }


        [Fact]
        public void Attack_WhenAttacksHerself_ReturnsUnalteredHealth()
        {
            Character me = new Character();

            MovementsDomainService sut = new MovementsDomainService();

            sut.Attack(100, me, me);

            Assert.Equal(1000, me.HealthPoints);
        }
    }
}

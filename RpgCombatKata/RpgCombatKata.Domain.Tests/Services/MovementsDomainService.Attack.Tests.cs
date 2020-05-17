using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public partial class MovementsDomainServiceTests
    {

        [Fact]
        public void Attack_WhenCauseDamageToAnotherCharacter_ReturnsSubtractedHealth()
        {
            FakeRangedCharacter me = new FakeRangedCharacter();
            FakeRangedCharacter enemy = new FakeRangedCharacter();

            MovementsDomainService sut = new MovementsDomainService();

            sut.Attack(100, me, enemy);

            Assert.Equal(900, enemy.HealthPoints);
        }


        [Fact]
        public void Attack_WhenAttacksHerself_ReturnsUnalteredHealth()
        {
            FakeRangedCharacter me = new FakeRangedCharacter();

            MovementsDomainService sut = new MovementsDomainService();

            sut.Attack(100, me, me);

            Assert.Equal(1000, me.HealthPoints);
        }
    }
}

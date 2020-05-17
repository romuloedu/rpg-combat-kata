using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public partial class MovementsDomainServiceTests
    {
        [Fact]
        public void Heal_WhenHealsHerself_ReturnsUnalteredHealth()
        {
            FakeRangedCharacter me = new FakeRangedCharacter();

            MovementsDomainService sut = new MovementsDomainService();

            sut.Heal(100, me, me);

            Assert.Equal(1000, me.HealthPoints);
        }

        [Fact]
        public void Heal_WhenCharactersAreAllies_ReturnsAddedHealth()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);

            FakeRangedCharacter ally = new FakeRangedCharacter();
            ally.JoinFaction(faction);

            FakeRangedCharacter ally2 = new FakeRangedCharacter();
            ally2.JoinFaction(faction);

            FakeRangedCharacter enemy = new FakeRangedCharacter();
            ally2.JoinFaction(faction2);

            MovementsDomainService sut = new MovementsDomainService();

            sut.Attack(100, enemy, ally);
            sut.Heal(100, ally2, ally);

            Assert.Equal(1000, ally.HealthPoints);
        }

        [Fact]
        public void Heal_WhenCharactersArentAllies_ReturnsSubtractedHealth()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);

            FakeRangedCharacter ally = new FakeRangedCharacter();
            ally.JoinFaction(faction);

            FakeRangedCharacter enemy = new FakeRangedCharacter();
            enemy.JoinFaction(faction2);

            MovementsDomainService sut = new MovementsDomainService();

            sut.Attack(200, ally, enemy);
            sut.Heal(100, ally, enemy);

            Assert.Equal(800, enemy.HealthPoints);
        }
    }
}

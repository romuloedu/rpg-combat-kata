using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public class HealServiceTests
    {
        [Fact]
        public void Heal_WhenHealsHerself_ReturnsUnalteredHealth()
        {
            FakeCharacter me = new FakeCharacter();

            HealService sut = new HealService();

            sut.Heal(100, me, me);

            Assert.Equal(1000, me.HealthPoints);
        }

        [Fact]
        public void Heal_WhenCharactersAreAllies_ReturnsAddedHealth()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);

            FakeCharacter ally = new FakeCharacter();
            ally.SetDamage(100);
            ally.JoinFaction(faction);

            FakeCharacter ally2 = new FakeCharacter();
            ally2.JoinFaction(faction);

            HealService sut = new HealService();

            sut.Heal(100, ally2, ally);

            Assert.Equal(1000, ally.HealthPoints);
        }

        [Fact]
        public void Heal_WhenCharactersArentAllies_ReturnsSubtractedHealth()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);

            FakeCharacter ally = new FakeCharacter();
            ally.JoinFaction(faction);

            FakeCharacter enemy = new FakeCharacter();
            enemy.SetDamage(100);
            enemy.JoinFaction(faction2);

            HealService sut = new HealService();

            sut.Heal(100, ally, enemy);

            Assert.Equal(900, enemy.HealthPoints);
        }
    }
}

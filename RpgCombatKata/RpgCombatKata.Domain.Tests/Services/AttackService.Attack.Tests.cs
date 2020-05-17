using System;
using RpgCombatKata.Domain.Entities;
using RpgCombatKata.Domain.Fakes.Tests;
using Xunit;

namespace RpgCombatKata.Domain.Services.Tests
{
    public partial class AttackServiceTests
    {
        [Fact]
        public void Attack_WhenCauseDamageToAnotherCharacter_ReturnsSubtractedHealth()
        {
            FakeCharacter me = new FakeCharacter();
            FakeCharacter enemy = new FakeCharacter();

            AttackService sut = new AttackService();

            sut.Attack(100, me, enemy);

            Assert.Equal(900, enemy.HealthPoints);
        }

        [Fact]
        public void Attack_WhenAttacksHerself_ReturnsUnalteredHealth()
        {
            FakeCharacter me = new FakeCharacter();

            AttackService sut = new AttackService();

            sut.Attack(100, me, me);

            Assert.Equal(1000, me.HealthPoints);
        }

        [Fact]
        public void Attack_WhenCharactersAreAllies_ReturnsUnalteredHealth()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);
            Faction faction3 = new Faction(3);

            FakeCharacter character = new FakeCharacter();
            character.JoinFaction(faction3);

            FakeCharacter character2 = new FakeCharacter();
            character2.JoinFaction(faction);
            character2.JoinFaction(faction2);
            character2.JoinFaction(faction3);

            AttackService sut = new AttackService();

            sut.Attack(100, character, character2);

            Assert.Equal(1000, character2.HealthPoints);
        }

        [Fact]
        public void Attack_WhenCharactersArentAllies_ReturnsSubtractedHealth()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);

            FakeCharacter character = new FakeCharacter();
            character.JoinFaction(faction);

            FakeCharacter character2 = new FakeCharacter();
            character2.JoinFaction(faction2);

            AttackService sut = new AttackService();

            sut.Attack(100, character, character2);

            Assert.Equal(900, character2.HealthPoints);
        }

        [Fact]
        public void Attack_WhenCauseDamageToAThing_ReturnsSubtractedHealth()
        {
            FakeCharacter me = new FakeCharacter();
            Thing enemy = new Thing(1000);

            AttackService sut = new AttackService();

            sut.Attack(100, me, enemy);

            Assert.Equal(900, enemy.HealthPoints);
        }
    }
}

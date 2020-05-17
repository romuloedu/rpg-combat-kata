﻿using System;
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

        [Fact]
        public void Attack_WhenCharactersAreAllies_ReturnsUnalteredHealth()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);
            Faction faction3 = new Faction(3);

            FakeRangedCharacter character = new FakeRangedCharacter();
            character.JoinFaction(faction3);

            FakeRangedCharacter character2 = new FakeRangedCharacter();
            character2.JoinFaction(faction);
            character2.JoinFaction(faction2);
            character2.JoinFaction(faction3);

            MovementsDomainService sut = new MovementsDomainService();

            sut.Attack(100, character, character2);

            Assert.Equal(1000, character2.HealthPoints);
        }

        [Fact]
        public void Attack_WhenCharactersArentAllies_ReturnsSubtractedHealth()
        {
            Faction faction = new Faction(1);
            Faction faction2 = new Faction(2);

            FakeRangedCharacter character = new FakeRangedCharacter();
            character.JoinFaction(faction);

            FakeRangedCharacter character2 = new FakeRangedCharacter();
            character2.JoinFaction(faction2);

            MovementsDomainService sut = new MovementsDomainService();

            sut.Attack(100, character, character2);

            Assert.Equal(900, character2.HealthPoints);
        }
    }
}

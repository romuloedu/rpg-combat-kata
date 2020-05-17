using System;
using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public class FactionTests
    {
        [Fact]
        public void Constructor_WhenInstanceIsCreated_SetsTheIdNumber()
        {
            int id = new Random().Next();

            Faction sut = new Faction(id);

            Assert.Equal(id, sut.Id);
        }
    }
}

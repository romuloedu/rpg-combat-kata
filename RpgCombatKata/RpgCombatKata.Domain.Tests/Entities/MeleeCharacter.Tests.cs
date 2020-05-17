using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public class MeleeCharacterTests
    {
        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsRangeAs2()
        {
            MeleeCharacter sut = new MeleeCharacter();

            Assert.Equal<uint>(2, sut.MaxRange);
        }
    }
}

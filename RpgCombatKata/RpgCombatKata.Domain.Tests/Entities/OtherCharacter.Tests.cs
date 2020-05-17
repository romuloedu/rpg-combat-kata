using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public class OtherCharacterTests
    {
        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsRangeAs20()
        {
            OtherCharacter sut = new OtherCharacter();

            Assert.Equal<uint>(20, sut.MaxRange);
        }
    }
}

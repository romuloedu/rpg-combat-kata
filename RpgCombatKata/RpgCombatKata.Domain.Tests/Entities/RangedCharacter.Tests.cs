using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public class RangedCharacterTests
    {
        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsRangeAs20()
        {
            RangedCharacter sut = new RangedCharacter();

            Assert.Equal<uint>(20, sut.Range);
        }

        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsPositionAsNotNull()
        {
            RangedCharacter sut = new RangedCharacter();

            Assert.NotNull(sut.Position);
        }

        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsPositionXAs0()
        {
            RangedCharacter sut = new RangedCharacter();

            Assert.Equal<uint>(0, sut.Position.X);
        }
    }
}

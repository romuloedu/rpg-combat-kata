using Xunit;

namespace RpgCombatKata.Domain.Entities.Tests
{
    public class MeleeCharacterTests
    {
        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsRangeAs2()
        {
            MeleeCharacter sut = new MeleeCharacter();

            Assert.Equal<uint>(2, sut.Range);
        }

        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsPositionAsNotNull()
        {
            MeleeCharacter sut = new MeleeCharacter();

            Assert.NotNull(sut.Position);
        }

        [Fact]
        public void Constructor_WhenInstanceIsCreated_ReturnsPositionXAs0()
        {
            MeleeCharacter sut = new MeleeCharacter();

            Assert.Equal<uint>(0, sut.Position.X);
        }
    }
}

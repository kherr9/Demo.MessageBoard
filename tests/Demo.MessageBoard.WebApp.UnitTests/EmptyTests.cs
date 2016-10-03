using NUnit.Framework;

namespace Demo.MessageBoard.WebApp.UnitTests
{
    [TestFixture]
    public class EmptyTests
    {
        [Test]
        public void TestStringIsEmpty()
        {
            // Arrange
            var expected = string.Empty;

            // Act
            var actual = "";

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}

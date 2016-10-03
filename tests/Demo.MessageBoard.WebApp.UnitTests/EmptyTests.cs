using NUnit.Framework;

namespace Demo.MessageBoard.WebApp.UnitTests
{
    /// <summary>
    /// Example unit test
    /// </summary>
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

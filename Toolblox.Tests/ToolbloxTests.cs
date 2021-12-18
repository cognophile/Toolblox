using NUnit.Framework;
using Toolblox;

namespace Cognophile.Toolblox.Tests
{
    [TestFixture]
    public class ToolbloxTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void IsNull_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            var actual = Toolblox.Strings.IsNull(null);

            Assert.IsTrue(actual);
        }
    }
}

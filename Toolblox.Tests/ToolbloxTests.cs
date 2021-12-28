using NUnit.Framework;

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
        public void Class_WhenInstantiated_ThenInstanceOfExpectedBaseType()
        {
            Assert.IsInstanceOf<IToolblox>(new Toolblox());
        }
    }
}

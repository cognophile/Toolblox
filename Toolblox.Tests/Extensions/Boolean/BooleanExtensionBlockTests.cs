using Cognophile.Toolblox.Blocks.Extensions.Boolean;
using NUnit.Framework;

namespace Cognophile.Toolblox.Tests.Extensions.Boolean
{
    [TestFixture]
    public class BooleanExtensionBlockTests
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
        public void ToTextual_WhenArgumentTrue_ThenExpectedTypeReturned()
        {
            bool subject = true;

            var actual = subject.ToTextual();

            Assert.IsInstanceOf<string>(actual);
        }

        [Test]
        public void ToTextual_WhenArgumentTrue_ThenExpectedValueReturned()
        {
            bool subject = true;

            var actual = subject.ToTextual();

            Assert.That(actual, Is.EqualTo("Yes"));
        }

        [Test]
        public void ToTextual_WhenArgumentFalse_ThenExpectedTypeReturned()
        {
            bool subject = false;

            var actual = subject.ToTextual();

            Assert.IsInstanceOf<string>(actual);
        }

        [Test]
        public void ToTextual_WhenArgumentFalse_ThenExpectedValueReturned()
        {
            bool subject = false;

            var actual = subject.ToTextual();

            Assert.That(actual, Is.EqualTo("No"));
        }
    }
}

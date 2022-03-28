using Cognophile.Toolblox.Blocks.Base.Boolean;
using NUnit.Framework;

namespace Cognophile.Toolblox.Tests.Statics.Boolean
{
    [TestFixture]
    public class BooleanlockTests
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

            var actual = BooleanBaseBlock.ToTextual(subject);

            Assert.IsInstanceOf<string>(actual);
        }

        [Test]
        public void ToTextual_WhenArgumentTrue_ThenExpectedValueReturned()
        {
            bool subject = true;

            var actual = BooleanBaseBlock.ToTextual(subject);

            Assert.That(actual, Is.EqualTo("Yes"));
        }

        [Test]
        public void ToTextual_WhenArgumentFalse_ThenExpectedTypeReturned()
        {
            bool subject = false;

            var actual = BooleanBaseBlock.ToTextual(subject);

            Assert.IsInstanceOf<string>(actual);
        }

        [Test]
        public void ToTextual_WhenArgumentFalse_ThenExpectedValueReturned()
        {
            bool subject = false;

            var actual = BooleanBaseBlock.ToTextual(subject);

            Assert.That(actual, Is.EqualTo("No"));
        }
    }
}

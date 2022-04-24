using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Statics.Boolean;
using NUnit.Framework;

namespace Cognophile.Toolblox.Tests.Statics.Boolean
{
    [TestFixture]
    public class BooleanBlockTests
    {
        [SetUp]
        public void SetUp() { }

        [TearDown]
        public void TearDown() { }

        [Test]
        public void Class_WhenReferenced_ThenExpectedTypeImplemented()
        {
            Assert.That(new BooleanBlock(), Is.InstanceOf<IBlock>());
        }

        [Test]
        public void ToTextual_WhenArgumentTrue_ThenExpectedTypeReturned()
        {
            bool subject = true;

            var actual = BooleanBlock.ToTextual(subject);

            Assert.IsInstanceOf<string>(actual);
        }

        [Test]
        public void ToTextual_WhenArgumentTrue_ThenExpectedValueReturned()
        {
            bool subject = true;

            var actual = BooleanBlock.ToTextual(subject);

            Assert.That(actual, Is.EqualTo("Yes"));
        }

        [Test]
        public void ToTextual_WhenArgumentFalse_ThenExpectedTypeReturned()
        {
            bool subject = false;

            var actual = BooleanBlock.ToTextual(subject);

            Assert.IsInstanceOf<string>(actual);
        }

        [Test]
        public void ToTextual_WhenArgumentFalse_ThenExpectedValueReturned()
        {
            bool subject = false;

            var actual = BooleanBlock.ToTextual(subject);

            Assert.That(actual, Is.EqualTo("No"));
        }
    }
}

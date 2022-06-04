using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Statics.Boolean;
using NUnit.Framework;

namespace Cognophile.Toolblox.Tests.Statics.Boolean
{
    [TestFixture]
    public class BooleanBlockTests
    {
        private BooleanBlock _subject;

        [SetUp]
        public void SetUp()
        {
            _subject = new();
        }

        [TearDown]
        public void TearDown()
        {
            _subject = null;
        }

        [Test]
        public void Class_WhenReferenced_ThenExpectedTypeImplemented()
        {
            Assert.That(_subject, Is.InstanceOf<IBlock>());
        }

        [Test]
        public void ToTextual_WhenArgumentTrue_ThenExpectedTypeReturned()
        {
            bool subject = true;

            var actual = _subject.ToTextual(subject);

            Assert.IsInstanceOf<string>(actual);
        }

        [Test]
        public void ToTextual_WhenArgumentTrue_ThenExpectedValueReturned()
        {
            bool subject = true;

            var actual = _subject.ToTextual(subject);

            Assert.That(actual, Is.EqualTo("Yes"));
        }

        [Test]
        public void ToTextual_WhenArgumentFalse_ThenExpectedTypeReturned()
        {
            bool subject = false;

            var actual = _subject.ToTextual(subject);

            Assert.IsInstanceOf<string>(actual);
        }

        [Test]
        public void ToTextual_WhenArgumentFalse_ThenExpectedValueReturned()
        {
            bool subject = false;

            var actual = _subject.ToTextual(subject);

            Assert.That(actual, Is.EqualTo("No"));
        }

        [Test]
        public void IsFalse_WhenArgumentFalse_ThenExpectedValueReturned()
        {
            bool subject = false;

            var actual = _subject.IsFalse(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsFalse_WhenArgumentTrue_ThenExpectedValueReturned()
        {
            bool subject = true;

            var actual = _subject.IsFalse(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsTrue_WhenArgumentFalse_ThenExpectedValueReturned()
        {
            bool subject = false;

            var actual = _subject.IsTrue(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsTrue_WhenArgumentTrue_ThenExpectedValueReturned()
        {
            bool subject = true;

            var actual = _subject.IsTrue(subject);

            Assert.That(actual, Is.True);
        }
    }
}

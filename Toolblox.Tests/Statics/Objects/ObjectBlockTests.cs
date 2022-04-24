using System;
using NUnit.Framework;
using Cognophile.Toolblox.Blocks.Statics.Objects;

namespace Cognophile.Toolblox.Tests.Extensions.Objects
{
    [TestFixture]
    public class ObjectBlockTests
    {
        [SetUp]
        public void SetUp() { }

        [TearDown]
        public void TearDown() { }

        [Test]
        public void IsNull_WhenSubjectIsNull_ThenExpectedTypeReturned()
        {
            object subject = null;

            var actual = ObjectBlock.IsNull(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNull_WhenSubjectIsNull_ThenExpectedValueReturned()
        {
            object subject = null;

            var actual = ObjectBlock.IsNull(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsNull_WhenSubjectIsNotNull_ThenExpectedTypeReturned()
        {
            object subject = new { Id = 1 };

            var actual = ObjectBlock.IsNull(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNull_WhenSubjectIsNotNull_ThenExpectedValueReturned()
        {
            object subject = new { Id = 1 };

            var actual = ObjectBlock.IsNull(subject);

            Assert.That(actual, Is.False);
        }
    }
}

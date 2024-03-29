﻿using NUnit.Framework;
using Cognophile.Toolblox.Blocks.Statics.Objects;
using Cognophile.Toolblox.Tests.TestUtilities;

namespace Cognophile.Toolblox.Tests.Extensions.Objects
{
    [TestFixture]
    public class ObjectBlockTests
    {
        private ObjectBlock _subject;

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
        public void IsNull_WhenSubjectIsNull_ThenExpectedTypeReturned()
        {
            object subject = null;

            var actual = _subject.IsNull(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNull_WhenSubjectIsNull_ThenExpectedValueReturned()
        {
            object subject = null;

            var actual = _subject.IsNull(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsNull_WhenSubjectIsNotNull_ThenExpectedTypeReturned()
        {
            object subject = new { Id = 1 };

            var actual = _subject.IsNull(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNull_WhenSubjectIsNotNull_ThenExpectedValueReturned()
        {
            object subject = new { Id = 1 };

            var actual = _subject.IsNull(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsNotNull_WhenSubjectIsNull_ThenExpectedTypeReturned()
        {
            object subject = null;

            var actual = _subject.IsNotNull(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNotNull_WhenSubjectIsNull_ThenExpectedValueReturned()
        {
            object subject = null;

            var actual = _subject.IsNotNull(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsNotNull_WhenSubjectIsNotNull_ThenExpectedTypeReturned()
        {
            object subject = new { Id = 1 };

            var actual = _subject.IsNotNull(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNotNull_WhenSubjectIsNotNull_ThenExpectedValueReturned()
        {
            object subject = new { Id = 1 };

            var actual = _subject.IsNotNull(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void Clone_WhenSubjectIsNull_ThenExpectedTypeReturned()
        {
            FakeEntity subject = null;

            var actual = _subject.Clone(subject);

            Assert.That(actual, Is.Null);
        }

        [Test]
        public void Clone_WhenSubjectIsNotSerializable_ThenExpectedValueReturned()
        {
            FakeUnserializableEntity subject = new(1, "Foobar");

            var actual = _subject.Clone(subject);

            Assert.That(actual, Is.Null);
        }

        [Test]
        public void Clone_WhenSubjectIsValid_ThenExpectedTypeReturned()
        {
            FakeEntity subject = new()
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            var actual = _subject.Clone(subject);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void Clone_WhenSubjectIsValid_ThenExpectedValueReturned()
        {
            FakeEntity subject = new()
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            var actual = _subject.Clone(subject);

            Assert.That(actual.ExampleInt, Is.EqualTo(1));
            Assert.That(actual.ExampleString, Is.EqualTo("Foobar"));
        }
    }
}

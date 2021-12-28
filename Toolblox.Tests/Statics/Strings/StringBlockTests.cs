using System;
using Cognophile.Toolblox.Blocks.Statics.Strings;
using NUnit.Framework;

namespace Toolblox.Tests.Statics.Strings
{
    [TestFixture]
    public class StringBlockTests
    {
        private StringBlock _subject;

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
        public void IsNull_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            var actual = StringBlock.IsNull(null);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsEmpty_ThenBooleanFalseReturned()
        {
            var actual = StringBlock.IsNull("");

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsWhitespave_ThenBooleanFalseReturned()
        {
            var actual = StringBlock.IsNull("   ");

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsValid_ThenBooleanFalseReturned()
        {
            var actual = StringBlock.IsNull("Lorem Ipsum");

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNullOrEmpty_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            var actual = StringBlock.IsNullOrEmpty(null);

            Assert.IsTrue(actual);
        }

        public void IsNullOrEmpty_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            var actual = StringBlock.IsNullOrEmpty("");

            Assert.IsTrue(actual);
        }

        public void IsNullOrEmpty_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            var actual = StringBlock.IsNullOrEmpty("   ");

            Assert.IsTrue(actual);
        }


        public void IsNullOrEmpty_WhenArgumentIsValid_ThenBooleanFalseReturned()
        {
            var actual = StringBlock.IsNullOrEmpty("Lorem Ipsum");

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            var actual = StringBlock.IsNullOrWhitespace(null);

            Assert.IsTrue(actual);
        }

        public void IsNullOrWhitespace_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            var actual = StringBlock.IsNullOrWhitespace("");

            Assert.IsTrue(actual);
        }

        public void IsNullOrWhitespace_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            var actual = StringBlock.IsNullOrWhitespace("   ");

            Assert.IsTrue(actual);
        }

        public void IsNullOrWhitespace_WhenArgumentIsWhitespace_ThenBooleanFalseReturned()
        {
            var actual = StringBlock.IsNullOrWhitespace("Lorem Ipsum");

            Assert.IsFalse(actual);
        }
    }
}

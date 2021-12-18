﻿using NUnit.Framework;

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

        [Test]
        public void IsNull_WhenArgumentIsEmpty_ThenBooleanFalseReturned()
        {
            var actual = Toolblox.Strings.IsNull("");

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsWhitespave_ThenBooleanFalseReturned()
        {
            var actual = Toolblox.Strings.IsNull("   ");

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsValid_ThenBooleanFalseReturned()
        {
            var actual = Toolblox.Strings.IsNull("Lorem Ipsum");

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNullOrEmpty_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            var actual = Toolblox.Strings.IsNullOrEmpty(null);

            Assert.IsTrue(actual);
        }

        public void IsNullOrEmpty_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            var actual = Toolblox.Strings.IsNullOrEmpty("");

            Assert.IsTrue(actual);
        }

        public void IsNullOrEmpty_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            var actual = Toolblox.Strings.IsNullOrEmpty("   ");

            Assert.IsTrue(actual);
        }


        public void IsNullOrEmpty_WhenArgumentIsValid_ThenBooleanFalseReturned()
        {
            var actual = Toolblox.Strings.IsNullOrEmpty("Lorem Ipsum");

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            var actual = Toolblox.Strings.IsNullOrWhitespace(null);

            Assert.IsTrue(actual);
        }

        public void IsNullOrWhitespace_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            var actual = Toolblox.Strings.IsNullOrWhitespace("");

            Assert.IsTrue(actual);
        }

        public void IsNullOrWhitespace_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            var actual = Toolblox.Strings.IsNullOrWhitespace("   ");

            Assert.IsTrue(actual);
        }

        public void IsNullOrWhitespace_WhenArgumentIsWhitespace_ThenBooleanFalseReturned()
        {
            var actual = Toolblox.Strings.IsNullOrWhitespace("Lorem Ipsum");

            Assert.IsFalse(actual);
        }
    }
}

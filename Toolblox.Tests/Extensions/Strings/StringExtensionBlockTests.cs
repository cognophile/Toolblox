using Cognophile.Toolblox.Blocks.Extensions.Strings;
using NUnit.Framework;

namespace Cognophile.Toolblox.Tests.Extensions.Strings
{
    [TestFixture]
    public class StringExtensionBlockTests
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
            string subject = null;

            var actual = subject.IsNull();

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsEmpty_ThenBooleanFalseReturned()
        {
            string subject = "";

            var actual = subject.IsNull();

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsWhitespace_ThenBooleanFalseReturned()
        {
            string subject = "   ";

            var actual = subject.IsNull();

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsValid_ThenBooleanFalseReturned()
        {
            string subject = "Lorem Ipsum";

            var actual = subject.IsNull();

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNullOrEmpty_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            string subject = null;

            var actual = subject.IsNullOrEmpty();

            Assert.IsTrue(actual);
        }

        public void IsNullOrEmpty_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            string subject = "";

            var actual = subject.IsNullOrEmpty();

            Assert.IsTrue(actual);
        }

        public void IsNullOrEmpty_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            string subject = "   ";

            var actual = subject.IsNullOrEmpty();

            Assert.IsTrue(actual);
        }

        public void IsNullOrEmpty_WhenArgumentIsValid_ThenBooleanFalseReturned()
        {
            string subject = "Lorem Ipsum";

            var actual = subject.IsNullOrEmpty();

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            string subject = null;

            var actual = subject.IsNullOrWhitespace();

            Assert.IsTrue(actual);
        }

        public void IsNullOrWhitespace_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            string subject = "";

            var actual = subject.IsNullOrWhitespace();

            Assert.IsTrue(actual);
        }

        public void IsNullOrWhitespace_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            string subject = "   ";

            var actual = subject.IsNullOrWhitespace();

            Assert.IsTrue(actual);
        }

        public void IsNullOrWhitespace_WhenArgumentIsWhitespace_ThenBooleanFalseReturned()
        {
            string subject = "Lorem Ipsum";

            var actual = subject.IsNullOrWhitespace();

            Assert.IsFalse(actual);
        }
    }
}

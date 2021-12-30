using Cognophile.Toolblox.Blocks.Extensions.Strings;
using NUnit.Framework;
using System;
using System.Collections.Generic;

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
        public void IsEmpty_WhenArgumentIsNotEmpty_ThenBooleanFalseReturned()
        {
            string subject = "Foobasr";

            var actual = subject.IsEmpty();

            Assert.IsFalse(actual);
        }

                [Test]
        public void IsEmpty_WhenArgumentIsWhitespace_ThenBooleanFalseReturned()
        {
            string subject = "   ";

            var actual = subject.IsEmpty();

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsEmpty_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            string subject = "";

            var actual = subject.IsEmpty();

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsEmpty_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => subject.IsEmpty());            
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
        public void IsWhitespace_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            string subject = "   ";

            var actual = subject.IsWhitespace();

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsWhitespace_WhenArgumentIsNotWhitespace_ThenBooleanFalseReturned()
        {
            string subject = "Foobar";

            var actual = subject.IsWhitespace();

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsWhitespace_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => subject.IsWhitespace());
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            string subject = null;

            var actual = subject.IsNullOrWhitespace();

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            string subject = "";

            var actual = subject.IsNullOrWhitespace();

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            string subject = "   ";

            var actual = subject.IsNullOrWhitespace();

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsWhitespace_ThenBooleanFalseReturned()
        {
            string subject = "Lorem Ipsum";

            var actual = subject.IsNullOrWhitespace();

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsTitlecase_WhenArgumentFeaturesTitleCasing_ThenBooleanTrueReturned()
        {
            string subject = "Lorem Ipsum";

            var actual = subject.IsTitlecase();

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsTitlecase_WhenArgumentDoesNotFeatureTitleCasing_ThenBooleanFalseReturned()
        {
            string subject = "Lorem ipsum";

            var actual = subject.IsTitlecase();

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsTitlecase_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => subject.IsTitlecase());
        }

        [Test]
        public void IsTitlecase_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => subject.IsTitlecase());
        }

        [Test]
        public void IsTitlecase_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => subject.IsTitlecase());
        }

        [Test]
        public void IsCapitalised_WhenArgumentHasCapitalisation_ThenBooleanTrueReturned()
        {
            string subject = "Lorem ipsum";

            var actual = subject.IsCapitalised();

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsCapitalised_WhenArgumentHasNoCapitalisation_ThenBooleanFalseReturned()
        {
            string subject = "lorem ipsum";

            var actual = subject.IsCapitalised();

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsCapitalised_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => subject.IsCapitalised());
        }

        [Test]
        public void IsCapitalised_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => subject.IsCapitalised());
        }

        [Test]
        public void IsCapitalised_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => subject.IsCapitalised());
        }

        [Test]
        public void Matches_WhenArgumentMatchesGivenPattern_ThenBooleanTrueReturned()
        {
            string subject = "foo_bar";

            var actual = subject.Matches("([a-zA-Z]*)_([a-zA-Z]*)");

            Assert.IsTrue(actual);
        }

        [Test]
        public void Matches_WhenArgumentDoesNotMatchGivenPattern_ThenBooleanFalseReturned()
        {
            string subject = "foobar";

            var actual = subject.Matches("([a-zA-Z]*)_([a-zA-Z]*)");

            Assert.IsFalse(actual);
        }

        [Test]
        public void Matches_WhenPatternArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = "foo_bar";

            Assert.Throws<ArgumentNullException>(() => subject.Matches(null));
        }

        [Test]
        public void Matches_WhenPatternArgumentIsEmpty_ThenArgumentNullExceptionThrown()
        {
            string subject = "foo_bar";

            Assert.Throws<ArgumentException>(() => subject.Matches(""));
        }

        [Test]
        public void Matches_WhenPatternArgumentIsWhitespace_ThenArgumentNullExceptionThrown()
        {
            string subject = "foo_bar";

            Assert.Throws<ArgumentException>(() => subject.Matches("   "));
        }

        [Test]
        public void Matches_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => subject.Matches("([a-zA-Z]*)_([a-zA-Z]*)"));
        }

        [Test]
        public void Matches_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => subject.Matches("([a-zA-Z]*)_([a-zA-Z]*)"));
        }

        [Test]
        public void Matches_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => subject.Matches("([a-zA-Z]*)_([a-zA-Z]*)"));
        }

        [Test]
        public void Between_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => subject.Between("a", "b"));
        }

        [Test]
        public void Between_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => subject.Between("a", "b"));
        }

        [Test]
        public void Between_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => subject.Between("a", "b"));
        }

        [Test]
        public void Between_WhenLeftArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentNullException>(() => subject.Between(null, "b"));
        }

        [Test]
        public void Between_WhenLeftArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentException>(() => subject.Between("", "b"));
        }

        [Test]
        public void Between_WhenLeftArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentException>(() => subject.Between("   ", "b"));
        }

        [Test]
        public void Between_WhenRightArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentNullException>(() => subject.Between("a", null));
        }

        [Test]
        public void Between_WhenRightArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentException>(() => subject.Between("a", ""));
        }

        [Test]
        public void Between_WhenRightArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentException>(() => subject.Between("a", "   "));
        }

        [Test]
        public void Between_WhenSubstringExistsInSource_ThenExpectedSubstringReturned()
        {
            string subject = "Here is a first test string";

            var actual = subject.Between("is", "test");

            Assert.AreEqual("a first", actual);
        }

        [Test]
        public void Between_WhenSubstringDoesNotExistInSource_ThenNullReturned()
        {
            string subject = "Here is a second test string";

            var actual = subject.Between("is", "first");

            Assert.IsNull(actual);
        }

        [Test]
        public void Explode_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => subject.Explode(' '));
        }

        [Test]
        public void Explode_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => subject.Explode(' '));
        }

        [Test]
        public void Explode_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => subject.Explode(' '));
        }

        [Test]
        public void Explode_WhenArgumentIsValid_ThenExpectedItemCountReturned()
        {
            string subject = "this is a string";

            var actual = subject.Explode(' ');

            Assert.That(actual, Has.Count.EqualTo(4));
        }

        [Test]
        public void Explode_WhenArgumentIsValid_ThenExpectedItemValuesReturned()
        {
            string subject = "this is a string";

            var actual = subject.Explode(' ') as List<string>;

            Assert.AreEqual(0, actual.IndexOf("this"));
            Assert.AreEqual(1, actual.IndexOf("is"));
            Assert.AreEqual(2, actual.IndexOf("a"));
            Assert.AreEqual(3, actual.IndexOf("string"));
        }

        [Test]
        public void Titlecase_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => subject.Titlecase());
        }

        [Test]
        public void Titlecase_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => subject.Titlecase());
        }

        [Test]
        public void Titlecase_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => subject.Titlecase());
        }

        [Test]
        public void Titlecase_WhenStringIsAlreadyInTitlecase_ThenOriginalStringReturned()
        {
            string subject = "This Is A String";

            var actual = subject.Titlecase();

            Assert.AreEqual(subject, actual);
        }

        [Test]
        public void Titlecase_WhenStringIsNotInTitlecase_ThenMutatedStringReturned()
        {
            string subject = "this is a string";
            string expected = "This Is A String";

            var actual = subject.Titlecase();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Capitalise_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => subject.Capitalise());
        }

        [Test]
        public void Capitalise_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => subject.Capitalise());
        }

        [Test]
        public void Capitalise_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => subject.Capitalise());
        }

        [Test]
        public void Capitalise_WhenStringIsAlreadyCapitalised_ThenOriginalStringReturned()
        {
            string subject = "This is a string";

            var actual = subject.Capitalise();

            Assert.AreEqual(subject, actual);
        }

        [Test]
        public void Capitalise_WhenStringIsNotCapitalised_ThenMutatedStringReturned()
        {
            string subject = "this is a string";
            string expected = "This is a string";

            var actual = subject.Capitalise();

            Assert.AreEqual(expected, actual);
        }
    }
}

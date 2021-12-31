using System;
using System.Collections.Generic;
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
            string subject = null;

            var actual = StringBlock.IsNull(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsEmpty_ThenBooleanFalseReturned()
        {
            string subject = "";

            var actual = StringBlock.IsNull(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsWhitespace_ThenBooleanFalseReturned()
        {
            string subject = "   ";

            var actual = StringBlock.IsNull(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNull_WhenArgumentIsValid_ThenBooleanFalseReturned()
        {
            string subject = "Lorem Ipsum";

            var actual = StringBlock.IsNull(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsEmpty_WhenArgumentIsNotEmpty_ThenBooleanFalseReturned()
        {
            string subject = "Foobasr";

            var actual = StringBlock.IsEmpty(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsEmpty_WhenArgumentIsWhitespace_ThenBooleanFalseReturned()
        {
            string subject = "   ";

            var actual = StringBlock.IsEmpty(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsEmpty_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            string subject = "";

            var actual = StringBlock.IsEmpty(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsEmpty_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.IsEmpty(subject));
        }

        [Test]
        public void IsNullOrEmpty_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            string subject = null;

            var actual = StringBlock.IsNullOrEmpty(subject);

            Assert.IsTrue(actual);
        }

        public void IsNullOrEmpty_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            string subject = "";

            var actual = StringBlock.IsNullOrEmpty(subject);

            Assert.IsTrue(actual);
        }

        public void IsNullOrEmpty_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            string subject = "   ";

            var actual = StringBlock.IsNullOrEmpty(subject);

            Assert.IsTrue(actual);
        }

        public void IsNullOrEmpty_WhenArgumentIsValid_ThenBooleanFalseReturned()
        {
            string subject = "Lorem Ipsum";

            var actual = StringBlock.IsNullOrEmpty(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsWhitespace_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            string subject = "   ";

            var actual = StringBlock.IsWhitespace(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsWhitespace_WhenArgumentIsNotWhitespace_ThenBooleanFalseReturned()
        {
            string subject = "Foobar";

            var actual = StringBlock.IsWhitespace(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsWhitespace_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.IsWhitespace(subject));
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsNull_ThenBooleanTrueReturned()
        {
            string subject = null;

            var actual = StringBlock.IsNullOrWhitespace(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsEmpty_ThenBooleanTrueReturned()
        {
            string subject = "";

            var actual = StringBlock.IsNullOrWhitespace(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsWhitespace_ThenBooleanTrueReturned()
        {
            string subject = "   ";

            var actual = StringBlock.IsNullOrWhitespace(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNullOrWhitespace_WhenArgumentIsWhitespace_ThenBooleanFalseReturned()
        {
            string subject = "Lorem Ipsum";

            var actual = StringBlock.IsNullOrWhitespace(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsTitlecase_WhenArgumentFeaturesTitleCasing_ThenBooleanTrueReturned()
        {
            string subject = "Lorem Ipsum";

            var actual = StringBlock.IsTitlecase(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsTitlecase_WhenArgumentDoesNotFeatureTitleCasing_ThenBooleanFalseReturned()
        {
            string subject = "Lorem ipsum";

            var actual = StringBlock.IsTitlecase(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsTitlecase_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.IsTitlecase(subject));
        }

        [Test]
        public void IsTitlecase_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.IsTitlecase(subject));
        }

        [Test]
        public void IsTitlecase_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.IsTitlecase(subject));
        }

        [Test]
        public void IsCapitalised_WhenArgumentHasCapitalisation_ThenBooleanTrueReturned()
        {
            string subject = "Lorem ipsum";

            var actual = StringBlock.IsCapitalised(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsCapitalised_WhenArgumentHasNoCapitalisation_ThenBooleanFalseReturned()
        {
            string subject = "lorem ipsum";

            var actual = StringBlock.IsCapitalised(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsCapitalised_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.IsCapitalised(subject));
        }

        [Test]
        public void IsCapitalised_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.IsCapitalised(subject));
        }

        [Test]
        public void IsCapitalised_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.IsCapitalised(subject));
        }

        [Test]
        public void IsAlpha_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.IsAlpha(subject));
        }

        [Test]
        public void IsAlpha_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.IsAlpha(subject));
        }

        [Test]
        public void IsAlpha_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.IsAlpha(subject));
        }

        [Test]
        public void IsAlpha_WhenIsAlphaOnly_ThenBooleanTrueReturned()
        {
            string subject = "alpha";

            var actual = StringBlock.IsAlpha(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsAlpha_WhenArgumentIsNotAlphaOnly_ThenBooleanFalseReturned()
        {
            string subject = "123";

            var actual = StringBlock.IsAlpha(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNumeric_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.IsNumeric(subject));
        }

        [Test]
        public void IsNumeric_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.IsNumeric(subject));
        }

        [Test]
        public void IsNumeric_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.IsNumeric(subject));
        }

        [Test]
        public void IsNumeric_WhenIsNumericOnly_ThenBooleanTrueReturned()
        {
            string subject = "123";

            var actual = StringBlock.IsNumeric(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNumeric_WhenArgumentIsNotNumericOnly_ThenBooleanFalseReturned()
        {
            string subject = "alpha";

            var actual = StringBlock.IsNumeric(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsSymbols_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.IsSymbols(subject));
        }

        [Test]
        public void IsSymbols_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.IsSymbols(subject));
        }

        [Test]
        public void IsSymbols_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.IsSymbols(subject));
        }

        [Test]
        public void IsSymbols_WhenIsSymbolsOnly_ThenBooleanTrueReturned()
        {
            string subject = "$£!,.;";

            var actual = StringBlock.IsSymbols(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsSymbols_WhenArgumentIsNotSymbolsOnly_ThenBooleanFalseReturned()
        {
            string subject = "alpha";

            var actual = StringBlock.IsSymbols(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsNumericSymbols_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.IsNumericSymbols(subject));
        }

        [Test]
        public void IsNumericSymbols_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.IsNumericSymbols(subject));
        }

        [Test]
        public void IsNumericSymbols_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.IsNumericSymbols(subject));
        }

        [Test]
        public void IsNumericSymbols_WhenIsSymbolsOnly_ThenBooleanTrueReturned()
        {
            string subject = "$£!,.;";

            var actual = StringBlock.IsNumericSymbols(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNumericSymbols_WhenIsNumericOnly_ThenBooleanTrueReturned()
        {
            string subject = "123";

            var actual = StringBlock.IsNumericSymbols(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNumericSymbols_WhenIsNumericSymbolsOnly_ThenBooleanTrueReturned()
        {
            string subject = "£123.00";

            var actual = StringBlock.IsNumericSymbols(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsNumericSymbols_WhenArgumentIsNotNumericSymbolsOnly_ThenBooleanFalseReturned()
        {
            string subject = "alpha";

            var actual = StringBlock.IsNumericSymbols(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsAlphaNumeric_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.IsAlphaNumeric(subject));
        }

        [Test]
        public void IsAlphaNumeric_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.IsAlphaNumeric(subject));
        }

        [Test]
        public void IsAlphaNumeric_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.IsAlphaNumeric(subject));
        }

        [Test]
        public void IsAlphaNumeric_WhenIsAlphaNumeric_ThenBooleanTrueReturned()
        {
            string subject = "alpha123";

            var actual = StringBlock.IsAlphaNumeric(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsAlphaNumeric_WhenArgumentIsNumericOnly_ThenBooleanTrueReturned()
        {
            string subject = "123";

            var actual = StringBlock.IsAlphaNumeric(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsAlphaNumeric_WhenArgumentIsNotAlphaNumeric_ThenBooleanFalseReturned()
        {
            string subject = "alpha-123";

            var actual = StringBlock.IsAlphaNumeric(subject);

            Assert.IsFalse(actual);
        }

        [Test]
        public void IsAlphaNumeric_WhenArgumentIsAlphaOnly_ThenBooleanTrueReturned()
        {
            string subject = "alpha";

            var actual = StringBlock.IsAlphaNumeric(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsAlphaNumericSymbols_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.IsAlphaNumericSymbols(subject));
        }

        [Test]
        public void IsAlphaNumericSymbols_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.IsAlphaNumericSymbols(subject));
        }

        [Test]
        public void IsAlphaNumericSymbols_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.IsAlphaNumericSymbols(subject));
        }

        [Test]
        public void IsAlphaNumericSymbols_WhenIsAlphaNumeric_ThenBooleanTrueReturned()
        {
            string subject = "alpha123";

            var actual = StringBlock.IsAlphaNumericSymbols(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsAlphaNumericSymbols_WhenArgumentIsNumericSymbols_ThenBooleanTrueReturned()
        {
            string subject = "alpha£123.00";

            var actual = StringBlock.IsAlphaNumericSymbols(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsAlphaNumericSymbols_WhenArgumentIsAlphaOnly_ThenBooleanTrueReturned()
        {
            string subject = "alpha";

            var actual = StringBlock.IsAlphaNumericSymbols(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsAlphaNumericSymbols_WhenArgumentIsNumericOnly_ThenBooleanTrueReturned()
        {
            string subject = "123";

            var actual = StringBlock.IsAlphaNumericSymbols(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void IsAlphaNumericSymbols_WhenArgumentIsSymbolsOnly_ThenBooleanTrueReturned()
        {
            string subject = "£$,.";

            var actual = StringBlock.IsAlphaNumericSymbols(subject);

            Assert.IsTrue(actual);
        }

        [Test]
        public void Matches_WhenArgumentMatchesGivenPattern_ThenBooleanTrueReturned()
        {
            string subject = "foo_bar";

            var actual = StringBlock.Matches(subject, "([a-zA-Z]*)_([a-zA-Z]*)");

            Assert.IsTrue(actual);
        }

        [Test]
        public void Matches_WhenArgumentDoesNotMatchGivenPattern_ThenBooleanFalseReturned()
        {
            string subject = "123";

            var actual = StringBlock.Matches(subject, "([a-zA-Z]*)_([a-zA-Z]*)");

            Assert.IsFalse(actual);
        }

        [Test]
        public void Matches_WhenArgumentIsNotValidPattern_ThenBooleanFalseReturned()
        {
            string subject = "foo_bar";

            var actual = StringBlock.Matches(subject, "foo bar baz");

            Assert.IsFalse(actual);
        }

        [Test]
        public void Matches_WhenPatternArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = "foo_bar";

            Assert.Throws<ArgumentNullException>(() => StringBlock.Matches(subject, null));
        }

        [Test]
        public void Matches_WhenPatternArgumentIsEmpty_ThenArgumentNullExceptionThrown()
        {
            string subject = "foo_bar";

            Assert.Throws<ArgumentException>(() => StringBlock.Matches(subject, ""));
        }

        [Test]
        public void Matches_WhenPatternArgumentIsWhitespace_ThenArgumentNullExceptionThrown()
        {
            string subject = "foo_bar";

            Assert.Throws<ArgumentException>(() => StringBlock.Matches(subject, "   "));
        }

        [Test]
        public void Matches_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.Matches(subject, "([a-zA-Z]*)_([a-zA-Z]*)"));
        }

        [Test]
        public void Matches_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.Matches(subject, "([a-zA-Z]*)_([a-zA-Z]*)"));
        }

        [Test]
        public void Matches_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.Matches(subject, "([a-zA-Z]*)_([a-zA-Z]*)"));
        }

        [Test]
        public void Between_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.Between(subject, "a", "b"));
        }

        [Test]
        public void Between_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.Between(subject, "a", "b"));
        }

        [Test]
        public void Between_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.Between(subject, "a", "b"));
        }

        [Test]
        public void Between_WhenLeftArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentNullException>(() => StringBlock.Between(subject, null, "b"));
        }

        [Test]
        public void Between_WhenLeftArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentException>(() => StringBlock.Between(subject, "", "b"));
        }

        [Test]
        public void Between_WhenLeftArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentException>(() => StringBlock.Between(subject, "   ", "b"));
        }

        [Test]
        public void Between_WhenRightArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentNullException>(() => StringBlock.Between(subject, "a", null));
        }

        [Test]
        public void Between_WhenRightArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentException>(() => StringBlock.Between(subject, "a", ""));
        }

        [Test]
        public void Between_WhenRightArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "Here is a first test string";

            Assert.Throws<ArgumentException>(() => StringBlock.Between(subject, "a", "   "));
        }

        [Test]
        public void Between_WhenSubstringExistsInSource_ThenExpectedSubstringReturned()
        {
            string subject = "Here is a first test string";

            var actual = StringBlock.Between(subject, "is", "test");

            Assert.AreEqual("a first", actual);
        }

        [Test]
        public void Between_WhenSubstringDoesNotExistInSource_ThenNullReturned()
        {
            string subject = "Here is a second test string";

            var actual = StringBlock.Between(subject, "is", "first");

            Assert.IsNull(actual);
        }

        [Test]
        public void Explode_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.Explode(subject, ' '));
        }

        [Test]
        public void Explode_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.Explode(subject, ' '));
        }

        [Test]
        public void Explode_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.Explode(subject, ' '));
        }

        [Test]
        public void Explode_WhenArgumentIsValid_ThenExpectedItemCountReturned()
        {
            string subject = "this is a string";

            var actual = StringBlock.Explode(subject, ' ');

            Assert.That(actual, Has.Count.EqualTo(4));
        }

        [Test]
        public void Explode_WhenArgumentIsValid_ThenExpectedItemValuesReturned()
        {
            string subject = "this is a string";

            var actual = StringBlock.Explode(subject, ' ') as List<string>;

            Assert.AreEqual(0, actual.IndexOf("this"));
            Assert.AreEqual(1, actual.IndexOf("is"));
            Assert.AreEqual(2, actual.IndexOf("a"));
            Assert.AreEqual(3, actual.IndexOf("string"));
        }

        [Test]
        public void Implode_WhenValidSubstringsAndSeparatorProvided_ThenExpectedStringReturned()
        {
            var subject = new List<string>() { "This", "is", "my", "string" };

            var actual = StringBlock.Implode(subject, ' ');

            Assert.AreEqual("This is my string", actual);
        }

        [Test]
        public void Implode_WhenSubstringCollectionIsEmpty_ThenEmptyStringReturned()
        {
            var subject = new List<string>();

            var actual = StringBlock.Implode(subject, ' ');

            Assert.IsEmpty(actual);
        }

        [Test]
        public void Implode_WhenSubjectIsNull_ThenArgumentNullExceptionThrown()
        {
            ICollection<string> subject = null;
            
            Assert.Throws<ArgumentNullException>(() => StringBlock.Implode(subject, ' '));
        }

        [Test]
        public void Titlecase_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.Titlecase(subject));
        }

        [Test]
        public void Titlecase_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.Titlecase(subject));
        }

        [Test]
        public void Titlecase_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.Titlecase(subject));
        }

        [Test]
        public void Titlecase_WhenStringIsAlreadyInTitlecase_ThenOriginalStringReturned()
        {
            string subject = "This Is A String";

            var actual = StringBlock.Titlecase(subject);

            Assert.AreEqual(subject, actual);
        }

        [Test]
        public void Titlecase_WhenStringIsNotInTitlecase_ThenMutatedStringReturned()
        {
            string subject = "this is a string";
            string expected = "This Is A String";

            var actual = StringBlock.Titlecase(subject);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Capitalise_WhenArgumentIsNull_ThenArgumentNullExceptionThrown()
        {
            string subject = null;

            Assert.Throws<ArgumentNullException>(() => StringBlock.Capitalise(subject));
        }

        [Test]
        public void Capitalise_WhenArgumentIsEmpty_ThenArgumentExceptionThrown()
        {
            string subject = "";

            Assert.Throws<ArgumentException>(() => StringBlock.Capitalise(subject));
        }

        [Test]
        public void Capitalise_WhenArgumentIsWhitespace_ThenArgumentExceptionThrown()
        {
            string subject = "   ";

            Assert.Throws<ArgumentException>(() => StringBlock.Capitalise(subject));
        }

        [Test]
        public void Capitalise_WhenStringIsAlreadyCapitalised_ThenOriginalStringReturned()
        {
            string subject = "This is a string";

            var actual = StringBlock.Capitalise(subject);

            Assert.AreEqual(subject, actual);
        }

        [Test]
        public void Capitalise_WhenStringIsNotCapitalised_ThenMutatedStringReturned()
        {
            string subject = "this is a string";
            string expected = "This is a string";

            var actual = StringBlock.Capitalise(subject);

            Assert.AreEqual(expected, actual);
        }
    }
}

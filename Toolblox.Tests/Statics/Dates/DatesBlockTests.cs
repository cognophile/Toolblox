using System;
using Cognophile.Toolblox.Blocks.Base;
using NUnit.Framework;
using Cognophile.Toolblox.Blocks.Statics.Dates;

namespace Cognophile.Toolblox.Tests.Statics.Dates
{
    [TestFixture]
    public class DatesBlockTests
    {
        [SetUp]
        public void SetUp() { }

        [TearDown]
        public void TearDown() { }

        [Test]
        public void Class_WhenReferenced_ThenExpectedTypeImplemented()
        {
            Assert.That(new DateBlock(), Is.InstanceOf<IBlock>());
        }

        [Test]
        public void IsPast_WhenSubjectInPast_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = DateBlock.IsPast(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPast_WhenSubjectInPast_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = DateBlock.IsPast(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsPast_WhenSubjectIsCurrentDateTime_ThenExpectedValueReturned()
        {
            var subject = new DateTime();

            var actual = DateBlock.IsPast(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsPast_WhenSubjectIsFuture_ThenExpectedValueReturned()
        {
            var subject = new DateTime(3016, 05, 01);

            var actual = DateBlock.IsPast(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsToday_WhenSubjectInPast_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = DateBlock.IsToday(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsToday_WhenSubjectInPast_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = DateBlock.IsToday(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsToday_WhenSubjectIsCurrentDateTime_ThenExpectedValueReturned()
        {
            var subject = DateTime.Now;

            var actual = DateBlock.IsToday(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsToday_WhenSubjectIsFuture_ThenExpectedValueReturned()
        {
            var subject = new DateTime(3016, 05, 01);

            var actual = DateBlock.IsToday(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsFuture_WhenSubjectInPast_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = DateBlock.IsFuture(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsFuture_WhenSubjectInPast_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = DateBlock.IsFuture(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsFuture_WhenSubjectIsCurrentDateTime_ThenExpectedValueReturned()
        {
            var subject = new DateTime();

            var actual = DateBlock.IsFuture(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsFuture_WhenSubjectIsFuture_ThenExpectedValueReturned()
        {
            var subject = new DateTime(3016, 05, 01);

            var actual = DateBlock.IsFuture(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsBefore_WhenSubjectInPast_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = DateBlock.IsBefore(subject, new DateTime(2020, 03, 23));

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsBefore_WhenSubjectIsBeforeComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 02, 02);

            var actual = DateBlock.IsBefore(subject, new DateTime(2022, 02, 22));

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsBefore_WhenSubjectIsEqualToComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = DateBlock.IsBefore(subject, new DateTime(2022, 02, 22));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsBefore_WhenSubjectIsAfterComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = DateBlock.IsBefore(subject, new DateTime(2020, 02, 02));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsAfter_WhenSubjectIsBeforeComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 02, 02);

            var actual = DateBlock.IsAfter(subject, new DateTime(2022, 02, 22));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsAfter_WhenSubjectIsEqualToComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = DateBlock.IsAfter(subject, new DateTime(2022, 02, 22));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsAfter_WhenSubjectIsAfterComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = DateBlock.IsAfter(subject, new DateTime(2020, 02, 02));

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsEqual_WhenSubjectIsBeforeComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 02, 02);

            var actual = DateBlock.IsEqual(subject, new DateTime(2022, 02, 22));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsEqual_WhenSubjectIsEqualToComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = DateBlock.IsEqual(subject, new DateTime(2022, 02, 22));

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsEqual_WhenSubjectIsAfterComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = DateBlock.IsEqual(subject, new DateTime(2020, 02, 02));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void ToUnix_WhenDateTimeConvertedToUnixTime_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = DateBlock.ToUnix(subject);

            Assert.That(actual, Is.InstanceOf<long>());
        }

        [Test]
        public void ToUnix_WhenDateTimeConvertedToUnixTime_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = DateBlock.ToUnix(subject);

            Assert.That(actual, Is.EqualTo(1577883600));
        }

        [Test]
        public void FormatAs_WhenDateTimeConvertedToRequiredFormat_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = DateBlock.FormatAs(subject, "MMMM dd, yyyy HH:mm:ss");

            Assert.That(actual, Is.InstanceOf<string>());
        }

        [Test]
        public void FormatAs_WhenDateTimeConvertedViaFormatCode_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);
            var expected = new DateTime(2020, 01, 01, 13, 0, 0).ToString("g");

            var actual = DateBlock.FormatAs(subject, "g");

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FormatAs_WhenDateTimeConvertedViaCustomFormat_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = DateBlock.FormatAs(subject, "MMMM dd, yyyy HH:mm:ss");

            Assert.That(actual, Is.EqualTo("January 01, 2020 13:00:00"));
        }

        [Test]
        public void FormatAs_WhenFormatIsNull_ThenDefaultLongFormatReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);
            var expected = new DateTime(2020, 01, 01, 13, 0, 0).ToString();

            var actual = DateBlock.FormatAs(subject, null);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FormatAs_WhenFormatIsEmpty_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);
            var expected = new DateTime(2020, 01, 01, 13, 0, 0).ToString();

            var actual = DateBlock.FormatAs(subject, string.Empty);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void FormatAs_WhenFormatIsWhitespace_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);
            var expected = new DateTime(2020, 01, 01, 13, 0, 0).ToString();

            var actual = DateBlock.FormatAs(subject, "   ");

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

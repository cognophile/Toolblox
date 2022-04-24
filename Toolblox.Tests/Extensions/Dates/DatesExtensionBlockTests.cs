using System;
using NUnit.Framework;
using Cognophile.Toolblox.Blocks.Extensions.Dates;

namespace Cognophile.Toolblox.Tests.Extensions.Dates
{
    [TestFixture]
    public class DatesExtensionBlockTests
    {
        [SetUp]
        public void SetUp() { }

        [TearDown]
        public void TearDown() { }

        [Test]
        public void IsPast_WhenSubjectInPast_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = subject.IsPast();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPast_WhenSubjectInPast_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = subject.IsPast();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsPast_WhenSubjectIsCurrentDateTime_ThenExpectedValueReturned()
        {
            var subject = new DateTime();

            var actual = subject.IsPast();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsPast_WhenSubjectIsFuture_ThenExpectedValueReturned()
        {
            var subject = new DateTime(3016, 05, 01);

            var actual = subject.IsPast();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsToday_WhenSubjectInPast_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = subject.IsToday();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsToday_WhenSubjectInPast_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = subject.IsToday();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsToday_WhenSubjectIsCurrentDateTime_ThenExpectedValueReturned()
        {
            var subject = DateTime.Now;

            var actual = subject.IsToday();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsToday_WhenSubjectIsFuture_ThenExpectedValueReturned()
        {
            var subject = new DateTime(3016, 05, 01);

            var actual = subject.IsToday();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsFuture_WhenSubjectInPast_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = subject.IsFuture();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsFuture_WhenSubjectInPast_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2016, 05, 01);

            var actual = subject.IsFuture();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsFuture_WhenSubjectIsCurrentDateTime_ThenExpectedValueReturned()
        {
            var subject = new DateTime();

            var actual = subject.IsFuture();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsFuture_WhenSubjectIsFuture_ThenExpectedValueReturned()
        {
            var subject = new DateTime(3016, 05, 01);

            var actual = subject.IsFuture();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsBefore_WhenSubjectInPast_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = subject.IsBefore(new DateTime(2020, 03, 23));

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsBefore_WhenSubjectIsBeforeComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 02, 02);

            var actual = subject.IsBefore(new DateTime(2022, 02, 22));

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsBefore_WhenSubjectIsEqualToComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = subject.IsBefore(new DateTime(2022, 02, 22));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsBefore_WhenSubjectIsAfterComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = subject.IsBefore(new DateTime(2020, 02, 02));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsAfter_WhenSubjectIsBeforeComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 02, 02);

            var actual = subject.IsAfter(new DateTime(2022, 02, 22));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsAfter_WhenSubjectIsEqualToComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = subject.IsAfter(new DateTime(2022, 02, 22));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsAfter_WhenSubjectIsAfterComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = subject.IsAfter(new DateTime(2020, 02, 02));

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsEqual_WhenSubjectIsBeforeComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 02, 02);

            var actual = subject.IsEqual(new DateTime(2022, 02, 22));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsEqual_WhenSubjectIsEqualToComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = subject.IsEqual(new DateTime(2022, 02, 22));

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsEqual_WhenSubjectIsAfterComparitor_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2022, 02, 22);

            var actual = subject.IsEqual(new DateTime(2020, 02, 02));

            Assert.That(actual, Is.False);
        }

        [Test]
        public void ToUnix_WhenDateTimeConvertedToUnixTime_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = subject.ToUnix();

            Assert.That(actual, Is.InstanceOf<long>());
        }

        [Test]
        public void ToUnix_WhenDateTimeConvertedToUnixTime_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = subject.ToUnix();

            Assert.That(actual, Is.EqualTo(1577883600));
        }

        [Test]
        public void FormatAs_WhenDateTimeConvertedToRequiredFormat_ThenExpectedTypeReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = subject.FormatAs("MMMM dd, yyyy HH:mm:ss");

            Assert.That(actual, Is.InstanceOf<string>());
        }

        [Test]
        public void FormatAs_WhenDateTimeConvertedViaFormatCode_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = subject.FormatAs("g");

            Assert.That(actual, Is.EqualTo("01/01/2020 13:00"));
        }

        [Test]
        public void FormatAs_WhenDateTimeConvertedViaCustomFormat_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = subject.FormatAs("MMMM dd, yyyy HH:mm:ss");

            Assert.That(actual, Is.EqualTo("January 01, 2020 13:00:00"));
        }

        [Test]
        public void FormatAs_WhenFormatIsNull_ThenDefaultLongFormatReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = subject.FormatAs(null);

            Assert.That(actual, Is.EqualTo("01/01/2020 13:00:00"));
        }

        [Test]
        public void FormatAs_WhenFormatIsEmpty_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = subject.FormatAs(string.Empty);

            Assert.That(actual, Is.EqualTo("01/01/2020 13:00:00"));
        }

        [Test]
        public void FormatAs_WhenFormatIsWhitespace_ThenExpectedValueReturned()
        {
            var subject = new DateTime(2020, 01, 01, 13, 0, 0);

            var actual = subject.FormatAs("   ");

            Assert.That(actual, Is.EqualTo("01/01/2020 13:00:00"));
        }
    }
}

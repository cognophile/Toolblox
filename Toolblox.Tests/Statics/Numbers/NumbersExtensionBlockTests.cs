using NUnit.Framework;
using System.Globalization;
using System.Threading;
using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Statics.Numbers;

namespace Cognophile.Toolblox.Tests.Statics.Numbers
{
    [TestFixture]
    public class NumbersBlockTests
    {
        [SetUp]
        public void SetUp() { }

        [TearDown]
        public void TearDown() { }

        [Test]
        public void Class_WhenReferenced_ThenExpectedTypeImplemented()
        {
            Assert.That(new NumbersBlock(), Is.InstanceOf<IBlock>());
        }

        [Test]
        public void IsZero_WhenIntValueIsZero_ThenExpectedTypeReturned()
        {
            int subject = 0;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenIntValueIsZero_ThenExpectedValueReturned()
        {
            int subject = 0;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsZero_WhenIntValueIsNotZero_ThenExpectedTypeReturned()
        {
            int subject = 1;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenIntValueIsNotZero_ThenExpectedValueReturned()
        {
            int subject = 1;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsZero_WhenDoubleValueIsZero_ThenExpectedTypeReturned()
        {
            double subject = 0.00;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenDoubleValueIsZero_ThenExpectedValueReturned()
        {
            double subject = 0.00;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsZero_WhenDoubleValueIsNotZero_ThenExpectedTypeReturned()
        {
            double subject = 1.50;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenDoubleValueIsNotZero_ThenExpectedValueReturned()
        {
            double subject = 1.50;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsZero_WhenDecimalValueIsZero_ThenExpectedTypeReturned()
        {
            decimal subject = 0.00M;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenDecimalValueIsZero_ThenExpectedValueReturned()
        {
            decimal subject = 0.00M;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsZero_WhenDecimalValueIsNotZero_ThenExpectedTypeReturned()
        {
            decimal subject = 1.50M;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenDecimalValueIsNotZero_ThenExpectedValueReturned()
        {
            decimal subject = 1.50M;

            var actual = NumbersBlock.IsZero(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsPositive_WhenIntValueIsPositive_ThenExpectedTypeReturned()
        {
            int subject = 1;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositve_WhenIntValueIsPositive_ThenExpectedValueReturned()
        {
            int subject = 1;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsPositive_WhenIntValueIsNotPositive_ThenExpectedTypeReturned()
        {
            int subject = -1;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositive_WhenIntValueIsNotPositive_ThenExpectedValueReturned()
        {
            int subject = -1;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsPositive_WhenDoubleValueIsPositive_ThenExpectedTypeReturned()
        {
            double subject = 1.00;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositive_WhenDoubleValueIsPositive_ThenExpectedValueReturned()
        {
            double subject = 1.00;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsPositive_WhenDoubleValueIsNotIsPositive_ThenExpectedTypeReturned()
        {
            double subject = -1.00;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositive_WhenDoubleValueIsNotPositive_ThenExpectedValueReturned()
        {
            double subject = -1.00;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsPositive_WhenDecimalValueIsPositive_ThenExpectedTypeReturned()
        {
            decimal subject = 1.00M;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositive_WhenDecimalValueIsPositve_ThenExpectedValueReturned()
        {
            decimal subject = 1.00M;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsPositive_WhenDecimalValueIsNotPositive_ThenExpectedTypeReturned()
        {
            decimal subject = -1.00M;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositive_WhenDecimalValueIsNotPositive_ThenExpectedValueReturned()
        {
            decimal subject = -1.00M;

            var actual = NumbersBlock.IsPositive(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsNegative_WhenIntValueIsNegative_ThenExpectedTypeReturned()
        {
            int subject = -1;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenIntValueIsNegative_ThenExpectedValueReturned()
        {
            int subject = -1;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsNegative_WhenIntValueIsNotNegative_ThenExpectedTypeReturned()
        {
            int subject = 1;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenIntValueIsNotNegative_ThenExpectedValueReturned()
        {
            int subject = 1;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsNegative_WhenDoubleValueIsNegative_ThenExpectedTypeReturned()
        {
            double subject = -1.00;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenDoubleValueIsNegative_ThenExpectedValueReturned()
        {
            double subject = -1.00;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsNegative_WhenDoubleValueIsNotIsNegative_ThenExpectedTypeReturned()
        {
            double subject = 1.00;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenDoubleValueIsNotNegative_ThenExpectedValueReturned()
        {
            double subject = 1.00;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsNegative_WhenDecimalValueIsNegative_ThenExpectedTypeReturned()
        {
            decimal subject = -1.00M;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenDecimalValueIsNegative_ThenExpectedValueReturned()
        {
            decimal subject = -1.00M;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsNegative_WhenDecimalValueIsNotNegative_ThenExpectedTypeReturned()
        {
            decimal subject = 1.00M;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenDecimalValueIsNotNegative_ThenExpectedValueReturned()
        {
            decimal subject = 1.00M;

            var actual = NumbersBlock.IsNegative(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsLessThan_WhenIntValueIsLessThanThreshold_ThenExpectedTypeReturned()
        {
            int subject = 1;

            var actual = NumbersBlock.IsLessThan(subject, 2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenIntValueIsLessThanThreshold_ThenExpectedValueReturned()
        {
            int subject = 1;

            var actual = NumbersBlock.IsLessThan(subject, 2);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsLessThan_WhenIntValueIsNotLessThanThreshold_ThenExpectedTypeReturned()
        {
            int subject = 2;

            var actual = NumbersBlock.IsLessThan(subject, 1);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenIntValueIsNotLessThanThreshold_ThenExpectedValueReturned()
        {
            int subject = 2;

            var actual = NumbersBlock.IsLessThan(subject, 1);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsLessThan_WhenDoubleValueIsLessThanThreshold_ThenExpectedTypeReturned()
        {
            double subject = 1.00;

            var actual = NumbersBlock.IsLessThan(subject, 2.00);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenDoubleValueIsLessThanThreshold_ThenExpectedValueReturned()
        {
            double subject = 1.00;

            var actual = NumbersBlock.IsLessThan(subject, 2.00);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsLessThan_WhenDoubleValueIsNotLessThanThreshold_ThenExpectedTypeReturned()
        {
            double subject = 2.00;

            var actual = NumbersBlock.IsLessThan(subject, 1.00);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenDoubleValueIsNotLessThanThreshold_ThenExpectedValueReturned()
        {
            double subject = 2.00;

            var actual = NumbersBlock.IsLessThan(subject, 1.00);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsLessThan_WhenDecimalValueIsLessThanThreshold_ThenExpectedTypeReturned()
        {
            decimal subject = 1.00M;

            var actual = NumbersBlock.IsLessThan(subject, 2.00M);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenDecimalValueIsLessThanThreshold_ThenExpectedValueReturned()
        {
            decimal subject = 1.00M;

            var actual = NumbersBlock.IsLessThan(subject, 2.00M);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsLessThan_WhenDecimalValueIsNotLessThanThreshold_ThenExpectedTypeReturned()
        {
            decimal subject = 2.00M;

            var actual = NumbersBlock.IsLessThan(subject, 1.00M);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenDecimalValueIsNotLessThanThreshold_ThenExpectedValueReturned()
        {
            decimal subject = 2.00M;

            var actual = NumbersBlock.IsLessThan(subject, 2.00M);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsGreaterThan_WhenIntValueIsGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            int subject = 2;

            var actual = NumbersBlock.IsGreaterThan(subject, 1);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenIntValueIsGreaterThanThreshold_ThenExpectedValueReturned()
        {
            int subject = 2;

            var actual = NumbersBlock.IsGreaterThan(subject, 1);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsGreaterThan_WhenIntValueIsNotGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            int subject = 1;

            var actual = NumbersBlock.IsGreaterThan(subject, 2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenIntValueIsNotGreaterThanThreshold_ThenExpectedValueReturned()
        {
            int subject = 1;

            var actual = NumbersBlock.IsGreaterThan(subject, 2);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsGreaterThan_WhenDoubleValueIsGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            double subject = 2.00;

            var actual = NumbersBlock.IsGreaterThan(subject, 1.00);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenDoubleValueIsGreaterThanThreshold_ThenExpectedValueReturned()
        {
            double subject = 2.00;

            var actual = NumbersBlock.IsGreaterThan(subject, 1.00);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsGreaterThan_WhenDoubleValueIsNotGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            double subject = 1.00;

            var actual = NumbersBlock.IsGreaterThan(subject, 2.00);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenDoubleValueIsNotGreaterThanThreshold_ThenExpectedValueReturned()
        {
            double subject = 1.00;

            var actual = NumbersBlock.IsGreaterThan(subject, 2.00);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsGreaterThan_WhenDecimalValueIsGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            decimal subject = 2.00M;

            var actual = NumbersBlock.IsGreaterThan(subject, 1.00M);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenDecimalValueIsGreaterThanThreshold_ThenExpectedValueReturned()
        {
            decimal subject = 2.00M;

            var actual = NumbersBlock.IsGreaterThan(subject, 1.00M);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsGreaterThan_WhenDecimalValueIsNotGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            decimal subject = 1.00M;

            var actual = NumbersBlock.IsGreaterThan(subject, 2.00M);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenDecimalValueIsNotGreaterThanThreshold_ThenExpectedValueReturned()
        {
            decimal subject = 1.00M;

            var actual = NumbersBlock.IsGreaterThan(subject, 2.00M);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsDivisibleBy_WhenSubjectIsDivisible_ThenExpectedTypeReturned()
        {
            int subject = 4;

            var actual = NumbersBlock.IsDivisibleBy(subject, 2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsDivisibleBy_WhenSubjectIsDivisible_ThenExpectedValueReturned()
        {
            int subject = 4;

            var actual = NumbersBlock.IsDivisibleBy(subject, 2);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsDivisibleBy_WhenSubjectIsNotDivisible_ThenExpectedTypeReturned()
        {
            int subject = 3;

            var actual = NumbersBlock.IsDivisibleBy(subject, 2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsDivisibleBy_WhenSubjectIsNotDivisible_ThenExpectedValueReturned()
        {
            int subject = 3;

            var actual = NumbersBlock.IsDivisibleBy(subject, 2);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsMultipleOf_WhenSubjectIsMultiple_ThenExpectedTypeReturned()
        {
            int subject = 4;

            var actual = NumbersBlock.IsMultipleOf(subject, 2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsMultipleOf_WhenSubjectIsMultiple_ThenExpectedValueReturned()
        {
            int subject = 4;

            var actual = NumbersBlock.IsMultipleOf(subject, 2);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsMultipleOf_WhenSubjectIsNotMultiple_ThenExpectedTypeReturned()
        {
            int subject = 3;

            var actual = NumbersBlock.IsMultipleOf(subject, 2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsMultipleOf_WhenSubjectIsNotMultiple_ThenExpectedValueReturned()
        {
            int subject = 3;

            var actual = NumbersBlock.IsMultipleOf(subject, 2);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void AsCurrency_WhenIntGivenWithoutCultureOverride_ThenExpectedTypeReturned()
        {
            int subject = 12;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);

            var actual = NumbersBlock.AsCurrency(subject);

            Assert.That(actual, Is.InstanceOf<string>());
        }

        [Test]
        public void AsCurrency_WhenIntGivenWithoutCultureOverride_ThenExpectedValueReturned()
        {
            int subject = 12;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);

            var actual = NumbersBlock.AsCurrency(subject);

            Assert.That(actual, Is.EqualTo("£12.00"));
        }

        [Test]
        public void AsCurrency_WhenDoubleGivenWithoutCultureOverride_ThenExpectedTypeReturned()
        {
            double subject = 12.25;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);

            var actual = NumbersBlock.AsCurrency(subject);

            Assert.That(actual, Is.InstanceOf<string>());
        }

        [Test]
        public void AsCurrency_WhenDoubleGivenWithoutCultureOverride_ThenExpectedValueReturned()
        {
            double subject = 12.25;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);

            var actual = NumbersBlock.AsCurrency(subject);

            Assert.That(actual, Is.EqualTo("£12.25"));
        }

        [Test]
        public void AsCurrency_WhenDecimalGivenWithoutCultureOverride_ThenExpectedTypeReturned()
        {
            decimal subject = 12.25M;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);

            var actual = NumbersBlock.AsCurrency(subject);

            Assert.That(actual, Is.InstanceOf<string>());
        }

        [Test]
        public void AsCurrency_WhenDecimalGivenWithoutCultureOverride_ThenExpectedValueReturned()
        {
            decimal subject = 12.25M;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB", false);

            var actual = NumbersBlock.AsCurrency(subject);

            Assert.That(actual, Is.EqualTo("£12.25"));
        }

        [Test]
        public void AsCurrency_WhenIntGivenWithCultureOverride_ThenExpectedTypeReturned()
        {
            int subject = 12;

            var actual = NumbersBlock.AsCurrency(subject, "en-GB");

            Assert.That(actual, Is.InstanceOf<string>());
        }

        [Test]
        public void AsCurrency_WhenIntGivenWithCultureOverride_ThenExpectedValueReturned()
        {
            int subject = 12;

            var actual = NumbersBlock.AsCurrency(subject, "en-GB");

            Assert.That(actual, Is.EqualTo("£12.00"));
        }

        [Test]
        public void AsCurrency_WhenDoubleGivenWithCultureOverride_ThenExpectedTypeReturned()
        {
            double subject = 12.25;

            var actual = NumbersBlock.AsCurrency(subject, "en-GB");

            Assert.That(actual, Is.InstanceOf<string>());
        }

        [Test]
        public void AsCurrency_WhenDoubleGivenWithCultureOverride_ThenExpectedValueReturned()
        {
            double subject = 12.25;

            var actual = NumbersBlock.AsCurrency(subject, "en-GB");

            Assert.That(actual, Is.EqualTo("£12.25"));
        }

        [Test]
        public void AsCurrency_WhenDecimalGivenWithCultureOverride_ThenExpectedTypeReturned()
        {
            decimal subject = 12.25M;

            var actual = NumbersBlock.AsCurrency(subject, "en-GB");

            Assert.That(actual, Is.InstanceOf<string>());
        }

        [Test]
        public void AsCurrency_WhenDecimalGivenWithCultureOverride_ThenExpectedValueReturned()
        {
            decimal subject = 12.25M;

            var actual = NumbersBlock.AsCurrency(subject, "en-GB");

            Assert.That(actual, Is.EqualTo("£12.25"));
        }
    }
}

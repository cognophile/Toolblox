using NUnit.Framework;
using Cognophile.Toolblox.Blocks.Extensions.Numbers;

namespace Cognophile.Toolblox.Tests.Extensions.Numbers
{
    [TestFixture]
    public class NumbersExtensionBlockTests
    {
        [SetUp]
        public void SetUp() { }

        [TearDown]
        public void TearDown() { }

        [Test]
        public void IsZero_WhenIntValueIsZero_ThenExpectedTypeReturned()
        {
            int subject = 0;

            var actual = subject.IsZero();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenIntValueIsZero_ThenExpectedValueReturned()
        {
            int subject = 0;

            var actual = subject.IsZero();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsZero_WhenIntValueIsNotZero_ThenExpectedTypeReturned()
        {
            int subject = 1;

            var actual = subject.IsZero();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenIntValueIsNotZero_ThenExpectedValueReturned()
        {
            int subject = 1;

            var actual = subject.IsZero();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsZero_WhenDoubleValueIsZero_ThenExpectedTypeReturned()
        {
            double subject = 0.00;

            var actual = subject.IsZero();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenDoubleValueIsZero_ThenExpectedValueReturned()
        {
            double subject = 0.00;

            var actual = subject.IsZero();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsZero_WhenDoubleValueIsNotZero_ThenExpectedTypeReturned()
        {
            double subject = 1.50;

            var actual = subject.IsZero();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenDoubleValueIsNotZero_ThenExpectedValueReturned()
        {
            double subject = 1.50;

            var actual = subject.IsZero();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsZero_WhenDecimalValueIsZero_ThenExpectedTypeReturned()
        {
            decimal subject = 0.00M;

            var actual = subject.IsZero();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenDecimalValueIsZero_ThenExpectedValueReturned()
        {
            decimal subject = 0.00M;

            var actual = subject.IsZero();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsZero_WhenDecimalValueIsNotZero_ThenExpectedTypeReturned()
        {
            decimal subject = 1.50M;

            var actual = subject.IsZero();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsZero_WhenDecimalValueIsNotZero_ThenExpectedValueReturned()
        {
            decimal subject = 1.50M;

            var actual = subject.IsZero();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsPositive_WhenIntValueIsPositive_ThenExpectedTypeReturned()
        {
            int subject = 1;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositve_WhenIntValueIsPositive_ThenExpectedValueReturned()
        {
            int subject = 1;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsPositive_WhenIntValueIsNotPositive_ThenExpectedTypeReturned()
        {
            int subject = -1;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositive_WhenIntValueIsNotPositive_ThenExpectedValueReturned()
        {
            int subject = -1;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsPositive_WhenDoubleValueIsPositive_ThenExpectedTypeReturned()
        {
            double subject = 1.00;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositive_WhenDoubleValueIsPositive_ThenExpectedValueReturned()
        {
            double subject = 1.00;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsPositive_WhenDoubleValueIsNotIsPositive_ThenExpectedTypeReturned()
        {
            double subject = -1.00;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositive_WhenDoubleValueIsNotPositive_ThenExpectedValueReturned()
        {
            double subject = -1.00;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsPositive_WhenDecimalValueIsPositive_ThenExpectedTypeReturned()
        {
            decimal subject = 1.00M;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositive_WhenDecimalValueIsPositve_ThenExpectedValueReturned()
        {
            decimal subject = 1.00M;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsPositive_WhenDecimalValueIsNotPositive_ThenExpectedTypeReturned()
        {
            decimal subject = -1.00M;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsPositive_WhenDecimalValueIsNotPositive_ThenExpectedValueReturned()
        {
            decimal subject = -1.00M;

            var actual = subject.IsPositive();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsNegative_WhenIntValueIsNegative_ThenExpectedTypeReturned()
        {
            int subject = -1;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenIntValueIsNegative_ThenExpectedValueReturned()
        {
            int subject = -1;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsNegative_WhenIntValueIsNotNegative_ThenExpectedTypeReturned()
        {
            int subject = 1;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenIntValueIsNotNegative_ThenExpectedValueReturned()
        {
            int subject = 1;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsNegative_WhenDoubleValueIsNegative_ThenExpectedTypeReturned()
        {
            double subject = -1.00;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenDoubleValueIsNegative_ThenExpectedValueReturned()
        {
            double subject = -1.00;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsNegative_WhenDoubleValueIsNotIsNegative_ThenExpectedTypeReturned()
        {
            double subject = 1.00;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenDoubleValueIsNotNegative_ThenExpectedValueReturned()
        {
            double subject = 1.00;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsNegative_WhenDecimalValueIsNegative_ThenExpectedTypeReturned()
        {
            decimal subject = -1.00M;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenDecimalValueIsNegative_ThenExpectedValueReturned()
        {
            decimal subject = -1.00M;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsNegative_WhenDecimalValueIsNotNegative_ThenExpectedTypeReturned()
        {
            decimal subject = 1.00M;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsNegative_WhenDecimalValueIsNotNegative_ThenExpectedValueReturned()
        {
            decimal subject = 1.00M;

            var actual = subject.IsNegative();

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsLessThan_WhenIntValueIsLessThanThreshold_ThenExpectedTypeReturned()
        {
            int subject = 1;

            var actual = subject.IsLessThan(2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenIntValueIsLessThanThreshold_ThenExpectedValueReturned()
        {
            int subject = 1;

            var actual = subject.IsLessThan(2);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsLessThan_WhenIntValueIsNotLessThanThreshold_ThenExpectedTypeReturned()
        {
            int subject = 2;

            var actual = subject.IsLessThan(1);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenIntValueIsNotLessThanThreshold_ThenExpectedValueReturned()
        {
            int subject = 2;

            var actual = subject.IsLessThan(1);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsLessThan_WhenDoubleValueIsLessThanThreshold_ThenExpectedTypeReturned()
        {
            double subject = 1.00;

            var actual = subject.IsLessThan(2.00);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenDoubleValueIsLessThanThreshold_ThenExpectedValueReturned()
        {
            double subject = 1.00;

            var actual = subject.IsLessThan(2.00);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsLessThan_WhenDoubleValueIsNotLessThanThreshold_ThenExpectedTypeReturned()
        {
            double subject = 2.00;

            var actual = subject.IsLessThan(1.00);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenDoubleValueIsNotLessThanThreshold_ThenExpectedValueReturned()
        {
            double subject = 2.00;

            var actual = subject.IsLessThan(1.00);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsLessThan_WhenDecimalValueIsLessThanThreshold_ThenExpectedTypeReturned()
        {
            decimal subject = 1.00M;

            var actual = subject.IsLessThan(2.00M);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenDecimalValueIsLessThanThreshold_ThenExpectedValueReturned()
        {
            decimal subject = 1.00M;

            var actual = subject.IsLessThan(2.00M);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsLessThan_WhenDecimalValueIsNotLessThanThreshold_ThenExpectedTypeReturned()
        {
            decimal subject = 2.00M;

            var actual = subject.IsLessThan(1.00M);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsLessThan_WhenDecimalValueIsNotLessThanThreshold_ThenExpectedValueReturned()
        {
            decimal subject = 2.00M;

            var actual = subject.IsLessThan(2.00M);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsGreaterThan_WhenIntValueIsGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            int subject = 2;

            var actual = subject.IsGreaterThan(1);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenIntValueIsGreaterThanThreshold_ThenExpectedValueReturned()
        {
            int subject = 2;

            var actual = subject.IsGreaterThan(1);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsGreaterThan_WhenIntValueIsNotGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            int subject = 1;

            var actual = subject.IsGreaterThan(2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenIntValueIsNotGreaterThanThreshold_ThenExpectedValueReturned()
        {
            int subject = 1;

            var actual = subject.IsGreaterThan(2);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsGreaterThan_WhenDoubleValueIsGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            double subject = 2.00;

            var actual = subject.IsGreaterThan(1.00);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenDoubleValueIsGreaterThanThreshold_ThenExpectedValueReturned()
        {
            double subject = 2.00;

            var actual = subject.IsGreaterThan(1.00);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsGreaterThan_WhenDoubleValueIsNotGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            double subject = 1.00;

            var actual = subject.IsGreaterThan(2.00);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenDoubleValueIsNotGreaterThanThreshold_ThenExpectedValueReturned()
        {
            double subject = 1.00;

            var actual = subject.IsGreaterThan(2.00);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsGreaterThan_WhenDecimalValueIsGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            decimal subject = 2.00M;

            var actual = subject.IsGreaterThan(1.00M);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenDecimalValueIsGreaterThanThreshold_ThenExpectedValueReturned()
        {
            decimal subject = 2.00M;

            var actual = subject.IsGreaterThan(1.00M);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsGreaterThan_WhenDecimalValueIsNotGreaterThanThreshold_ThenExpectedTypeReturned()
        {
            decimal subject = 1.00M;

            var actual = subject.IsGreaterThan(2.00M);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsGreaterThan_WhenDecimalValueIsNotGreaterThanThreshold_ThenExpectedValueReturned()
        {
            decimal subject = 1.00M;

            var actual = subject.IsGreaterThan(2.00M);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsDivisibleBy_WhenSubjectIsDivisible_ThenExpectedTypeReturned()
        {
            int subject = 4;

            var actual = subject.IsDivisibleBy(2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsDivisibleBy_WhenSubjectIsDivisible_ThenExpectedValueReturned()
        {
            int subject = 4;

            var actual = subject.IsDivisibleBy(2);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsDivisibleBy_WhenSubjectIsNotDivisible_ThenExpectedTypeReturned()
        {
            int subject = 3;

            var actual = subject.IsDivisibleBy(2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsDivisibleBy_WhenSubjectIsNotDivisible_ThenExpectedValueReturned()
        {
            int subject = 3;

            var actual = subject.IsDivisibleBy(2);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsMultipleOf_WhenSubjectIsMultiple_ThenExpectedTypeReturned()
        {
            int subject = 4;

            var actual = subject.IsMultipleOf(2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsMultipleOf_WhenSubjectIsMultiple_ThenExpectedValueReturned()
        {
            int subject = 4;

            var actual = subject.IsMultipleOf(2);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsMultipleOf_WhenSubjectIsNotMultiple_ThenExpectedTypeReturned()
        {
            int subject = 3;

            var actual = subject.IsMultipleOf(2);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsMultipleOf_WhenSubjectIsNotMultiple_ThenExpectedValueReturned()
        {
            int subject = 3;

            var actual = subject.IsMultipleOf(2);

            Assert.That(actual, Is.False);
        }

        [Test]
        [Ignore("To be completed")]
        public void ParseAs_When_Then()
        {

        }

        [Test]
        [Ignore("To be completed")]
        public void AsCurrency_WhenInt_Then()
        {

        }

        [Test]
        [Ignore("To be completed")]
        public void AsCurrency_WhenDouble_Then()
        {

        }

        [Test]
        [Ignore("To be completed")]
        public void AsCurrency_WhenDecimal_Then()
        {

        }
    }
}

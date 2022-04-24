using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Cognophile.Toolblox.Blocks.Base;
using Cognophile.Toolblox.Blocks.Statics.Collections;
using Cognophile.Toolblox.Tests.TestUtilities;

namespace Cognophile.Toolblox.Tests.Statics.Collections
{
    [TestFixture]
    public class CollectionsBlockTests
    {
        [SetUp]
        public void SetUp() { }

        [TearDown]
        public void TearDown() { }

        [Test]
        public void Class_WhenReferenced_ThenExpectedTypeImplemented()
        {
            Assert.That(new CollectionsBlock(), Is.InstanceOf<IBlock>());
        }

        [Test]
        public void IsEmpty_WhenSourceIsEmpty_ThenExpectedTypeReturned()
        {
            var subject = new List<int>();

            var actual = CollectionsBlock.IsEmpty(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsEmpty_WhenSourceIsEmpty_ThenExpecteValueReturned()
        {
            var subject = new List<int>();

            var actual = CollectionsBlock.IsEmpty(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void GetByPropertyMin_WhenSourceIsEmpty_ThenExpectedExceptionThrown()
        {
            var subject = new List<FakeEntity>
            {
                Fixtures.GetEntityFixture(123, "foo")
            };

            var actual = CollectionsBlock.GetByPropertyMin(subject, p => p.ExampleInt);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void GetByPropertyMin_WhenSinglePropertyValueFound_ThenExpectedLowestValueReturned()
        {
            var subject = new List<FakeEntity>
            {
                Fixtures.GetEntityFixture(123, "foo")
            };

            var actual = CollectionsBlock.GetByPropertyMin(subject, p => p.ExampleInt);

            Assert.That(actual.ExampleInt, Is.EqualTo(123));
        }

        [Test]
        public void GetByPropertyMin_WhenMultiplePropertyValueFound_ThenExpectedExceptionThrown()
        {
            var subject = new List<FakeEntity>
            {
                Fixtures.GetEntityFixture(123, "foo"),
                Fixtures.GetEntityFixture(456, "bar"),
                Fixtures.GetEntityFixture(789, "gop")
            };

            var actual = CollectionsBlock.GetByPropertyMin(subject, p => p.ExampleInt);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void GetByPropertyMin_WhenMultiplePropertyValueFound_ThenExpectedLowestValueReturned()
        {
            var subject = new List<FakeEntity>
            {
                Fixtures.GetEntityFixture(123, "foo"),
                Fixtures.GetEntityFixture(456, "bar"),
                Fixtures.GetEntityFixture(789, "gop")
            };

            var actual = CollectionsBlock.GetByPropertyMin(subject, p => p.ExampleInt);

            Assert.That(actual.ExampleInt, Is.EqualTo(123));
        }

        [Test]
        public void GetByPropertyMax_WhenSourceIsEmpty_ThenExpectedExceptionThrown()
        {
            var subject = new List<FakeEntity>
            {
                Fixtures.GetEntityFixture(123, "foo")
            };

            var actual = CollectionsBlock.GetByPropertyMax(subject, p => p.ExampleInt);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void GetByPropertyMax_WhenSinglePropertyValueFound_ThenExpectedGreatestValueReturned()
        {
            var subject = new List<FakeEntity>
            {
                Fixtures.GetEntityFixture(123, "foo")
            };

            var actual = CollectionsBlock.GetByPropertyMax(subject, p => p.ExampleInt);

            Assert.That(actual.ExampleInt, Is.EqualTo(123));
        }

        [Test]
        public void GetByPropertyMax_WhenMultiplePropertyValueFound_ThenExpectedExceptionThrown()
        {
            var subject = new List<FakeEntity>
            {
                Fixtures.GetEntityFixture(123, "foo"),
                Fixtures.GetEntityFixture(456, "bar"),
                Fixtures.GetEntityFixture(789, "gop")
            };

            var actual = CollectionsBlock.GetByPropertyMax(subject, p => p.ExampleInt);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void GetByPropertyMax_WhenMultiplePropertyValueFound_ThenExpectedGreatestValueReturned()
        {
            var subject = new List<FakeEntity>
            {
                Fixtures.GetEntityFixture(123, "foo"),
                Fixtures.GetEntityFixture(456, "bar"),
                Fixtures.GetEntityFixture(789, "gop")
            };

            var actual = CollectionsBlock.GetByPropertyMax(subject, p => p.ExampleInt);

            Assert.That(actual.ExampleInt, Is.EqualTo(789));
        }

        [Test]
        public void PartitionBy_WhenCollectionIsEmpty_ThenExpectedTypeReturned()
        {
            var subject = new List<int>();

            var actual = CollectionsBlock.PartitionBy(subject, p => p > 2);

            Assert.That(actual, Is.InstanceOf<IEnumerable<IEnumerable<int>>>());
        }

        [Test]
        public void PartitionBy_WhenCollectionIsEmpty_ThenExpectedValueReturned()
        {
            var subject = new List<int>();

            var actual = CollectionsBlock.PartitionBy(subject, p => p > 2);

            Assert.That(actual, Is.Not.Empty);
        }

        [Test]
        public void PartitionBy_WhenCollectionIsEmpty_ThenExpectedContainedValuesAreEmpty()
        {
            var subject = new List<int>();

            var actual = CollectionsBlock.PartitionBy(subject, p => p > 2);

            Assert.IsTrue(actual.All(e => CollectionsBlock.IsEmpty(e)));
        }

        [Test]
        public void PartitionBy_WhenCollectionIsNotEmpty_ThenExpectedTypeReturned()
        {
            var subject = new List<int>();

            var actual = CollectionsBlock.PartitionBy(subject, p => p > 2);

            Assert.That(actual, Is.InstanceOf<IEnumerable<IEnumerable<int>>>());
        }

        [Test]
        public void PartitionBy_WhenCollectionIsPopulated_ThenExpectedContainedValuesAreNotEmpty()
        {
            var subject = new List<int>() { 1, 2, 3, 4 };

            var actual = CollectionsBlock.PartitionBy(subject, p => p > 2);

            Assert.IsTrue(!actual.All(e => CollectionsBlock.IsEmpty(e)));
        }

        [Test]
        public void PartitionBy_WhenContentsPartitioned_ThenFirstPartitionHasExpectedValues()
        {
            var subject = new List<int>() { 1, 2, 3, 4 };

            var actual = CollectionsBlock.PartitionBy(subject, p => p > 2);

            Assert.IsTrue(actual.First().All(i => i > 2));
        }

        [Test]
        public void PartitionBy_WhenContentsPartitioned_ThenSecondPartitionHasExpectedValues()
        {
            var subject = new List<int>() { 1, 2, 3, 4 };

            var actual = CollectionsBlock.PartitionBy(subject, p => p > 2);

            Assert.IsTrue(actual.Last().All(i => i <= 2));
        }
    }
}

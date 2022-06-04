using NUnit.Framework;
using Cognophile.Toolblox.Blocks.Base;

namespace Cognophile.Toolblox.Tests
{
    [TestFixture]
    public class ToolbloxTests
    {
        private Toolblox _subject;

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
        public void Class_WhenInstantiated_ThenInstanceOfExpectedBaseType()
        {
            Assert.IsInstanceOf<IToolblox>(_subject);
        }

        [Test]
        public void Class_WhenStringPropertyReferenced_ThenInstanceOfExpectedBaseType()
        {
            Assert.IsInstanceOf<IBlock>(_subject.StringBlock);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedStringsBlockProperty()
        {
            Assert.That(_subject, Has.Property("StringBlock"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedStringsProperty()
        {
            var property = _subject.GetType().GetProperty("Strings");
            
            Assert.IsNotNull(property);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedStringPropertyType()
        {
            var property = _subject.GetType().GetProperty("Strings");

            Assert.AreEqual(property.PropertyType.Name, "StringBlock");
        }

        [Test]
        public void Class_WhenBooleanPropertyReferenced_ThenInstanceOfExpectedBaseType()
        {
            Assert.IsInstanceOf<IBlock>(_subject.BooleanBlock);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedBooleanBlockProperty()
        {
            Assert.That(_subject, Has.Property("BooleanBlock"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedBooleanProperty()
        {
            var property = _subject.GetType().GetProperty("Booleans");

            Assert.IsNotNull(property);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedBooleanPropertyType()
        {
            var property = _subject.GetType().GetProperty("Booleans");

            Assert.AreEqual(property.PropertyType.Name, "BooleanBlock");
        }

        [Test]
        public void Class_WhenCollectionsPropertyReferenced_ThenInstanceOfExpectedBaseType()
        {
            Assert.IsInstanceOf<IBlock>(_subject.CollectionBlock);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedCollectionBlockProperty()
        {
            Assert.That(_subject, Has.Property("CollectionBlock"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedCollectionsProperty()
        {
            var property = _subject.GetType().GetProperty("Collections");

            Assert.IsNotNull(property);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedCollectionsPropertyType()
        {
            var property = _subject.GetType().GetProperty("Collections");

            Assert.AreEqual(property.PropertyType.Name, "CollectionsBlock");
        }

        [Test]
        public void Class_WhenDatesPropertyReferenced_ThenInstanceOfExpectedBaseType()
        {
            Assert.IsInstanceOf<IBlock>(_subject.DateBlock);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedDateBlockProperty()
        {
            Assert.That(_subject, Has.Property("DateBlock"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedDatesProperty()
        {
            var property = _subject.GetType().GetProperty("Dates");

            Assert.IsNotNull(property);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedDatesPropertyType()
        {
            var property = _subject.GetType().GetProperty("Dates");

            Assert.AreEqual(property.PropertyType.Name, "DateBlock");
        }

        [Test]
        public void Class_WhenJsonPropertyReferenced_ThenInstanceOfExpectedBaseType()
        {
            Assert.IsInstanceOf<IBlock>(_subject.JsonBlock);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedJsonBlockProperty()
        {
            Assert.That(_subject, Has.Property("JsonBlock"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedJsonProperty()
        {
            var property = _subject.GetType().GetProperty("Json");

            Assert.IsNotNull(property);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedJsonPropertyType()
        {
            var property = _subject.GetType().GetProperty("Json");

            Assert.AreEqual(property.PropertyType.Name, "JsonBlock");
        }

        [Test]
        public void Class_WhenNumbersPropertyReferenced_ThenInstanceOfExpectedBaseType()
        {
            Assert.IsInstanceOf<IBlock>(_subject.NumberBlock);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedNumberBlockProperty()
        {
            Assert.That(_subject, Has.Property("NumberBlock"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedNumbersProperty()
        {
            var property = _subject.GetType().GetProperty("Numbers");

            Assert.IsNotNull(property);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedNumbersPropertyType()
        {
            var property = _subject.GetType().GetProperty("Numbers");

            Assert.AreEqual(property.PropertyType.Name, "NumbersBlock");
        }

        [Test]
        public void Class_WhenObjectsPropertyReferenced_ThenInstanceOfExpectedBaseType()
        {
            Assert.IsInstanceOf<IBlock>(_subject.ObjectBlock);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedObjectBlockProperty()
        {
            Assert.That(_subject, Has.Property("ObjectBlock"));
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedObjectsProperty()
        {
            var property = _subject.GetType().GetProperty("Objects");

            Assert.IsNotNull(property);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedObjectsPropertyType()
        {
            var property = _subject.GetType().GetProperty("Objects");

            Assert.AreEqual(property.PropertyType.Name, "ObjectBlock");
        }
    }
}

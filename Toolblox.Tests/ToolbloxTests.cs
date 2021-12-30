using Cognophile.Toolblox.Blocks.Statics.Strings;
using NUnit.Framework;

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
        public void Class_WhenInstantiated_ThenInstanceHasExpectedProperty()
        {
            var property = _subject.GetType().GetProperty("Strings");
            
            Assert.IsNotNull(property);
        }

        [Test]
        public void Class_WhenInstantiated_ThenInstanceHasExpectedPropertyType()
        {
            var property = _subject.GetType().GetProperty("Strings");

            Assert.AreEqual(property.PropertyType.Name, "StringBlock");
        }
    }
}

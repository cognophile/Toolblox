using NUnit.Framework;
using Cognophile.Toolblox.Blocks.Statics.Json;
using Cognophile.Toolblox.Tests.TestUtilities;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using Cognophile.Toolblox.Blocks.Base;

namespace Cognophile.Toolblox.Tests.Statics.Json
{
    [TestFixture]
    public class JsonBlockTests
    {
        private JsonBlock _subject;

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
        public void Class_WhenReferenced_ThenExpectedTypeImplemented()
        {
            Assert.That(_subject, Is.InstanceOf<IBlock>());
        }

        [Test]
        public void IsParsable_WhenJsonIsNull_ThenExpectedTypeReturned()
        {
            string subject = null;

            var actual = _subject.IsParsable(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsParsable_WhenJsonIsNull_ThenExpectedValueReturned()
        {
            string subject = null;

            var actual = _subject.IsParsable(subject);

            Assert.That(actual, Is.False);
        }


        [Test]
        public void IsParsable_WhenJsonIsEmpty_ThenExpectedTypeReturned()
        {
            string subject = string.Empty;

            var actual = _subject.IsParsable(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsParsable_WhenJsonIsEmpty_ThenExpectedValueReturned()
        {
            string subject = string.Empty;

            var actual = _subject.IsParsable(subject);

            Assert.That(actual, Is.False);
        }

        [Test]
        public void IsParsable_WhenJsonIsWhitespace_ThenExpectedTypeReturned()
        {
            string subject = "   ";

            var actual = _subject.IsParsable(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsParsable_WhenJsonIsWhitespace_ThenExpectedValueReturned()
        {
            string subject = "   ";

            var actual = _subject.IsParsable(subject);

            Assert.That(actual, Is.False);
        }


        [Test]
        public void IsParsable_WhenJsonIsParseable_ThenExpectedTypeReturned()
        {
            string subject = @"{ ""exampleInt"": 1, ""exampleString"": ""Foobar"" }";

            var actual = _subject.IsParsable(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsParsable_WhenJsonIsParseable_ThenExpectedValueReturned()
        {
            string subject = @"{ ""exampleInt"": 1, ""exampleString"": ""Foobar"" }";

            var actual = _subject.IsParsable(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsParsable_WhenJsonNotParseable_ThenExpectedTypeReturned()
        {
            string subject = @"{ ""exampleInt"": 1, ""exampleString"": ""Foobar"" }";

            var actual = _subject.IsParsable(subject);

            Assert.That(actual, Is.InstanceOf<bool>());
        }

        [Test]
        public void IsParsable_WhenJsonNotParseable_ThenExpectedValueReturned()
        {
            string subject = @"{ ""exampleInt"": 1, ""exampleString"": ""Foobar"" }";

            var actual = _subject.IsParsable(subject);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void Serialize_WhenSerilizaingWithPascalCase_ThenExpectedTypeReturned()
        {
            var subject = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            var actual = _subject.Serialize(subject);

            Assert.That(actual, Is.InstanceOf<string>());
        }

        [Test]
        public void Serialize_WhenSerilizaingWithPascalCase_ThenExpectedValueReturned()
        {
            var expected = @"{""ExampleInt"":1,""ExampleString"":""Foobar""}";
            var subject = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            string actual = _subject.Serialize(subject);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Serialize_WhenSerilizaingWithPascalCase_ThenValidJsonReturned()
        {
            var subject = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            string actual = _subject.Serialize(subject);

            Assert.True(_subject.IsParsable(actual));
        }

        [Test]
        public void Serialize_WhenSerilizaingWithCamelCase_ThenExpectedTypeReturned()
        {
            var subject = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            var actual = _subject.Serialize(subject, false);

            Assert.That(actual, Is.InstanceOf<string>());
        }

        [Test]
        public void Serialize_WhenSerilizaingWithCamelCase_ThenExpectedValueReturned()
        {
            var expected = @"{""exampleInt"":1,""exampleString"":""Foobar""}";
            var subject = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            string actual = _subject.Serialize(subject, false);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Serialize_WhenSerilizaingWithCamelCase_ThenValidJsonReturned()
        {
            bool valid = false;
            var subject = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            string actual = _subject.Serialize(subject, false);

            try
            {
                JObject obj = JObject.Parse(actual);
                valid = true;
            }
            catch (Exception) { }

            Assert.True(valid);
        }

        [Test]
        public void Deserialize_WhenDeserilizaingValidJsonAsCaseInsensitive_ThenExpectedTypeReturned()
        {
            var subject = @"{""exampleInt"":1,""exampleString"":""Foobar""}";

            var actual = _subject.Deserialize<FakeEntity>(subject);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void Deserialize_WhenDeserilizaingValidJsonAsCaseInsensitive_ThenExpectedValueReturned()
        {
            var subject = @"{ ""exampleInt"": 1, ""exampleString"": ""Foobar""}";
            var expected = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            var actual = _subject.Deserialize<FakeEntity>(subject);

            Assert.That(actual.ExampleInt, Is.EqualTo(expected.ExampleInt));
            Assert.That(actual.ExampleString, Is.EqualTo(expected.ExampleString));
        }

        [Test]
        public void Deserialize_WhenDeserilizaingValidJsonAsCaseSensitiveAndCasingCorrect_ThenExpectedTypeReturned()
        {
            var subject = @"{""ExampleInt"":1,""ExampleString"":""Foobar""}";

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void Deserialize_WhenDeserilizaingValidJsonAsCaseSensitiveAndCasingCorrect_ThenExpectedValueReturned()
        {
            var subject = @"{ ""ExampleInt"": 1, ""ExampleString"": ""Foobar""}";
            var expected = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual.ExampleInt, Is.EqualTo(expected.ExampleInt));
            Assert.That(actual.ExampleString, Is.EqualTo(expected.ExampleString));
        }

        [Test]
        public void Deserialize_WhenDeserilizaingValidJsonAsCaseSensitiveAndCasingIncorrect_ThenExpectedTypeReturned()
        {
            var subject = @"{""exampleInt"":1,""exampleString"":""Foobar""}";

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void Deserialize_WhenDeserilizaingValidJsonAsCaseSensitiveAndCasingIncorrect_ThenExpectedValueReturned()
        {
            var subject = @"{ ""exampleInt"": 1, ""exampleString"": ""Foobar""}";

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual.ExampleInt, Is.EqualTo(0));
            Assert.That(actual.ExampleString, Is.Null);
        }

        [Test]
        public void Deserialize_WhenDeserilizaingInvalidJsonAsCaseInsensitive_ThenExpectedTypeReturned()
        {
            var subject = @"{""exampleInt"":1 ""exampleString"":""Foobar""}";

            var actual = _subject.Deserialize<FakeEntity>(subject);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void Deserialize_WhenDeserilizaingInvalidJsonAsCaseInsensitive_ThenExpectedValueReturned()
        {
            var subject = @"{""exampleInt"":1 ""exampleString"":""Foobar""}";

            var actual = _subject.Deserialize<FakeEntity>(subject);

            Assert.That(actual.ExampleInt, Is.EqualTo(0));
            Assert.That(actual.ExampleString, Is.Null);
        }

        [Test]
        public void Deserialize_WhenDeserilizaingInvalidJsonAsCaseSensitive_ThenExpectedTypeReturned()
        {
            var subject = @"{""exampleInt"":1 ""exampleString"":""Foobar""}";

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void Deserialize_WhenDeserilizaingInvalidJsonAsCaseSensitive_ThenExpectedValueReturned()
        {
            var subject = @"{""exampleInt"":1 ""exampleString"":""Foobar""}";

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual.ExampleInt, Is.EqualTo(0));
            Assert.That(actual.ExampleString, Is.Null);
        }

        public void Deserialize_WhenDeserilizaingJsonElementAsCaseSensitive_ThenExpectedTypeReturned()
        {
            var subject = @"{""exampleInt"":1 ""exampleString"":""Foobar""}";

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void Deserialize_WhenDeserilizaingJsonElementAsCaseInsensitive_ThenExpectedVTypeReturned()
        {
            var json = @"{ ""exampleInt"": 1, ""exampleString"": ""Foobar"" }";
            using JsonDocument document = JsonDocument.Parse(json);
            JsonElement subject = document.RootElement;
            var expected = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            var actual = _subject.Deserialize<FakeEntity>(subject);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void Deserialize_WhenDeserilizaingJsonElementAsCaseInsensitive_ThenExpectedValueReturned()
        {
            var json = @"{ ""exampleInt"": 1, ""exampleString"": ""Foobar"" }";
            using JsonDocument document = JsonDocument.Parse(json);
            JsonElement subject = document.RootElement;
            var expected = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            var actual = _subject.Deserialize<FakeEntity>(subject);

            Assert.That(actual.ExampleInt, Is.EqualTo(expected.ExampleInt));
            Assert.That(actual.ExampleString, Is.EqualTo(expected.ExampleString));
        }

        [Test]
        public void Deserialize_WhenDeserilizaingJsonElementAsCaseSensitiveWithIncorrectCase_ThenExpectedVTypeReturned()
        {
            var json = @"{ ""exampleInt"": 1, ""exampleString"": ""Foobar"" }";
            using JsonDocument document = JsonDocument.Parse(json);
            JsonElement subject = document.RootElement;

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void Deserialize_WhenDeserilizaingJsonElementAsCaseSensitiveWithIncorrectCase_ThenExpectedValueReturned()
        {
            var json = @"{ ""exampleInt"": 1, ""exampleString"": ""Foobar"" }";
            using JsonDocument document = JsonDocument.Parse(json);
            JsonElement subject = document.RootElement;

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual.ExampleInt, Is.EqualTo(0));
            Assert.That(actual.ExampleString, Is.Null);
        }

        [Test]
        public void Deserialize_WhenDeserilizaingJsonElementAsCaseSensitiveWithCorrectCase_ThenExpectedVTypeReturned()
        {
            var json = @"{ ""ExampleInt"": 1, ""ExampleString"": ""Foobar"" }";
            using JsonDocument document = JsonDocument.Parse(json);
            JsonElement subject = document.RootElement;
            var expected = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual, Is.InstanceOf<FakeEntity>());
        }

        [Test]
        public void Deserialize_WhenDeserilizaingJsonElementAsCaseSensitiveWithCorrectCase_ThenExpectedValueReturned()
        {
            var json = @"{ ""ExampleInt"": 1, ""ExampleString"": ""Foobar"" }";
            using JsonDocument document = JsonDocument.Parse(json);
            JsonElement subject = document.RootElement;
            var expected = new FakeEntity
            {
                ExampleInt = 1,
                ExampleString = "Foobar"
            };

            var actual = _subject.Deserialize<FakeEntity>(subject, false);

            Assert.That(actual.ExampleInt, Is.EqualTo(expected.ExampleInt));
            Assert.That(actual.ExampleString, Is.EqualTo(expected.ExampleString));
        }
    }
}

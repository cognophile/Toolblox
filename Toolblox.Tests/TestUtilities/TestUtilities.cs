using System;
namespace Cognophile.Toolblox.Tests.TestUtilities
{
    internal static class Fixtures
    {
        public static FakeEntity GetEntityFixture(int intValue, string stringValue)
        {
            return new FakeEntity
            {
                ExampleInt = intValue,
                ExampleString = stringValue
            };
        }
    }

    internal class FakeEntity
    {
        public int ExampleInt { get; set; }
        public string ExampleString { get; set; }

        public FakeEntity() { }
    }

    internal class FakeUnserializableEntity
    {
        public int ExampleInt { get; set; }
        public string ExampleString { get; set; }

        public FakeUnserializableEntity(int exampleInt) { ExampleInt = exampleInt; }
        public FakeUnserializableEntity(string exampleString) { ExampleString = exampleString; }
        public FakeUnserializableEntity(int exampleInt, string exampleString) { ExampleInt = exampleInt; ExampleString = exampleString; }
    }
}

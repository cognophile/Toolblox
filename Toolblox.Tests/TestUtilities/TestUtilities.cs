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
}

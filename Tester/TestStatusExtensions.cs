using System;

using CSStarter.TestUtils;

namespace CSStarter.Tester
{
    internal static class TestStatusExtensions
    {
        public static ConsoleColor GetConsoleColor(this TestStatus testStatus) => testStatus switch {
            TestStatus.Success => ConsoleColor.Green,
            TestStatus.Failure => ConsoleColor.Red,
            _ => throw new ArgumentOutOfRangeException(nameof(testStatus)),
        };
    }
}

using System;

namespace CSStarter.Tester
{
    public sealed class Program
    {
        public static void Main()
        {
            string[] testedAssemblies =
            {
                $"{nameof(CSStarter)}.{nameof(DB)}",
                $"{nameof(CSStarter)}.{nameof(DataOps)}",
            };
            using var app = new Application(testedAssemblies);
            app.Run();
            Environment.ExitCode = app.ExitCode;
        }
    }
}

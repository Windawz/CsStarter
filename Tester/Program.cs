using System;

namespace CsStarter.Tester
{
    public sealed class Program
    {
        public static void Main()
        {
            string[] testedAssemblies =
            {
                $"{nameof(CsStarter)}.{nameof(DB)}",
                $"{nameof(CsStarter)}.{nameof(DataOps)}",
            };
            using var app = new Application(testedAssemblies);
            app.Run();
            Environment.ExitCode = app.ExitCode;
        }
    }
}

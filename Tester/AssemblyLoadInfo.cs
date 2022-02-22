using System;
using System.Reflection;

namespace CSStarter.Tester
{
    internal sealed record AssemblyLoadInfo(AssemblyName Name, Assembly? LoadedAssembly);
}

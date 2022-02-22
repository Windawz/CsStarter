using System;
using System.Reflection;

namespace CsStarter.Tester
{
    internal sealed record AssemblyLoadInfo(AssemblyName Name, Assembly? LoadedAssembly);
}

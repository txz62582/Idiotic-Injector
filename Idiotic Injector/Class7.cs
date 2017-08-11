using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class7
{
    internal static Module module_0;

    static Class7()
    {
        Class8.Wc1jetPzTbITr();
        module_0 = typeof(Class7).Assembly.ManifestModule;
    }

    public Class7()
    {
        Class8.Wc1jetPzTbITr();
    }

    internal static void JQ9jetPPvx58g(int typemdt)
    {
        Type type = module_0.ResolveType(0x2000000 + typemdt);
        foreach (FieldInfo info in type.GetFields())
        {
            MethodInfo method = (MethodInfo) module_0.ResolveMethod(info.MetadataToken + 0x6000000);
            info.SetValue(null, (MulticastDelegate) Delegate.CreateDelegate(type, method));
        }
    }

    internal delegate void Delegate0(object o);
}


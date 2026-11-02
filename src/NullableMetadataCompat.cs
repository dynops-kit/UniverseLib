// The generated IL2CPP reference assemblies omit the nullable metadata helper
// attributes present in ordinary .NET reference packs. Keep nullable annotations
// available while compiling UniverseLib against those generated references.
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct |
        System.AttributeTargets.Interface | System.AttributeTargets.Delegate |
        System.AttributeTargets.Method | System.AttributeTargets.Property |
        System.AttributeTargets.Field | System.AttributeTargets.Parameter |
        System.AttributeTargets.ReturnValue | System.AttributeTargets.GenericParameter |
        System.AttributeTargets.Module | System.AttributeTargets.Assembly,
        Inherited = false)]
    internal sealed class NullableAttribute : System.Attribute
    {
        public NullableAttribute(byte flag) { }
        public NullableAttribute(byte[] flags) { }
    }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct |
        System.AttributeTargets.Interface | System.AttributeTargets.Delegate |
        System.AttributeTargets.Method | System.AttributeTargets.Property |
        System.AttributeTargets.Module | System.AttributeTargets.Assembly,
        Inherited = false)]
    internal sealed class NullableContextAttribute : System.Attribute
    {
        public NullableContextAttribute(byte flag) { }
    }
}

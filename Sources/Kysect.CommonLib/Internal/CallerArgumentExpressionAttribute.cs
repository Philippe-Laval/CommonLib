#pragma warning disable IDE0130
// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices;
#pragma warning restore IDE0130

/* not need fro ?net core 8.0+
 * 
[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
internal sealed class CallerArgumentExpressionAttribute : Attribute
{
    public CallerArgumentExpressionAttribute(string parameterName)
    {
        ParameterName = parameterName;
    }

    public string ParameterName { get; }
}
*/
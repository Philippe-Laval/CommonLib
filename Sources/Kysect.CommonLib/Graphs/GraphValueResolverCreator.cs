namespace Kysect.CommonLib.Graphs;

public static class GraphValueResolverCreator
{
    public static GraphValueResolver<TKey, T> Create<TKey, T>(IReadOnlyCollection<T> values, Func<T, TKey> selector)
        where TKey : notnull
    {
        return new GraphValueResolver<TKey, T>(values, selector);
    }
}
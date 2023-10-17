namespace Astrana.Core.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TType> OrEmptyIfNull<TType>(this IEnumerable<TType>? enumerable)
        {
            return enumerable ?? Enumerable.Empty<TType>();
        }
    }
}

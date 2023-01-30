namespace Astrana.Core.Utilities
{
    public static class VersionUtility
    {
        public static Version GetVersion(Type assemblyClassType)
        {
            return assemblyClassType.Assembly.GetName().Version!;
        }

        public static Version GetVersion<TClassType>()
        {
            return GetVersion(typeof(TClassType));
        }
    }
}

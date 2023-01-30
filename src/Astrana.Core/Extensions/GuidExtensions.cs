namespace Astrana.Core.Extensions
{
    public static class GuidExtensions
    {
        public static bool IsEmpty(this Guid guid)
        {
            return guid == Guid.Empty;
        }

        public static bool IsNotEmpty(this Guid guid)
        {
            return !guid.IsEmpty();
        }

        public static bool IsValidForUpdateOrDelete(this Guid guid)
        {
            return guid.IsNotEmpty();
        }
    }
}

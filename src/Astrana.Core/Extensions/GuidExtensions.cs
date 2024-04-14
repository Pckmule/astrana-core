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

        public static List<Guid> AsList(this Guid guid)
        {
            return new List<Guid> { guid };
        }

        public static List<Guid> AsList(this Guid? guid)
        {
            return guid.HasValue ? guid.Value.AsList() : new List<Guid>();
        }
    }
}

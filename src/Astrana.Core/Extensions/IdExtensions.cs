namespace Astrana.Core.Extensions
{
    public static class IdExtensions
    {
        public static Guid UseSystemUserIdIfUserIsAnonymous(this Guid actioningUserId)
        {
            return actioningUserId == Constants.AnonymousUser.IdGuid ? Constants.SystemUser.IdGuid : actioningUserId;
        }

    }
}

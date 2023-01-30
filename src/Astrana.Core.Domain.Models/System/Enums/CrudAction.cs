namespace Astrana.Core.Domain.Models.System.Enums
{
    public enum CrudAction
    {
        None = 0,
        Read = 1,

        Create = 2,
        Add = Create,

        Update = 3,
        Modify = Update,

        Delete = 4,
        Remove = Delete
    }
}

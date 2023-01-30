namespace Astrana.Core.Domain.Models.System.Contracts
{
    public interface IEditableEntity<TEntityId> where TEntityId : struct
    {
        TEntityId Id { get; set; }
    }
}

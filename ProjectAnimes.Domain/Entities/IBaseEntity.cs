namespace ProjectAnimes.Domain.Entities
{
    public interface IBaseEntity
    {
        Guid Id { get; }
        DateTime CreatedDate { get; set; }
        IReadOnlyCollection<string> Errors { get; }
        DateTime UpdatedDate { get; set; }
        bool ValidateAllFields();
        bool ValidateSingleField(string name);
    }
}
namespace ProjectAnimes.Models.Entities
{
    public class UsersEntity : BaseEntity
    {
        public string Name { get; private set; } = default!;

        public string Email { get; private set; } = default!;

        public string Password { get; private set; } = default!;

        public DateTime DateOfBirth { get; private set; } = default!;

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}

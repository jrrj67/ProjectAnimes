namespace ProjectAnimes.Models.Entities.Users
{
    public class UsersEntity : BaseEntity
    {
        public string Name { get; private set; } = default!;

        public string Email { get; private set; } = default!;

        public string Password { get; private set; } = default!;

        public DateTime DateOfBirth { get; private set; } = default!;

        public UsersEntity(string name, string email, string password, DateTime dateOfBirth)
        {
            Name = name;
            Email = email;
            Password = password;
            DateOfBirth = dateOfBirth;
            Validate();
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}

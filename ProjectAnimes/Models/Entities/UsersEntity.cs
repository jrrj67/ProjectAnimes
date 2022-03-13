namespace ProjectAnimes.Models.Entities
{
    public class UsersEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string Password { get; set; } = default!;

        public DateTime DateOfBirth { get; set; } = default!;
    }
}

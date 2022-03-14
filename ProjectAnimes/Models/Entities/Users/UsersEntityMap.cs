using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectAnimes.Models.Entities.Users
{
    public class UsersEntityMap : IEntityTypeConfiguration<UsersEntity>
    {
        public void Configure(EntityTypeBuilder<UsersEntity> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            // TODO
        }
    }
}

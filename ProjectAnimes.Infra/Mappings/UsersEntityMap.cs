using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectAnimes.Domain.Entities.Users;

namespace ProjectAnimes.Infra.Mappings
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

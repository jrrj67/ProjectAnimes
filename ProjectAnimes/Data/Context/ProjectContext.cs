using Microsoft.EntityFrameworkCore;
using ProjectAnimes.Models.Entities;

namespace ProjectAnimes.Data.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<UsersEntity> UsersEntity => Set<UsersEntity>();
    }
}

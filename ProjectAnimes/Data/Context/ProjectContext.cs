using Microsoft.EntityFrameworkCore;
using ProjectAnimes.Models.Entities;
using ProjectAnimes.Models.Entities.Users;

namespace ProjectAnimes.Data.Context
{
    public class ProjectContext : DbContext
    {
        private const string _conn = "connectionString";

        private readonly string _connectionString = _conn;

        public DbSet<UsersEntity> UsersEntity => Set<UsersEntity>();

        public ProjectContext()
        {
        }

        public ProjectContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (_connectionString == _conn)
                {
                    // Local database connection
                    optionsBuilder.UseSqlServer("Server=localhost,1433;Database=project_animes_db;MultipleActiveResultSets=true;User ID=SA;Password=Pass@word");
                }
                else
                {
                    optionsBuilder.UseSqlServer(_connectionString);
                }
            }
            else
            {
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersEntityMap());
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            SetCreatedDateAndUpdatedDate();

            return base.SaveChanges();
        }

        private void SetCreatedDateAndUpdatedDate()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                        e.State == EntityState.Added
                        || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }
        }
    }
}

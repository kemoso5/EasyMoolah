using EasyMoolah.Contracts.Domain;
using EasyMoolah.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyMoolah.Repository
{
    public class EasyMoolahContext : DbContext
    {
        private readonly string _connectionString;

        public virtual DbSet<Merchant> Merchants { get; set; }

        public EasyMoolahContext(DbContextOptions contextOptions, ISettings settings)
        {
            _connectionString = settings.ApplicationSettings.ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
        }
    }
}

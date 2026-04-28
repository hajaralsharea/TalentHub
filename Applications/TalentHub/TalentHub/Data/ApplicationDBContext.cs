using Employment.Domain.Entities;
using Employment.Infra.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace TalentHub.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.AddModlBuilderConfigurations();

        }
    }
}


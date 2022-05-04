using Microsoft.EntityFrameworkCore;
using Relationaldatabase.Data.Models;

namespace Relationaldatabase.Data
{
    public class RelationaldatabaseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Relationaldatabase;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Module>()
                .HasIndex(m => m.Name)
                .IsUnique();
        }

        public DbSet<Project> Project { get; set; }

        public DbSet<Contractor> Contractors { get; set; }

        public DbSet<Module> Modules { get; set; }

        public DbSet<Stage> Stages { get; set; }
    }
}

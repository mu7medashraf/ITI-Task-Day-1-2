using Microsoft.EntityFrameworkCore;
using Task_EF_day3.Models;

namespace Task_EF_day3.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext() { }

        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Default: LocalDB. Replace SERVER_NAME if you want another server.
                optionsBuilder.UseSqlServer("Server=MUHAMEDASHRAF;Database=University_CodeFirst;Trusted_Connection=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            { 
                entity.HasKey(e => e.StudentId);
                entity.Property(e => e.FullName).HasMaxLength(200).IsRequired();
                entity.Property(e => e.Email).HasMaxLength(200);
            });
        }
    }
}


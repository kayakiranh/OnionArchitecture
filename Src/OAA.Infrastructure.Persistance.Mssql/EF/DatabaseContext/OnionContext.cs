using Microsoft.EntityFrameworkCore;
using OAA.Domain.Entities;

namespace OAA.Infrastructure.Persistance.Mssql.EF.DatabaseContext
{
    public class OnionContext : DbContext
    {
        public OnionContext()
        {

        }

        public OnionContext(DbContextOptions<OnionContext> options) : base(options) { }

        DbSet<Student> Students { get; set; }
        DbSet<School> Schools { get; set; }
        DbSet<Education> Educations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Database=OnionDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
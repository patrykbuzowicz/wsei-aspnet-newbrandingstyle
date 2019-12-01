using Microsoft.EntityFrameworkCore;
using NewBrandingStyle.Web.Entities;

namespace NewBrandingStyle.Web.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CompanyEntity> Companies { get; set; }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyEntity>()
                .Property(x => x.Name)
                .HasMaxLength(100);
            base.OnModelCreating(modelBuilder);
        }
    }
}

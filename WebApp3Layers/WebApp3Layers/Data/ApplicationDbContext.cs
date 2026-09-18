using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp3Layers.Data.Entities;

namespace WebApp3Layers.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Biography> Biographics { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Author>()
                .HasOne(a => a.Biography)
                .WithOne(b => b.Author)
                .HasForeignKey<Biography>(b => b.AuthorId);
            builder.Entity<Company>()
                .HasMany(c => c.Employees)
                .WithOne(e => e.Company)
                .HasForeignKey(e => e.CompanyId);
            base.OnModelCreating(builder);
        }
    }
}

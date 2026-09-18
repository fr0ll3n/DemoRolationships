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
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookCategory> BooksCategories { get; set; }
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
            builder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });
            builder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BooksCategories)
                .HasForeignKey(bc => bc.BookId);
            builder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);

            base.OnModelCreating(builder);
        }
    }
}

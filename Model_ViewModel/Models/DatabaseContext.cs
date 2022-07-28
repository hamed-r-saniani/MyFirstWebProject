using Microsoft.EntityFrameworkCore;

namespace Model_ViewModel.Models
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(DbContextOptions options)
            : base(options)
        {}
        public DbSet<Category> Category { get; set; }
        public DbSet<Degree> Degree { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<ProductFeatures> ProductFeatures { get; set; }
        public DbSet<ProductImages> ProductImages { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(x => x.ProductID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Person>().Property(x => x.PersonID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Category>().Property(x => x.CategoryID).ValueGeneratedOnAdd();

            modelBuilder.Entity<Category>().HasMany(x => x.Product).WithOne(y => y.Category).HasForeignKey(p => p.ProductCategoryID);
            modelBuilder.Entity<Person>().HasMany(x => x.Product).WithOne(o => o.Person).HasForeignKey(p => p.PersonID);
            modelBuilder.Entity<Product>().HasMany(x => x.ProductImages).WithOne(o => o.Product).HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<Product>().HasMany(x => x.ProductFeatures).WithOne(o => o.Product).HasForeignKey(p => p.ProductId);
            modelBuilder.Entity<Product>().HasOne(x => x.Category).WithMany(p => p.Product).HasForeignKey(o => o.ProductID);
            modelBuilder.Entity<Product>().HasOne(x => x.Person).WithMany(o => o.Product).HasForeignKey(p => p.ProductID);
            modelBuilder.Entity<ProductFeatures>().HasOne(x => x.Product).WithMany(p => p.ProductFeatures);
            modelBuilder.Entity<ProductImages>().HasOne(x => x.Product).WithMany(p => p.ProductImages);
        }
    }
}

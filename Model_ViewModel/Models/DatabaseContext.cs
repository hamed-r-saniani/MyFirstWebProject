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
        }
    }
}

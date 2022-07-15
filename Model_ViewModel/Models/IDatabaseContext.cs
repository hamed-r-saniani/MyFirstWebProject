using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Model_ViewModel.Models
{
    public interface IDatabaseContext
    {
         DbSet<Category> Category { get; set; }
         DbSet<Degree> Degree { get; set; }
         DbSet<Product> Product { get; set; }
         DbSet<Person> Person { get; set; }
         DbSet<ProductFeatures> ProductFeatures { get; set; }
         DbSet<ProductImages> ProductImages { get; set; }
        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FishingStore.Models
{
    public class FishingDbContext : DbContext
    {
        public FishingDbContext(DbContextOptions<FishingDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}

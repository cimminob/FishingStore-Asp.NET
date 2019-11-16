using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingStore.Models
{
    public class EntityProductRepository : IProductRepository
    {
        private FishingDbContext context;

        public EntityProductRepository(FishingDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingStore.Models
{
   public class FakeProductRepository : IProductRepository
   {
      public IQueryable<Product> Products => new List<Product>
      {
         new Product {Name = "Surf Rod", Price=125},
         new Product {Name = "Casting Rod", Price=179},
         new Product {Name = "Reel" , Price=95}
      }.AsQueryable<Product>();
   }
}

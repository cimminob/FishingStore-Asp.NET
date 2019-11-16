using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingStore.Models
{
   public interface IProductRepository
   {
        //returns a sequence of employess that can be queried with LINQ
        IQueryable<Product> Products { get; }
   }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishingStore.Models;
using FishingStore.Models.ViewModels;

namespace FishingStore.Infrastructure
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        
        public string CurrentCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace FishingStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            FishingDbContext context = app.ApplicationServices.GetRequiredService<FishingDbContext>();
            context.Database.Migrate();

            //if there are no products in database
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    { Name="Penn Big Reel", Description="heavy reel for big fish", 
                      Category="Reels", Price=210},
                    new Product { Name="Penn Battlerig", Description="super heavy reel for huge fish", 
                      Category="Reels", Price=300},
                    new Product {
                      Name = "Matzuo 4000", Description = "light reel for big fish", 
                      Category = "Reels", Price = 150},   
                    new Product {Name="Abu Garcia Maxx", Description="bait caster reel for bass", 
                      Category="Reels", Price=120},
                    new Product {Name="Tsunami", Description="surf Rod for striped bass", 
                        Category="Rods", Price=220},
                    new Product {Name="Salt Striker", Description="Trolling Rod for deep water", 
                        Category="Rods", Price=200},
                    new Product {Name="Trout master", Description="Spinning rod for trout", 
                        Category="Rods", Price=70},
                    new Product {Name="Green Frog", Description="rubber lure for bass", 
                        Category="Lures", Price=6},
                    new Product {Name="Shad", Description="shad immitation lure", 
                        Category="Lures", Price=8},
                    new Product {Name="Spinner Assortment", Description="spinning lures for trout", 
                        Category="Lures", Price=10},
                    new Product {Name="Diamond Jig", Description="metal 3 oz lure for salt water", 
                        Category="Lures", Price=8},
                    new Product {Name="Yazumi", Description="rubber lures for bass", 
                        Category="Lures", Price=7},
                    new Product {Name="White Tail", Description="attracts pan fish", 
                        Category="Lures", Price=3}
                    );
                context.SaveChanges();
            }
        }
    }
}

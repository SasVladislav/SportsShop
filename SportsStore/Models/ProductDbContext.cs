using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SportsStore.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext() : base("SportsStore")
        {
            Database.SetInitializer<ProductDbContext>(new ProductDbInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
    }


}
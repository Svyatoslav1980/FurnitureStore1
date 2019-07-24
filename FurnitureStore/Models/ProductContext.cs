using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FurnitureStore.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Promo> Promoes { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
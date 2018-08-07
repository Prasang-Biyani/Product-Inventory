using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace MvcInventory.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
    }

    public class ProductDBContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ProductDBContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }

}
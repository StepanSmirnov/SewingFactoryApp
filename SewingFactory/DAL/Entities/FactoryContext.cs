using System.Data.Entity;

namespace SawingFactory.Entities
{
    public class FactoryContext : DbContext
    {
        public FactoryContext():base("DBConnection")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedProducts> OrderedProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsFurniture> ProductsFurnitures { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<FurnitureStock> FurnitureStocks { get; set; }
        public DbSet<MaterialRoll> MaterialRolls { get; set; }
        public DbSet<PruducedProduct> PruducedProducts { get; set; }
        public DbSet<ProductsHistory> ProductsHistories { get; set; }
        public DbSet<ProductsFurnitureHisotry> ProductsFurnitureHisotries { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().Ha<ProductsFurniture>(p => p.Furnitures).WithMany(f => f.Product).Map
        }
    }
}

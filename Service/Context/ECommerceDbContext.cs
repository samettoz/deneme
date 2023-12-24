

using Entity;
using Microsoft.EntityFrameworkCore;

namespace Service.Context
{
    public class ECommerceDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-RBF7FR1\\SQLEXPRESS01; Database = ECommerceDb;Trusted_Connection = true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Order>()
                .Property(o => o.OrderStatus)
                .HasConversion<int>();
        }
    }
}

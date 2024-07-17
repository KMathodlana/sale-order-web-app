using Microsoft.EntityFrameworkCore;

namespace SalesOrderWebApp.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }

        public OrderContext(DbContextOptions options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity => {
                entity.HasKey(k => k.OrderId);
            });
        }
    }
}

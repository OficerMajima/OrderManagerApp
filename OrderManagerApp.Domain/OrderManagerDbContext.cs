using Microsoft.EntityFrameworkCore;
using OrderManagerApp.Domain.Models;
using System.Configuration;

namespace OrderManagerApp.Domain
{
    public class OrderManagerDbContext : DbContext
    {
        public DbSet<MoneyArrival> MoneyArrivals { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

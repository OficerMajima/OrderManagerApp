using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrderManagerApp.Domain.Models;
using System.Configuration;

namespace OrderManagerApp.Domain
{
    public class OrderManagerDbContext : DbContext
    {
        public OrderManagerDbContext(IConfiguration config) : base()
        {
            this.config = config;
        }

        private readonly IConfiguration config;
        public required DbSet<MoneyArrival> MoneyArrivals { get; set; }
        public required DbSet<Order> Orders { get; set; }
        public required DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = config.GetSection("DefaultConnection").Value;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
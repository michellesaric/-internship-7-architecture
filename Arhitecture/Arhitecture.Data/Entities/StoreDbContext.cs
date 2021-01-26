using Arhitecture.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using Arhitecture.Data.Seed;

namespace Arhitecture.Data.Entities
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<OfferPerCategory> OfferPerCategories { get; set; }
        public DbSet<OneOffBill> OneOffBills { get; set; }
        public DbSet<RentBill> RentBills { get; set; }
        public DbSet<ServiceBill> ServiceBills { get; set; }
        public object Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataBaseSeed.Seed(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

    }
    public class StoreFactory : IDesignTimeDbContextFactory<StoreDbContext>
    {
        public StoreDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("App.config")
                .Build();
            configuration
                .Providers
                .First()
                .TryGet("connectionStrings:add:Store:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<StoreDbContext>().UseSqlServer(connectionString).Options;
            return new StoreDbContext(options);
        }
    }
}

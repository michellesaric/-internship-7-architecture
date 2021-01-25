using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Arhitecture.Data.Entities;

namespace Arhitecture.Domain.Factories
{
    public static class DbContextFactory
    {
        public static StoreDbContext GetStoreDbContext()
        {
            var options = new DbContextOptionsBuilder()
                .UseSqlServer(ConfigurationManager.ConnectionStrings["Store"].ConnectionString).Options;
            return new StoreDbContext(options);
        }
    }
}

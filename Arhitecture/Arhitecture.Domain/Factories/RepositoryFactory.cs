using System;
using Arhitecture.Domain.Repositories;

namespace Arhitecture.Domain.Factories
{
    public static class RepositoryFactory
    {
        public static TRepository GetRepository<TRepository>() where TRepository : BaseRepository
        {
            var context = DbContextFactory.GetStoreDbContext();
            return (TRepository)Activator.CreateInstance(typeof(TRepository), context);
        }
    }
}
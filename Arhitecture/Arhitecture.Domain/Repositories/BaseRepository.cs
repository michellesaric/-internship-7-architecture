using Arhitecture.Data.Entities;
using Arhitecture.Domain.Enums;

namespace Arhitecture.Domain.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly StoreDbContext DbContext;

        protected BaseRepository(StoreDbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected ResponseResultType SaveChanges()
        {
            var hasChanges = DbContext.SaveChanges() > 0;
            if (hasChanges)
                return ResponseResultType.Success;

            return ResponseResultType.NoChanges;
        }
    }
}
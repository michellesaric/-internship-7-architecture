using Arhitecture.Data.Entities;
using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Arhitecture.Domain.Repositories
{
    public class ServiceRepository : BaseRepository
    {
        public ServiceRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(int offerId)
        {
            var offer = DbContext.Offers.Find(offerId);
            if (offer == null)
            {
                return ResponseResultType.NotFound;
            }
            var service = new Service
            {
                Offer = offer
            };
            DbContext.Services.Add(service);

            return SaveChanges();
        }

        public ICollection<Service> GetAll()
        {
            return DbContext.Services.ToList();
        }
    }
}

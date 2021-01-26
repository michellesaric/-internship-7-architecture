using Arhitecture.Data.Entities;
using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Arhitecture.Domain.Repositories
{
    public class RentRepository : BaseRepository
    {
        public RentRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(int offerId)
        {
            var offer = DbContext.Offers.Find(offerId);
            if (offer == null)
            {
                return ResponseResultType.NotFound;
            }
            var rent = new Rent
            {
                Offer = offer
            };
            DbContext.Rents.Add(rent);

            return SaveChanges();
        }

        public ICollection<Rent> GetAll()
        {
            return DbContext.Rents.ToList();
        }
    }
}

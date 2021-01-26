using Arhitecture.Data.Entities;
using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Arhitecture.Domain.Repositories
{
    public class OfferRepository : BaseRepository
    {
        public OfferRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Offer offer)
        {
            var sameName = DbContext.Offers.FirstOrDefault(o => o.Name == offer.Name);
            if (sameName != null)
            {
                return ResponseResultType.AlreadyExists;
            }
            DbContext.Offers.Add(offer);
            return SaveChanges();
        }

        public ResponseResultType Edit(Offer offer, int offerId)
        {
            var offerDb = DbContext.Offers.Find(offerId);
            if (offerDb == null)
            {
                return ResponseResultType.NotFound;
            }

            offerDb.Name = offer.Name;
            return SaveChanges();
        }


        public ResponseResultType Delete(int offerId)
        {
            var offer = DbContext.Offers.Find(offerId);
            if (offer == null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Offers.Remove(offer);

            return SaveChanges();
        }
        public ICollection<Offer> GetAll()
        {
            return DbContext.Offers.ToList();
        }

        public int GetLastId()
        {
            var maximumId = DbContext.Offers.Max(o => o.Id);
            return maximumId;
        }
    }
}

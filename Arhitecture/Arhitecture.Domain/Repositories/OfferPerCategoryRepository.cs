using Arhitecture.Data.Entities;
using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Arhitecture.Domain.Repositories
{
    public class OfferPerCategoryRepository : BaseRepository
    {
        public OfferPerCategoryRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(int offerId, int categoryId)
        {
            var offer = DbContext.Offers.Find(offerId);
            if (offer == null)
            {
                return ResponseResultType.NotFound;
            }
            var category = DbContext.Categories.Find(categoryId);
            if (category == null)
            {
                return ResponseResultType.NotFound;
            }
            var offerPerCategory = DbContext.OfferPerCategories.FirstOrDefault(o => o.OfferId == offerId && o.CategoryId == categoryId);
            if (offerPerCategory != null)
            {
                return ResponseResultType.AlreadyExists;
            }

            offerPerCategory = new OfferPerCategory
            {
                Offer = offer,
                Category = category
            };
            DbContext.OfferPerCategories.Add(offerPerCategory);
            return SaveChanges();
        }

        public ResponseResultType Delete(int offerId, int categoryId)
        {
            var offer = DbContext.Offers.Find(offerId);
            if (offer == null)
            {
                return ResponseResultType.NotFound;
            }
            var category = DbContext.Categories.Find(categoryId);
            if (category == null)
            {
                return ResponseResultType.NotFound;
            }
            var offerPerCategory = DbContext.OfferPerCategories.FirstOrDefault(o => o.OfferId == offerId && o.CategoryId == categoryId);
            if (offerPerCategory == null)
            {
                return ResponseResultType.NotFound;
            }
            DbContext.OfferPerCategories.Remove(offerPerCategory);
            return SaveChanges();
        }

        public ICollection<OfferPerCategory> GetAll()
        {
            return DbContext.OfferPerCategories.ToList();
        }

    }
}

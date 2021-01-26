using Arhitecture.Data.Entities;
using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Arhitecture.Domain.Repositories
{
    public class ProductRepository : BaseRepository
    {
        public ProductRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(int offerId)
        {
            var offer = DbContext.Offers.Find(offerId);
            if(offer == null)
            {
                return ResponseResultType.NotFound;
            }
            var product = new Product
            {
                Count = 0,
                Offer = offer
            };
            DbContext.Products.Add(product);

            return SaveChanges();
        }

        public ICollection<Product> GetAll()
        {
            return DbContext.Products.ToList();
        }

        public ResponseResultType Increase(int productId, int increase)
        {
            if(increase < 0)
            {
                return ResponseResultType.ValidationError;
            }
            var product = DbContext.Products.Find(productId);
            if(product == null)
            {
                return ResponseResultType.NotFound;
            }
            product.Count += increase;

            return SaveChanges();
        }

        public ResponseResultType Decrease(int productId, int decrease)
        {
            if (decrease < 0)
            {
                return ResponseResultType.ValidationError;
            }
            var product = DbContext.Products.Find(productId);
            if (product == null)
            {
                return ResponseResultType.NotFound;
            }
            if(decrease > product.Count)
            {
                return ResponseResultType.ValidationError;
            }
            product.Count -= decrease;

            return SaveChanges();
        }

    }
}

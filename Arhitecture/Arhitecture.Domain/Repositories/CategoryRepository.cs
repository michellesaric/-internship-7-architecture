using Arhitecture.Data.Entities;
using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Arhitecture.Domain.Repositories
{
    public class CategoryRepository : BaseRepository
    {
        public CategoryRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Category category)
        {
            var sameName = DbContext.Categories.FirstOrDefault(o => o.Name == category.Name);
            if (sameName != null)
            {
                return ResponseResultType.AlreadyExists;
            }
            DbContext.Categories.Add(category);
            return SaveChanges();
        }

        public ICollection<Category> GetAll()
        {
            return DbContext.Categories.ToList();
        }

        public ResponseResultType Edit(Category category, int categoryId)
        {
            var categoryDb = DbContext.Categories.Find(categoryId);
            if (categoryDb == null)
            {
                return ResponseResultType.NotFound;
            }

            categoryDb.Name = category.Name;
            return SaveChanges();
        }

        public ResponseResultType Delete(int categoryId)
        {
            var category = DbContext.Categories.Find(categoryId);
            if (category == null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Categories.Remove(category);

            return SaveChanges();
        }
    }
}

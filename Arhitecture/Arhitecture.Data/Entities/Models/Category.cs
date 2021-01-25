using System.Collections.Generic;

namespace Arhitecture.Data.Entities.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<OfferPerCategory> OfferPerCategories { get; set; }
    }
}

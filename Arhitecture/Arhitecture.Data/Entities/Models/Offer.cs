using System.Collections.Generic;

namespace Arhitecture.Data.Entities.Models
{
    public class Offer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public ICollection<OfferPerCategory> OfferPerCategories { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Service> Services{ get; set; }
        public ICollection<Rent> Rents{ get; set; }

    }
}

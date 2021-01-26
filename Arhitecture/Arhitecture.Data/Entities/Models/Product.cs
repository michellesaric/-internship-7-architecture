using System.Collections.Generic;

namespace Arhitecture.Data.Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public int Count { get; set; }

        public int? OfferId { get; set; }
        public Offer Offer { get; set; }

        public ICollection<OneOffBill> OneOfBills { get; set; }
    }
}

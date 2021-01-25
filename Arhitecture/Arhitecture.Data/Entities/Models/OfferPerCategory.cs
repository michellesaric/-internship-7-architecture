namespace Arhitecture.Data.Entities.Models
{
    public class OfferPerCategory
    {
        public int Id { get; set; }

        public int OfferId { get; set; }
        public Offer Offer { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}

using System;

namespace Arhitecture.Data.Entities.Models
{
    public class RentBill
    {
        public int Id { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }

        public int? SubscriptionerId { get; set; }
        public Subscriptioner Subscriptioner { get; set; }

        public int? BillId { get; set; }
        public Bill Bill { get; set; }

        public int RentId { get; set; }
        public Rent Rent { get; set; }
    }
}

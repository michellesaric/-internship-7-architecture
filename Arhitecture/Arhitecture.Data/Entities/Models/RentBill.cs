using System;

namespace Arhitecture.Data.Entities.Models
{
    public class RentBill
    {
        public int Id { get; set; }

        public bool isRentActive = false;
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreditCardNumber { get; set; }

        public int? BillId { get; set; }
        public Bill Bill { get; set; }

        public int RentId { get; set; }
        public Rent Rent { get; set; }
    }
}

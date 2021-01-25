using System.Collections.Generic;

namespace Arhitecture.Data.Entities.Models
{
    public class Subscriptioner
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreditCardNumber { get; set; }

        public ICollection<RentBill> RentBills { get; set; }
    }
}

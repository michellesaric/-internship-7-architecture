using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Data.Entities.Models
{
    public class Rent
    {
        public int Id { get; set; }

        public int? OfferId { get; set; }
        public Offer Offer { get; set; }

        public ICollection<RentBill> RentBills { get; set; }
    }
}

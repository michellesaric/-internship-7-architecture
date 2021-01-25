using System;
using System.Collections.Generic;

namespace Arhitecture.Data.Entities.Models
{
    public class Bill
    {
        public int Id { get; set; }

        public DateTime DateAndTimeOfIssue { get; set; }

        public ICollection<OneOffBill> OneOffBills { get; set; }

        public ICollection<ServiceBill> ServiceBills { get; set; }

        public ICollection<RentBill> RentBills { get; set; }

    }
}

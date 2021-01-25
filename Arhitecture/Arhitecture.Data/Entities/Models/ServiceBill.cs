using System;

namespace Arhitecture.Data.Entities.Models
{
    public class ServiceBill
    {
        public int Id { get; set; }
        public DateTime StartingDateAndTime { get; set; }

        public DateTime EndingDateAndTime { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public int BillId { get; set; }
        public Bill Bill { get; set; }

    }
}

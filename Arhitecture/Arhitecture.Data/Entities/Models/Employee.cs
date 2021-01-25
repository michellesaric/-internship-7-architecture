using System;
using System.Collections.Generic;

namespace Arhitecture.Data.Entities.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BeginingOfShift { get; set; }

        public DateTime EndingOfShift { get; set; }

        public ICollection<Bill> Bills { get; set; }
    }
}

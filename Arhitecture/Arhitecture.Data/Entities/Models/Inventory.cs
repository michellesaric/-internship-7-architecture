using System.Collections.Generic;

namespace Arhitecture.Data.Entities.Models
{
    public class Inventory
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

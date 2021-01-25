namespace Arhitecture.Data.Entities.Models
{
    public class OneOffBill
    {
        public int Id { get; set; }

        public int Amount { get; set; }

        public int BillId { get; set; }
        public Bill Bill { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

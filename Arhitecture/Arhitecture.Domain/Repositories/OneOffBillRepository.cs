using Arhitecture.Data.Entities;
using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Domain.Repositories
{
    public class OneOffBillRepository : BaseRepository
    {
        public OneOffBillRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(int billId, int productId, int amount)
        {
            var bill = DbContext.Bills.Find(billId);
            if(bill == null)
            {
                return ResponseResultType.NotFound;
            }
            var product = DbContext.Products.Find(productId);
            if(product == null)
            {
                return ResponseResultType.NotFound;
            }
            if(amount > product.Count)
            {
                return ResponseResultType.ValidationError;
            }
            product.Count -= amount;

            var oneOffBill = new OneOffBill
            {
                Amount = amount,
                Bill = bill,
                Product = product
            };
            DbContext.OneOffBills.Add(oneOffBill);

            return SaveChanges();
        }
        public ICollection<OneOffBill> GetAll()
        {
            return DbContext.OneOffBills.ToList();
        }

        public ResponseResultType Delete(int oneOffBillId)
        {
            var oneOffBill = DbContext.OneOffBills.Find(oneOffBillId);
            if (oneOffBill == null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.OneOffBills.Remove(oneOffBill);

            return SaveChanges();
        }
        public ICollection<OneOffBill> GetAllOneOffBillsInACertainPeriod(DateTime startTime, DateTime endTime)
        {
            return DbContext.OneOffBills
                .Where(o => o.Bill.DateAndTimeOfIssue > startTime && o.Bill.DateAndTimeOfIssue < endTime)
                .ToList();
        }
    }
}

using Arhitecture.Data.Entities;
using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Domain.Repositories
{
    public class RentBillRepository : BaseRepository
    {
        public RentBillRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<RentBill> GetAll()
        {
            return DbContext.RentBills.ToList();
        }

        public ResponseResultType Add(RentBill rentBill, int rentId)
        {
            var rent = DbContext.Rents.Find(rentId);
            if(rent == null)
            {
                return ResponseResultType.NotFound;
            }
            var activeRent = new RentBill
            {
                isRentActive = true,
                StartingDate = rentBill.StartingDate,
                EndingDate = rentBill.EndingDate,
                FirstName = rentBill.FirstName,
                LastName = rentBill.LastName,
                CreditCardNumber = rentBill.CreditCardNumber,
                Rent = rent
            };

            DbContext.RentBills.Add(activeRent);
            return SaveChanges();
        }
        public ResponseResultType Delete(int activeRentId)
        {
            var activeRent = DbContext.RentBills.Find(activeRentId);
            if (activeRent == null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.RentBills.Remove(activeRent);

            return SaveChanges();
        }

        public ICollection<RentBill> GetOnlyActive()
        {
            return (ICollection<RentBill>)DbContext.RentBills.Where(r => r.isRentActive == true);
        }

        public ResponseResultType Update(int activeRentId, int billId)
        {
            var activeRent = DbContext.RentBills.Find(activeRentId);
            if(activeRent == null)
            {
                return ResponseResultType.NotFound;
            }
            activeRent.BillId = billId;
            activeRent.isRentActive = false;

            DbContext.RentBills.Update(activeRent);

            return SaveChanges();
        }
    }
}

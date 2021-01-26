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
    public class BillRepository : BaseRepository
    {
        public BillRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Bill bill)
        {
            
            DbContext.Bills.Add(bill);
            return SaveChanges();
        }

        public int GetLastId()
        {
            var maximumId = DbContext.Bills.Max(o => o.Id);
            return maximumId;
        }
    }
}

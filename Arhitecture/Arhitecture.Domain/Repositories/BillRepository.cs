using Arhitecture.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Domain.Repositories
{
    class BillRepository : BaseRepository
    {
        public BillRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}

using Arhitecture.Data.Entities;
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

    }
}

using Arhitecture.Data.Entities;
using Arhitecture.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Domain.Repositories
{
    public class EmployeeRepository : BaseRepository
    {
        public EmployeeRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Employee> GetAll()
        {
            return DbContext.Employees.ToList();
        }
    }
}

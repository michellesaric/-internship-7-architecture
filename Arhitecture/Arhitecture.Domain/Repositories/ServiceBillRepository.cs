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
    public class ServiceBillRepository : BaseRepository
    {
        public ServiceBillRepository(StoreDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(int billId, int serviceId, int employeeId, DateTime startingTime, DateTime endingTime)
        {
            var bill = DbContext.Bills.Find(billId);
            if (bill == null)
            {
                return ResponseResultType.NotFound;
            }
            var service = DbContext.Services.Find(serviceId);
            if (service == null)
            {
                return ResponseResultType.NotFound;
            }
            var employee = DbContext.Employees.Find(employeeId);
            if(employee == null)
            {
                return ResponseResultType.NotFound;
            }

            if(employee.BeginingOfShift > startingTime || employee.EndingOfShift < endingTime)
            {
                return ResponseResultType.ValidationError;
            }

            var serviceBill = new ServiceBill
            {
                StartingTime = startingTime,
                EndingTime = endingTime,
                Employee = employee,
                Service = service
            };
            DbContext.ServiceBills.Add(serviceBill);

            return SaveChanges();
        }

        public ICollection<ServiceBill> GetAll()
        {
            return DbContext.ServiceBills.ToList();
        }

        public ResponseResultType Delete(int serviceBillId)
        {
            var serviceBill = DbContext.ServiceBills.Find(serviceBillId);
            if (serviceBill == null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.ServiceBills.Remove(serviceBill);

            return SaveChanges();
        }
        public ICollection<ServiceBill> GetAllServiceBillsInACertainPeriod(DateTime startTime, DateTime endTime)
        {
            {
                return DbContext.ServiceBills
                    .Where(s => s.Bill.DateAndTimeOfIssue > startTime && s.Bill.DateAndTimeOfIssue < endTime)
                    .ToList();
            }
        }
    }
}

using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Constants;
using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.BillActions
{
    public class ServiceBillAddAction : IAction
    {
        private readonly BillRepository _billRepository;
        private readonly ServiceRepository _serviceRepository;
        private readonly ServiceBillRepository _serviceBillRepository;
        private readonly EmployeeRepository _employeeRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Add a service bill";

        public ServiceBillAddAction(BillRepository billRepository, ServiceRepository serviceRepository, ServiceBillRepository serviceBillRepository, EmployeeRepository employeeRepository)
        {
            _billRepository = billRepository;
            _serviceRepository = serviceRepository;
            _serviceBillRepository = serviceBillRepository;
            _employeeRepository = employeeRepository;
        }

        public void Call()
        {
            var bill = new Bill
            {
                DateAndTimeOfIssue = DateTime.Now
            };

            var responseResult = _billRepository.Add(bill);
            if (responseResult != ResponseResultType.Success)
            {
                Console.WriteLine("Error adding date and time");
                return;
            }

            var services = _serviceRepository.GetAll();
            PrintHelpers.PrintServices(services);

            Console.WriteLine("Enter Service Id or exit");
            var isRead = ReadHelpers.TryReadNumber(out var serviceId);
            if (!isRead)
                return;

            var employees = _employeeRepository.GetAll();
            PrintHelpers.PrintEmployees(employees);

            Console.WriteLine("Enter Employee Id or exit");
            isRead = ReadHelpers.TryReadNumber(out var employeeId);
            if (!isRead)
                return;

            Console.WriteLine("Enter starting time (1/1/1 HH:mm)");
            var startingTime = DateTime.ParseExact(Console.ReadLine(), DateConstants.DateAndTimeFormat, null);


            Console.WriteLine("Enter ending time (1/1/1 HH:mm)");
            var endingTime = DateTime.ParseExact(Console.ReadLine(), DateConstants.DateAndTimeFormat, null);

            var lastId = _billRepository.GetLastId();

            responseResult = _serviceBillRepository.Add(lastId, serviceId, employeeId, startingTime, endingTime);

            if (responseResult != ResponseResultType.Success)
                return;

        }
    }
}

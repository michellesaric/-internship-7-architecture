using Arhitecture.Domain.Constants;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.Reports
{
    public class PrintingAllBillsSoldInACertainPeriod
    {
        private readonly OneOffBillRepository _oneOffBillRepository;
        private readonly ServiceBillRepository _serviceBillRepository;
        private readonly RentBillRepository _rentBillRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Getting all the bills in a certain period of time";

        public PrintingAllBillsSoldInACertainPeriod(OneOffBillRepository oneOffBillRepository, ServiceBillRepository serviceBillRepository, RentBillRepository rentBillRepository)
        {
            _oneOffBillRepository = oneOffBillRepository;
            _serviceBillRepository = serviceBillRepository;
            _rentBillRepository = rentBillRepository;
        }

        public void Call()
        {
            Console.WriteLine("Enter a starting date");
            var startingDate = DateTime.ParseExact(Console.ReadLine(), DateConstants.DateFormat, null);

            Console.WriteLine("Enter an ending date");
            var endingDate = DateTime.ParseExact(Console.ReadLine(), DateConstants.DateFormat, null);

            if (endingDate < startingDate)
            {
                Console.WriteLine("Invalid insert of date");
                return;
            }

            var oneOffBills = _oneOffBillRepository.GetAllOneOffBillsInACertainPeriod(startingDate, endingDate);
            if (oneOffBills == null)
            {
                Console.WriteLine("There are none");
            }
            else
            {
                PrintHelpers.PrintOneOffBills(oneOffBills);
            }
            var serviceBills = _serviceBillRepository.GetAllServiceBillsInACertainPeriod(startingDate, endingDate);
            if (serviceBills == null)
            {
                Console.WriteLine("There are none");
            }
            else
            {
                PrintHelpers.PrintServiceBills(serviceBills);
            }
            var rentBills = _rentBillRepository.GetAllRentBillsInACertainPeriod(startingDate, endingDate);
            if (rentBills == null)
            {
                Console.WriteLine("There are none");
            }
            else
            {
                PrintHelpers.PrintRentBills(rentBills);
            }

        }
    }
}

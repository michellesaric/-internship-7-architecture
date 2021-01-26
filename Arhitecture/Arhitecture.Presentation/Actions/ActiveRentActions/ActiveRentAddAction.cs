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

namespace Arhitecture.Presentation.Actions.ActiveRentActions
{
    public class ActiveRentAddAction : IAction
    {
        private readonly RentRepository _rentRepository;
        private readonly RentBillRepository _rentBillRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Add an active rent";

        public ActiveRentAddAction(RentRepository rentRepository, RentBillRepository rentBillRepository)
        {
            _rentRepository = rentRepository;
            _rentBillRepository = rentBillRepository;
        }

        public void Call()
        {
            var activeRent = new RentBill();

            activeRent.isRentActive = true;

            Console.WriteLine("Enter starting time (dd/MM/yyyy)");
            activeRent.StartingDate = DateTime.ParseExact(Console.ReadLine(), DateConstants.DateAndTimeFormat, null);


            Console.WriteLine("Enter ending time (dd/MM/yyyy)");
            activeRent.EndingDate = DateTime.ParseExact(Console.ReadLine(), DateConstants.DateFormat, null);

            Console.WriteLine("Enter subscriptioner's first name");
            activeRent.FirstName = Console.ReadLine();

            Console.WriteLine("Enter subscriptioner's last name");
            activeRent.LastName = Console.ReadLine();

            Console.WriteLine("Enter subscriptioner's credit card number:");
            activeRent.CreditCardNumber = Console.ReadLine();

            var rents = _rentRepository.GetAll();
            PrintHelpers.PrintRents(rents);

            Console.WriteLine("Enter the id of Rent or exit");
            var isRead = ReadHelpers.TryReadNumber(out var rentId);
            if (!isRead)
                return;

            var responseResult = _rentBillRepository.Add(activeRent, rentId);
            if (responseResult == ResponseResultType.Success)
            {
                PrintHelpers.PrintActiveRent(activeRent);
                Console.ReadLine();
                return;
            }


        }


    }
}

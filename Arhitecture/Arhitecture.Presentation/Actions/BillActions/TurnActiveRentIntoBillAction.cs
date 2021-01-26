using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;

namespace Arhitecture.Presentation.Actions.BillActions
{
    public class TurnActiveRentIntoBillAction : IAction
    {
        private readonly BillRepository _billRepository;
        private readonly RentBillRepository _rentBillRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Turn active rent into a bill";

        public TurnActiveRentIntoBillAction(BillRepository billRepository, RentBillRepository rentBillRepository)
        {
            _billRepository = billRepository;
            _rentBillRepository = rentBillRepository;
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

            var activeRents = _rentBillRepository.GetOnlyActive();
            PrintHelpers.PrintActiveRents(activeRents);

            Console.WriteLine("Enter Active Rent Id or exit");
            var isRead = ReadHelpers.TryReadNumber(out var activeRentId);
            if (!isRead)
                return;

            var lastId = _billRepository.GetLastId();
            responseResult = _rentBillRepository.Update(activeRentId, lastId);
            if (responseResult == ResponseResultType.Success)
            {
                return;
            }


        }
    }
}

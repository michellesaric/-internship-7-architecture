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
    public class RemovingAnActiveRentAction : IAction
    {
        private readonly RentBillRepository _rentBillRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Remove an active rent";

        public RemovingAnActiveRentAction(RentBillRepository rentBillRepository)
        {
            _rentBillRepository = rentBillRepository;
        }

        public void Call()
        {
            var activeRents = _rentBillRepository.GetOnlyActive();
            PrintHelpers.PrintActiveRents(activeRents);

            Console.WriteLine("Type in Active Rent Id or exit");
            var isRead = ReadHelpers.TryReadNumber(out var activeRentId);
            if (!isRead)
                return;

            var result = _rentBillRepository.Delete(activeRentId);
            if (result == ResponseResultType.NotFound)
            {
                Console.WriteLine("Active rent not found");
            }

            if (result == ResponseResultType.Success)
            {
                Console.WriteLine("Active rent successfully deleted");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}

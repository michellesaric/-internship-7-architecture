using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;

namespace Arhitecture.Presentation.Actions.Reports
{
    public class PrintingAllActiveRents : IAction
    {
        private readonly RentBillRepository _rentBillRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Remove an active rent";

        public PrintingAllActiveRents(RentBillRepository rentBillRepository)
        {
            _rentBillRepository = rentBillRepository;
        }

        public void Call()
        {
            var activeRents = _rentBillRepository.GetOnlyActive();

            if(activeRents == null)
            {
                Console.WriteLine("There are none");
                return;
            }
            PrintHelpers.PrintActiveRents(activeRents);

        }
    }
}

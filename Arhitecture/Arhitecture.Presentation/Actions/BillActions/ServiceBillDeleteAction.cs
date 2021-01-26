using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;

namespace Arhitecture.Presentation.Actions.BillActions
{
    public class ServiceBillDeleteAction : IAction
    {
        private readonly ServiceBillRepository _serviceBillRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Delete a service bill";

        public ServiceBillDeleteAction(ServiceBillRepository serviceBillRepository)
        {
            _serviceBillRepository = serviceBillRepository;
        }
        public void Call()
        {
            var serviceBills = _serviceBillRepository.GetAll();
            PrintHelpers.PrintServiceBills(serviceBills);

            Console.WriteLine("Type in ServiceBill Id or exit");
            var isRead = ReadHelpers.TryReadNumber(out var oneOffBillId);
            if (!isRead)
                return;

            var result = _serviceBillRepository.Delete(oneOffBillId);

            if (result == ResponseResultType.NotFound)
            {
                Console.WriteLine("One-off bill not found");
            }

            if (result == ResponseResultType.Success)
            {
                Console.WriteLine("One-off bill successfully deleted");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}

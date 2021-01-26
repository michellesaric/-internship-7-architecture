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
    public class OneOffBillDeleteAction : IAction
    {
        private readonly OneOffBillRepository _oneOffBillRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Delete a one-off bill";

        public OneOffBillDeleteAction(OneOffBillRepository oneOffBillRepository)
        {
            _oneOffBillRepository = oneOffBillRepository;
        }
        public void Call()
        {
            var oneOffBills = _oneOffBillRepository.GetAll();
            PrintHelpers.PrintOneOffBills(oneOffBills);

            Console.WriteLine("Type in OneOffBill Id or exit");
            var isRead = ReadHelpers.TryReadNumber(out var oneOffBillId);
            if (!isRead)
                return;

            var result = _oneOffBillRepository.Delete(oneOffBillId);
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

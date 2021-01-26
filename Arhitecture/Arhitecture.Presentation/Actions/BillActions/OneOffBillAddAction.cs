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
    public class OneOffBillAddAction : IAction
    {
        private readonly BillRepository _billRepository;
        private readonly ProductRepository _productRepository;
        private readonly OneOffBillRepository _oneOffBillRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Add a one-off bill";

        public OneOffBillAddAction(BillRepository billRepository, ProductRepository productRepository, OneOffBillRepository oneOffBillRepository)
        {
            _billRepository = billRepository;
            _oneOffBillRepository = oneOffBillRepository;
            _productRepository = productRepository;
        }

        public void Call()
        {
            var bill = new Bill
            {
                DateAndTimeOfIssue = DateTime.Now
            };

            var responseResult = _billRepository.Add(bill);
            if(responseResult != ResponseResultType.Success)
            {
                Console.WriteLine("Error adding date and time");
                return;
            }

            Console.WriteLine("Enter how many products do you want the bill to have:");
            var isRead = ReadHelpers.TryReadNumber(out var numberOfProducts);
            if (!isRead)
                return;

            var products = _productRepository.GetAll();
            PrintHelpers.PrintProducts(products);

            var lastId = _billRepository.GetLastId();

            for (var i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine("Enter the id of Product or exit");
                isRead = ReadHelpers.TryReadNumber(out var productId);
                if (!isRead)
                    return;

                Console.WriteLine("Enter the amount of product:");
                isRead = ReadHelpers.TryReadNumber(out var amount);
                if (!isRead)
                    return; 
                
                responseResult = _oneOffBillRepository.Add(lastId, productId, amount);

                if (responseResult != ResponseResultType.Success)
                    return;
            }
        }
    }
}

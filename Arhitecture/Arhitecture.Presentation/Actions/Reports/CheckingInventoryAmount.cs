using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.Reports
{
    public class CheckingInventoryAmount : IAction
    {
        private readonly ProductRepository _productRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Checking amount in inventory";

        public CheckingInventoryAmount(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Call()
        {
            Console.WriteLine("Please enter < or >");
            var operatingSymbol = Console.ReadLine();
            
            Console.WriteLine("Enter a number");
            var isRead = ReadHelpers.TryReadNumber(out var number);
            if (!isRead)
                return;

            if (operatingSymbol == "<")
            {
                var products = _productRepository.GetLower(number);
                PrintHelpers.PrintProducts(products);
            }
            else if (operatingSymbol == ">")
            {
                var products = _productRepository.GetHigher(number);
                PrintHelpers.PrintProducts(products);
            }
            else
                return;
        }
    }
}

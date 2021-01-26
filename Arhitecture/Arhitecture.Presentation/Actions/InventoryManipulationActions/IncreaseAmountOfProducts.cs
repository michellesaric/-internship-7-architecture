using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.InventoryManipulationActions
{
    public class IncreaseAmountOfProducts : IAction
    {
        private readonly ProductRepository _productRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Increase amount";

        public IncreaseAmountOfProducts(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Call()
        {
            var products = _productRepository.GetAll();
            PrintHelpers.PrintProducts(products);

            Console.WriteLine("Type in Product Id or exit");
            var isRead = ReadHelpers.TryReadNumber(out var productId);
            if (!isRead)
                return;

            Console.WriteLine("Insert the amount you would like to increase with:");
            isRead = ReadHelpers.TryReadNumber(out var increase);
            if (!isRead)
                return;

            var result = _productRepository.Increase(productId, increase);
            if (result == ResponseResultType.NotFound)
            {
                Console.WriteLine("Product not found");
            }

            if (result == ResponseResultType.Success)
            {
                Console.WriteLine("Product successfully increased");
            }

            if (result == ResponseResultType.NoChanges)
            {
                Console.WriteLine("No changes have been applied");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}

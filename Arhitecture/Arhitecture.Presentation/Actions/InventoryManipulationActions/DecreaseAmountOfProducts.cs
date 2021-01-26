using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;

namespace Arhitecture.Presentation.Actions.InventoryManipulationActions
{
    public class DecreaseAmountOfProducts : IAction
    {
        private readonly ProductRepository _productRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Decrease amount";

        public DecreaseAmountOfProducts(ProductRepository productRepository)
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

            Console.WriteLine("Insert the amount you would like to decrease with:");
            isRead = ReadHelpers.TryReadNumber(out var decrease);
            if (!isRead)
                return;

            var result = _productRepository.Decrease(productId, decrease);
            if (result == ResponseResultType.NotFound)
            {
                Console.WriteLine("Product not found");
            }

            if (result == ResponseResultType.Success)
            {
                Console.WriteLine("Product successfully decreased");
            }

            if (result == ResponseResultType.NoChanges)
            {
                Console.WriteLine("No changes have been applied");
            }

            if(result == ResponseResultType.ValidationError)
            {
                Console.WriteLine("Entered number that is higher than existing");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}

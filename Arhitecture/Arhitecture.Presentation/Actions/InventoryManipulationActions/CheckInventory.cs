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
    public class CheckInventory : IAction
    {
        private readonly ProductRepository _productRepository;
        private readonly ServiceRepository _serviceRepository;
        private readonly RentRepository _rentRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Overlook of the inventory";

        public CheckInventory(ProductRepository productRepository, ServiceRepository serviceRepository, RentRepository rentRepository)
        {
            _productRepository = productRepository;
            _serviceRepository = serviceRepository;
            _rentRepository = rentRepository;
        }

        public void Call()
        {
            var products = _productRepository.GetAll();
            PrintHelpers.PrintProducts(products);

            Console.WriteLine();
            Console.WriteLine();

            var services = _serviceRepository.GetAll();
            PrintHelpers.PrintServices(services);

            Console.WriteLine();
            Console.WriteLine();

            var rents = _rentRepository.GetAll();
            PrintHelpers.PrintRents(rents);

            Console.ReadLine();
            Console.Clear();
        }
    }
}

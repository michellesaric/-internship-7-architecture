using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;

namespace Arhitecture.Presentation.Actions.OfferActions
{
    public class OfferAddAction : IAction
    {
        private readonly OfferRepository _offerRepository;
        private readonly ProductRepository _productRepository;
        private readonly ServiceRepository _serviceRepository;
        private readonly RentRepository _rentRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Add an offer";

        public OfferAddAction(OfferRepository offerRepository, ProductRepository productRepository, ServiceRepository serviceRepository, RentRepository rentRepository)
        {
            _offerRepository = offerRepository;
            _productRepository = productRepository;
            _serviceRepository = serviceRepository;
            _rentRepository = rentRepository;
        }

        public void Call()
        {
            var offer = new Offer();

            Console.WriteLine("Choose which type of offer would you like to enter:");
            Console.WriteLine("1 - Product \n2 - Service \n3 - Rent \n");

            var isRead = ReadHelpers.TryReadNumberBetween1And3(out var option);
            if (!isRead)
                return;

            Console.WriteLine("Enter the name of the offer");
            offer.Name = Console.ReadLine();

            Console.WriteLine("Enter the price of the offer");
            var isDecimal = decimal.TryParse(Console.ReadLine(), out var price);
            if (!isDecimal)
            {
                Console.WriteLine("Error not decimal value");
                Console.ReadLine();
                return;
            }
            offer.Price = price;

            var responseResult = _offerRepository.Add(offer);
            if (responseResult == ResponseResultType.Success)
            {
                PrintHelpers.PrintOffer(offer);
                var lastId = _offerRepository.GetLastId();
                switch(option)
                {
                    case (int)OfferType.Product:
                        responseResult = _productRepository.Add(lastId);
                        break;
                    case (int)OfferType.Service:
                        responseResult = _serviceRepository.Add(lastId);
                        break;
                    case (int)OfferType.Rent:
                        responseResult = _rentRepository.Add(lastId);
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
                return;
            }
        }
    }
}

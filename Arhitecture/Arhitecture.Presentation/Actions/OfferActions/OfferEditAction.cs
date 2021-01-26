using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;
using System.Linq;

namespace Arhitecture.Presentation.Actions.OfferActions
{
    public class OfferEditAction : IAction
    {
        private readonly OfferRepository _offerRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Edit offers";

        public OfferEditAction(OfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }

        public void Call()
        {
            var offers = _offerRepository.GetAll();
            PrintHelpers.PrintOffers(offers);

            var isRead = ReadHelpers.TryReadNumber(out var offerId);
            if (!isRead)
                return;

            var offer = offers.First(o => o.Id == offerId);

            Console.WriteLine("Press enter to skip edit");

            Console.WriteLine($"Name: ({offer.Name})");
            offer.Name = ReadHelpers.TryReadLineIfNotEmpty(out var name)
                ? name
                : offer.Name;

            var result = _offerRepository.Edit(offer, offerId);

            if (result == ResponseResultType.NotFound)
            {
                Console.WriteLine("Offer not found");
            }

            if (result == ResponseResultType.Success)
            {
                PrintHelpers.PrintOffer(offer);
            }

            if (result == ResponseResultType.NoChanges)
            {
                Console.WriteLine("No changes applied");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}

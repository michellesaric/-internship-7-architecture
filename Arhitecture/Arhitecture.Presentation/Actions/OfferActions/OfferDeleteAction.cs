using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;

namespace Arhitecture.Presentation.Actions.OfferActions
{
    public class OfferDeleteAction : IAction
    {
        private readonly OfferRepository _offerRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Remove offer";

        public OfferDeleteAction(OfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }

        public void Call()
        {
            var offers = _offerRepository.GetAll();
            PrintHelpers.PrintOffers(offers);

            Console.WriteLine("Type in Offer Id or exit");
            var isRead = ReadHelpers.TryReadNumber(out var offerId);
            if (!isRead)
                return;

            var result = _offerRepository.Delete(offerId);
            if (result == ResponseResultType.NotFound)
            {
                Console.WriteLine("Offer not found");
            }

            if (result == ResponseResultType.Success)
            {
                Console.WriteLine("Offer successfully added");
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

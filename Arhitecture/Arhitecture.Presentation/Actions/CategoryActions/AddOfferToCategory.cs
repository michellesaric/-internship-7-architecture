using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;

namespace Arhitecture.Presentation.Actions.CategoryActions
{
    public class AddOfferToCategory : IAction
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly OfferRepository _offerRepository;
        private readonly OfferPerCategoryRepository _offerPerCategoryRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Add an offer to category";

        public AddOfferToCategory(CategoryRepository categoryRepository, OfferRepository offerRepository, OfferPerCategoryRepository offerPerCategoryRepository)
        {
            _categoryRepository = categoryRepository;
            _offerRepository = offerRepository;
            _offerPerCategoryRepository = offerPerCategoryRepository;
        }

        public void Call()
        {
            var offersPerCategories = _offerPerCategoryRepository.GetAll();
            PrintHelpers.PrintOffersPerCategories(offersPerCategories);

            Console.WriteLine("Type in Offer Id or exit");
            var isRead = ReadHelpers.TryReadNumber(out var offerId);
            if (!isRead)
                return;

            Console.WriteLine("Type in Category Id or exit");
            isRead = ReadHelpers.TryReadNumber(out var categoryId);
            if (!isRead)
                return;

            var result = _offerPerCategoryRepository.Add(offerId, categoryId);
            if (result == ResponseResultType.NotFound)
            {
                Console.WriteLine("Category or Offer not found");
            }

            if (result == ResponseResultType.Success)
            {
                Console.WriteLine("Successfully added an offer to a category");
            }

            if (result == ResponseResultType.AlreadyExists)
            {
                Console.WriteLine("There is already an offer in a category you chose");
            }

            Console.ReadLine();
            Console.Clear();

        }
    }
}

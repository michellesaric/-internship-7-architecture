using Arhitecture.Presentation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.BillActions
{
    class AddOneOffBill : IAction
    {
        private readonly BillRepository _billRepository;
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
    }
}

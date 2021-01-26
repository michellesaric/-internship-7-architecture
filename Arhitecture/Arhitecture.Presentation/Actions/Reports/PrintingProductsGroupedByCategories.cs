using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.Reports
{
    public class PrintingProductsGroupedByCategories : IAction
    {
        private readonly OneOffBillRepository _oneOffBillRepository;
        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Count sold products by category";

        public PrintingProductsGroupedByCategories(OneOffBillRepository oneOffBillRepository)
        {
            _oneOffBillRepository = oneOffBillRepository;
        }

        public void Call()
        {
            
        }
    }
}

using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.CategoryActions
{
    class CategoryDeleteAction : IAction
    {
        private readonly CategoryRepository _categoryRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Add category";

        public CategoryDeleteAction(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Call()
        {
            var categories = _categoryRepository.GetAll();
            PrintHelpers.PrintCategories(categories);

            Console.WriteLine("Type in Category Id or exit");
            var isRead = ReadHelpers.TryReadNumber(out var categoryId);
            if (!isRead)
                return;

            var result = _categoryRepository.Delete(categoryId);
            if (result == ResponseResultType.NotFound)
            {
                Console.WriteLine("Category not found");
            }

            if (result == ResponseResultType.Success)
            {
                Console.WriteLine("Category successfully deleted");
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

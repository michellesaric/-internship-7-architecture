using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;
using System.Linq;

namespace Arhitecture.Presentation.Actions.CategoryActions
{
    public class CategoryEditAction : IAction
    {
        private readonly CategoryRepository _categoryRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Edit category";

        public CategoryEditAction(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Call()
        {
            var categories = _categoryRepository.GetAll();
            PrintHelpers.PrintCategories(categories);

            var isRead = ReadHelpers.TryReadNumber(out var categoryId);
            if (!isRead)
                return;

            var category = categories.First(c => c.Id == categoryId);

            Console.WriteLine("Press enter to skip edit");

            Console.WriteLine($"Name: ({category.Name})");
            category.Name = ReadHelpers.TryReadLineIfNotEmpty(out var name)
                ? name
                : category.Name;

            var result = _categoryRepository.Edit(category, categoryId);

            if (result == ResponseResultType.NotFound)
            {
                Console.WriteLine("Category not found");
            }

            if (result == ResponseResultType.Success)
            {
                PrintHelpers.PrintCategory(category);
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

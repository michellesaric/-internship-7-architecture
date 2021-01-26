using Arhitecture.Data.Entities.Models;
using Arhitecture.Domain.Enums;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Helpers;
using System;

namespace Arhitecture.Presentation.Actions.CategoryActions
{
    public class CategoryAddAction : IAction
    {
        private readonly CategoryRepository _categoryRepository;

        public int MenuIndex { get; set; }
        public string Label { get; set; } = "Add category";

        public CategoryAddAction(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Call()
        {
            var category = new Category();

            Console.WriteLine("Enter the name of the category");
            category.Name = Console.ReadLine();

            var responseResult = _categoryRepository.Add(category);
            if (responseResult == ResponseResultType.Success)
            {
                PrintHelpers.PrintCategory(category);
                Console.ReadLine();
                return;
            }
        }
        
    }
}

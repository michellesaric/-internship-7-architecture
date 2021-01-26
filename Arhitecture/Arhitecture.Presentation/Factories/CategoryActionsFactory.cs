using Arhitecture.Domain.Factories;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Actions;
using Arhitecture.Presentation.Actions.CategoryActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Factories
{
    public static class CategoryActionsFactory
    {
        public static CategoryParentAction GetCategoryParentAction()
        {
            var categoryActions = new List<IAction>
            {
                new CategoryAddAction(RepositoryFactory.GetRepository<CategoryRepository>()),
                new CategoryEditAction(RepositoryFactory.GetRepository<CategoryRepository>()),
                new CategoryDeleteAction(RepositoryFactory.GetRepository<CategoryRepository>()),
                new AddOfferToCategoryAction
                (
                    RepositoryFactory.GetRepository<CategoryRepository>(),
                    RepositoryFactory.GetRepository<OfferRepository>(),
                    RepositoryFactory.GetRepository<OfferPerCategoryRepository>()
                ),
                new DeleteAnOfferFromCategoryAction
                (
                    RepositoryFactory.GetRepository<CategoryRepository>(),
                    RepositoryFactory.GetRepository<OfferRepository>(),
                    RepositoryFactory.GetRepository<OfferPerCategoryRepository>()
                ),
                new ExitMenuAction()
            };

            var categoryParentAction = new CategoryParentAction(categoryActions);
            return categoryParentAction;
        }
    }
}

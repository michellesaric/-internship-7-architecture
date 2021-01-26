using Arhitecture.Domain.Factories;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Actions;
using Arhitecture.Presentation.Actions.InventoryManipulationActions;
using System.Collections.Generic;

namespace Arhitecture.Presentation.Factories
{
    public static class InventoryManipulationFactory
    {
        public static InventoryManipulationParentAction GetInventoryParentAction()
        {
            var inventoryActions = new List<IAction>
            {
                new IncreaseAmountOfProducts(RepositoryFactory.GetRepository<ProductRepository>()),
                new DecreaseAmountOfProducts(RepositoryFactory.GetRepository<ProductRepository>()),
                new CheckInventory
                (
                    RepositoryFactory.GetRepository<ProductRepository>(), 
                    RepositoryFactory.GetRepository<ServiceRepository>(),
                    RepositoryFactory.GetRepository<RentRepository>()
                ),
                new ExitMenuAction()
            };

            var inventoryParentAction = new InventoryManipulationParentAction(inventoryActions);
            return inventoryParentAction;
        }
    }
}

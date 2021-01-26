using Arhitecture.Domain.Factories;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Actions;
using Arhitecture.Presentation.Actions.OfferActions;
using System.Collections.Generic;

namespace Arhitecture.Presentation.Factories
{
    public static class OfferActionsFactory
    {
        public static OfferParentAction GetOfferParentAction()
        {
            var offerActions = new List<IAction>
            {
                new OfferAddAction
                (
                    RepositoryFactory.GetRepository<OfferRepository>(),
                    RepositoryFactory.GetRepository<ProductRepository>(),
                    RepositoryFactory.GetRepository<ServiceRepository>(),
                    RepositoryFactory.GetRepository<RentRepository>()
                ),
                new OfferEditAction(RepositoryFactory.GetRepository<OfferRepository>()),
                new OfferDeleteAction(RepositoryFactory.GetRepository<OfferRepository>()),
                new ExitMenuAction()
            };

            var offerParentAction = new OfferParentAction(offerActions);
            return offerParentAction;
        }
    }
}

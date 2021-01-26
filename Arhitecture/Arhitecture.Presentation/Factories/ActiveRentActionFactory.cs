using Arhitecture.Domain.Factories;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Actions;
using Arhitecture.Presentation.Actions.ActiveRentActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Factories
{
    public class ActiveRentActionFactory
    {
        public static ActiveRentParentAction GetActiveRentParentAction()
        {
            var activeRentActions = new List<IAction>
            {
                new ActiveRentAddAction(RepositoryFactory.GetRepository<RentRepository>(),RepositoryFactory.GetRepository<RentBillRepository>()),
                new RemovingAnActiveRentAction(RepositoryFactory.GetRepository<RentBillRepository>()),
                new ExitMenuAction()
            };

            var activeRentParentAction = new ActiveRentParentAction(activeRentActions);
            return activeRentParentAction;
        }
    }
}

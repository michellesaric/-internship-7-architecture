using Arhitecture.Domain.Factories;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Actions;
using Arhitecture.Presentation.Actions.BillActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Factories
{
    public static class BillActionsFactory
    {
        public static BillParentAction GetBillParentAction()
        {
            var billActions = new List<IAction>
            {
                new OneOffBillAddAction(RepositoryFactory.GetRepository<BillRepository>(), RepositoryFactory.GetRepository<ProductRepository>(),RepositoryFactory.GetRepository<OneOffBillRepository>()),
                new OneOffBillDeleteAction(RepositoryFactory.GetRepository<OneOffBillRepository>()),
                new ServiceBillAddAction(RepositoryFactory.GetRepository<BillRepository>(), RepositoryFactory.GetRepository<ServiceRepository>(),RepositoryFactory.GetRepository<ServiceBillRepository>(),RepositoryFactory.GetRepository<EmployeeRepository>()),
                new ServiceBillDeleteAction(RepositoryFactory.GetRepository<ServiceBillRepository>()),
                new TurnActiveRentIntoBillAction(RepositoryFactory.GetRepository<BillRepository>(),RepositoryFactory.GetRepository<RentBillRepository>()),
                new ExitMenuAction()
            };

            var billParentAction = new BillParentAction(billActions);
            return billParentAction;
        }
    }
}

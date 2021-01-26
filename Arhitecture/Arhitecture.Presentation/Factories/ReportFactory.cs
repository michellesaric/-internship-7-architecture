using Arhitecture.Domain.Factories;
using Arhitecture.Domain.Repositories;
using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Actions;
using Arhitecture.Presentation.Actions.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Factories
{
    public class ReportFactory
    {
        public static ReportParentAction GetReportParentAction()
        {
            var reportActions = new List<IAction>
            {
                new CheckingInventoryAmount(RepositoryFactory.GetRepository<ProductRepository>()),
                new PrintingAllActiveRents(RepositoryFactory.GetRepository<RentBillRepository>()),
                new ExitMenuAction()
            };

            var reportParentAction = new ReportParentAction(reportActions);
            return reportParentAction;
        }
    }
}

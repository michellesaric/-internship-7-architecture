﻿using Arhitecture.Presentation.Abstractions;
using Arhitecture.Presentation.Actions;
using Arhitecture.Presentation.Extensions;
using System.Collections.Generic;

namespace Arhitecture.Presentation.Factories
{
    public static class MainMenuFactory
    {
        public static IList<IAction> GetMainMenuActions()
        {
            var actions = new List<IAction>
            {
                OfferActionsFactory.GetOfferParentAction(),
                InventoryManipulationFactory.GetInventoryParentAction(),
                CategoryActionsFactory.GetCategoryParentAction(),
                BillActionsFactory.GetBillParentAction(),
                ActiveRentActionFactory.GetActiveRentParentAction(),
                ReportFactory.GetReportParentAction(),
                new ExitMenuAction()
            };

            actions.SetActionIndexes();
            return actions;
        }
    }

}

using Arhitecture.Presentation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.InventoryManipulationActions
{
    public class InventoryManipulationParentAction : BaseParentAction
    {
        public InventoryManipulationParentAction(IList<IAction> actions) : base(actions)
        {
            Label = "Manage inventory";
        }

        public override void Call()
        {
            Console.WriteLine("Inventory management");
            base.Call();
        }
    }
}

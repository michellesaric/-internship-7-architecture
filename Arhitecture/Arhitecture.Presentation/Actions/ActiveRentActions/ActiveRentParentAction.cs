using Arhitecture.Presentation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.ActiveRentActions
{
    public class ActiveRentParentAction : BaseParentAction
    {
        public ActiveRentParentAction(IList<IAction> actions) : base(actions)
        {
            Label = "Manage active rents";
        }

        public override void Call()
        {
            Console.WriteLine("Active rent management");
            base.Call();
        }
    }
}

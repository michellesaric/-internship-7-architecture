using Arhitecture.Presentation.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Actions.Reports
{
    public class ReportParentAction : BaseParentAction
    {
        public ReportParentAction(IList<IAction> actions) : base(actions)
        {
            Label = "Manage reports";
        }

        public override void Call()
        {
            Console.WriteLine("Report management");
            base.Call();
        }
    }
}
